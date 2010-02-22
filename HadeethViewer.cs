using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Xml;
using System.Reflection;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace eQuran {

    class Hadeeth {
        string fHadeeth, fSand;
        string fBook, fChapter, fTopic;

        public Hadeeth() {
        }
        
        public Hadeeth(string Hadeeth, string Sand) {
            fHadeeth = Hadeeth;
            fSand = Sand;
        }

        public Hadeeth(string Hadeeth, string Sand, string Book, string Chapter, string Topic) {

            fHadeeth = Hadeeth;
            fSand = Sand;
            fBook = Book;
            fChapter = Chapter;
            fTopic = Topic;

        }

        public string HadeethContent {
            get {
                return fHadeeth;
            }
            set {
                fHadeeth = value;
            }
        }

        public string Sand {
            get {
                return fSand;
            }
            set {
                fSand = value;
            }
        }

        public string Topic {
            get {
                return fTopic;
            }
            set {
                fTopic = value;
            }
        }      

        public string Chapter {
            get {
                return fChapter;
            }
            set {
                fChapter = value;
            }
        }  
        
        public string Book {
            get {
                return fBook;
            }
            set {
                fBook = value;
            }
        }

    }

    class HadeethCollection : CollectionBase {

        public event EventHandler OnInsertItem;
        
        public int Add(Hadeeth item) {
            return List.Add(item);
        }

        public int Add(string Hadeeth, string Sand) {
            return List.Add(new Hadeeth(Hadeeth, Sand));
        }

        public int Add(string Hadeeth, string Sand, string Book, string Chapter, string Topic) {
            return List.Add(new Hadeeth(Hadeeth, Sand, Book, Chapter, Topic));
        }

        public void Insert(int index, Hadeeth item) {
            List.Insert(index, item);
        }
        public void Remove(Hadeeth item) {
            List.Remove(item);
        }
        public bool Contains(Hadeeth item) {
            return List.Contains(item);
        }
        public int IndexOf(Hadeeth item) {
            return List.IndexOf(item);
        }
        public void CopyTo(Hadeeth[] array, int index) {
            List.CopyTo(array, index);
        }

        protected override void OnInsertComplete(int index, object value) {
            if (OnInsertItem != null) OnInsertItem(this, new EventArgs());
            base.OnInsertComplete(index, value);
        }


        public Hadeeth this[int index] {
            get { return (Hadeeth)List[index]; }
            set { List[index] = value; }
        }

    }
    
    class HadeethViewer : Control{

        HadeethCollection fHadeethCollection;
        StringFormat FormatRL;
        Rectangle ContentArea;
        Rectangle[] sRects;
        Bitmap[] bBorders;
        TextureBrush[] tbrushBorders;
        VScrollBar fvBar;
        bool fShowSource;

        public HadeethViewer() {

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.Selectable, true);            
            SetStyle(ControlStyles.ResizeRedraw, true);            

            fHadeethCollection = new HadeethCollection();
            fHadeethCollection.OnInsertItem += new EventHandler(fHadeethCollection_OnInsertItem);
            FormatRL = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            ContentArea = new Rectangle();
            fShowSource = false;

            fvBar = new VScrollBar();
            Controls.Add(fvBar);
            fvBar.ValueChanged += new EventHandler(fvBar_ValueChanged);

            /* Initialize Border */
            Stream streamBorder = Assembly.GetExecutingAssembly().GetManifestResourceStream("eQuran.Resources.border.xml");
            Bitmap bBorder = eQuran.Properties.Resources.border;
            XmlTextReader fdata = new XmlTextReader(streamBorder);
            PixelFormat p = bBorder.PixelFormat;
            sRects = new Rectangle[8];
            bBorders = new Bitmap[8];
            tbrushBorders = new TextureBrush[4];

            int i = 0;
            fdata.ReadToFollowing("HadeethBorder");
            do {
                if (fdata.Name == "part") {
                    sRects[i].X = int.Parse(fdata.GetAttribute(0));
                    sRects[i].Y = int.Parse(fdata.GetAttribute(1));
                    sRects[i].Width = int.Parse(fdata.GetAttribute(2));
                    sRects[i].Height = int.Parse(fdata.GetAttribute(3));
                    bBorders[i] = bBorder.Clone(sRects[i], p);
                    i++;
                    fdata.Read();
                }
                fdata.Read();
            } while (i < 8);
            
            tbrushBorders[0] = new TextureBrush(bBorders[1]);
            tbrushBorders[1] = new TextureBrush(bBorders[5]);
            tbrushBorders[2] = new TextureBrush(bBorders[7]);
            tbrushBorders[3] = new TextureBrush(bBorders[3]);

            fdata.Close(); streamBorder.Close();
            bBorder.Dispose(); 

        }

        public HadeethCollection Entries {            
            get {
                return fHadeethCollection;
            }        
        }

        public bool ShowSource { 
            get {
                return fShowSource;
            }
            set {
                fShowSource = value;
                Invalidate();
            }
        }


        protected override void OnPaint(PaintEventArgs e) {

            Graphics g = e.Graphics;
            Rectangle DrawArea ;
            int textHeight, textWidth, allHeight;
            SizeF textSize;
            string text;
            Brush brushSand = new SolidBrush(Color.FromArgb(252, 77, 34));
            /* Draw border around control */
            DrawBorder(g);
            ControlPaint.DrawBorder3D(g, ClientRectangle);
            
            DrawArea = new Rectangle(ContentArea.Location, ContentArea.Size);
            g.SetClip(DrawArea);

            DrawArea.Offset(0, -fvBar.Value * Font.Height);
            allHeight = 0;

            foreach (Hadeeth rHadeeth in fHadeethCollection) {

                if (fShowSource) {
                    if ((rHadeeth.Book != "") && (rHadeeth.Chapter != "")
                                              && (rHadeeth.Topic != "")) {                        
                        text = string.Format("{0} :: {1} :: {2}" , 
                                        rHadeeth.Book,
                                        rHadeeth.Chapter, 
                                        rHadeeth.Topic);
                        textSize = g.MeasureString(text, Font, DrawArea.Size, FormatRL);
                        g.FillRectangle(brushSand, DrawArea.Right - textSize.Width, DrawArea.Top,
                                                   textSize.Width, textSize.Height);
                        g.DrawString(text, Font, Brushes.White, DrawArea, FormatRL);
                        DrawArea.Offset(0, (int)textSize.Height);
                        allHeight += (int)textSize.Height;

                    }
                
                }

                
                textHeight = (int)g.MeasureString(rHadeeth.Sand + ':' , Font, DrawArea.Size, FormatRL).Height;
                g.DrawString(rHadeeth.Sand + ':', Font, brushSand, DrawArea, FormatRL);
                DrawArea.Offset(0, textHeight) ;
                allHeight += textHeight;

                textHeight = (int)g.MeasureString(rHadeeth.HadeethContent, Font, DrawArea.Size, FormatRL).Height;
                g.DrawString(rHadeeth.HadeethContent, Font, Brushes.Black, DrawArea, FormatRL);                
                DrawArea.Offset(0, textHeight + Font.Height);
                allHeight += textHeight + Font.Height;

            }

            if (ContentArea.Height >= allHeight) {
                fvBar.Maximum = 0;
                fvBar.Hide();
            }
            else {
                fvBar.Maximum = allHeight / Font.Height;
                fvBar.Show();
            }
            //Debug.WriteLine(fvBar.Maximum);

            base.OnPaint(e);
        }

                
        protected override void OnSizeChanged(EventArgs e) {
            
            ContentArea.X = bBorders[7].Width + 30;
            ContentArea.Y = bBorders[1].Height + 20;
            ContentArea.Width = ClientRectangle.Width - (bBorders[7].Width * 2) - 40;
            ContentArea.Height = ClientRectangle.Height - (bBorders[1].Width * 2) ;

            fvBar.SetBounds(ContentArea.Left - fvBar.Width, ContentArea.Top, 
                            fvBar.Width , ContentArea.Height);

            base.OnResize(e);
        }

        protected override void OnMouseUp(MouseEventArgs e) {
            if (fvBar.Visible) fvBar.Focus(); else Focus();

            base.OnMouseUp(e);
        }

        private void fHadeethCollection_OnInsertItem(object sender, EventArgs e) {
            
            Invalidate(ContentArea);

        }
        
        private void fvBar_ValueChanged(object sender, EventArgs e) {
            
            Invalidate(ContentArea);

        }
        
        private void DrawBorder(Graphics g) {

            g.DrawImage(bBorders[0], 0,0,sRects[0].Width,sRects[0].Height);
            g.DrawImage(bBorders[2], ClientRectangle.Width - sRects[2].Width, 0, sRects[2].Width, sRects[2].Height);
            g.DrawImage(bBorders[4], ClientRectangle.Width - sRects[4].Width, ClientRectangle.Height - sRects[4].Height, sRects[4].Width, sRects[4].Height);
            g.DrawImage(bBorders[6], 0, ClientRectangle.Height - sRects[6].Height, sRects[6].Width, sRects[6].Height);

            tbrushBorders[3] = new TextureBrush(bBorders[3]);
            tbrushBorders[3].TranslateTransform(ClientRectangle.Width - sRects[3].Width, 0);

            tbrushBorders[1] = new TextureBrush(bBorders[5]);
            tbrushBorders[1].TranslateTransform(0, ClientRectangle.Height - sRects[5].Height);

            g.FillRectangle(tbrushBorders[0], sRects[0].Width, 0, Width - (sRects[0].Width * 2), sRects[1].Height);
            g.FillRectangle(tbrushBorders[3], ClientRectangle.Width - sRects[3].Width, sRects[2].Height, sRects[3].Width, Height - (sRects[2].Width * 2));
            g.FillRectangle(tbrushBorders[1], sRects[6].Width, ClientRectangle.Height - sRects[5].Height, ClientRectangle.Width - (sRects[5].Width * 2), sRects[6].Height);
            g.FillRectangle(tbrushBorders[2], 0, sRects[0].Height, sRects[7].Width, Height - (sRects[0].Height * 2));



        }



    }

}
