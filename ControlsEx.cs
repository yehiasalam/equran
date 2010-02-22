using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.IO;

namespace eQuran {

    public class PanelBase : Panel {

        protected ColorPainter fColorPainter;
        private bool fUseHeaderColor = false;

        public PanelBase() {
        }

        protected virtual void OnColorPainterChanged(object Sender) {
            doPaintPanel();
        }



        public bool UseHeaderColor {
            get { return fUseHeaderColor; }
            set {
                fUseHeaderColor = value;
                doPaintPanel();

            }
        }


        public ColorPainter ColorPainter {
            get { return fColorPainter; }
            set {
                if (value is ColorPainter) {
                    fColorPainter = value;
                    doPaintPanel();
                    fColorPainter.ColorChanged += new ColorPainter.ColorsChangedEventHandler(OnColorPainterChanged);
                }
                else fColorPainter = null;
            }
        }

        protected virtual void doPaintPanel() {
            BackColor = fUseHeaderColor ? fColorPainter.HeaderColor : fColorPainter.BarColor;
        }

    }

    public class PanelEx : PanelBase {


        int frectover = -1, arrtopmargin;
        int fmargin = 0;
        int aw = 3; int ah = 6;
        Rectangle[] rects = new Rectangle[3];
        public delegate void MoveLeftEvent(object sender);
        public event MoveLeftEvent MoveLeft;
        public delegate void MoveRightEvent(object sender);
        public event MoveRightEvent MoveRight;
        public delegate void MoveDownEvent(object sender);
        public event MoveDownEvent MoveDown;

        public int SelectedIndex = 0;

        Icon fIcon = null;
        bool fIconVisibility = false;

        int fCaptionHeight;
        String fText, fSelectedText = "";
        Color fCaptionColor;
        StringFormat TextFormat;

        public override String Text {
            get {
                return fText;
            }
            set {
                fText = value;
                InvalidateCaption();
            }
        }

        public String SelectedText {
            get {
                return fSelectedText;
            }
            set {
                fSelectedText = value;
                fText = value;
                Invalidate(new Rectangle(0, 0, Width, fCaptionHeight));
            }

        }

        public Icon PanelIcon {
            get { return fIcon; }
            set {
                fIcon = value;
                InvalidateCaption();
            }
        }

        public bool IconVisible {
            get {
                return fIconVisibility;
            }
            set {
                fIconVisibility = value;
                InvalidateCaption();
            }
        }



        public PanelEx() {

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            DoubleBuffered = true;

            fCaptionColor = Color.Black;
            fCaptionHeight = Font.Height + 4;
            arrtopmargin = (fCaptionHeight - ah) / 2;
            TextFormat = new StringFormat();
            TextFormat.FormatFlags = StringFormatFlags.NoWrap;
            TextFormat.LineAlignment = StringAlignment.Center;
            TextFormat.Alignment = StringAlignment.Near;
            TextFormat.Trimming = StringTrimming.EllipsisCharacter;
        }


        private void InvalidateCaption() {
            Invalidate(new Rectangle(0, 0, Width, fCaptionHeight));
        }


        protected override void OnFontChanged(EventArgs e) {
            fCaptionHeight = Font.Height + 4;
            arrtopmargin = (fCaptionHeight - ah) / 2;
            InvalidateCaption();
            base.OnFontChanged(e);
        }

        protected override void OnPaint(PaintEventArgs e) {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            g.DrawRectangle(new Pen(Color.FromKnownColor(KnownColor.InactiveBorder)), 0, 0, Width - 1, Height - 1);
            g.FillRectangle(new SolidBrush(fCaptionColor),
                            1, 1, Width - 2, fCaptionHeight);


            g.DrawString(fText, Font, new SolidBrush(ForeColor),
                new Rectangle(3, 1, fmargin - 2, fCaptionHeight), TextFormat);


            //draw the thrre arrows            
            if (frectover != -1) {
                g.DrawRectangle(new Pen(Color.FromKnownColor(KnownColor.ActiveCaption)),
                                rects[frectover].Left,
                                rects[frectover].Top,
                                rects[frectover].Width - 1,
                                rects[frectover].Height - 1);

                g.FillRectangle(new SolidBrush(Color.FromArgb(60, 255, 255, 255)),
                                rects[frectover].Left + 1,
                                rects[frectover].Top + 1,
                                rects[frectover].Width - 2,
                                rects[frectover].Height - 2);
            }

            GraphicsPath arr = new GraphicsPath(FillMode.Winding);
            int rleft = fmargin;


            arr.StartFigure();
            arr.AddLine(new Point(rleft, arrtopmargin + aw), new Point(rleft + aw, arrtopmargin + ah));
            arr.AddLine(new Point(rleft + aw, arrtopmargin + ah), new Point(rleft + aw, arrtopmargin));
            arr.AddLine(new Point(rleft + aw, arrtopmargin), new Point(rleft, arrtopmargin + aw));
            arr.CloseFigure();
            g.FillPath(new SolidBrush(ForeColor), arr);

            rleft = rleft + 15;
            arr.StartFigure();
            arr.AddLine(new Point(rleft, arrtopmargin), new Point(rleft + aw, arrtopmargin + aw));
            arr.AddLine(new Point(rleft + aw, arrtopmargin + aw), new Point(rleft, arrtopmargin + ah));
            arr.AddLine(new Point(rleft, arrtopmargin + ah), new Point(rleft, arrtopmargin));
            arr.CloseFigure();

            g.DrawLine(new Pen(ForeColor), new Point(rleft + 12, arrtopmargin - 2), new Point(rleft + 12, arrtopmargin + ah + 2));

            rleft = rleft + 20;
            arr.StartFigure();
            arr.AddLine(new Point(rleft, arrtopmargin + aw), new Point(rleft + ah, arrtopmargin + aw));
            arr.AddLine(new Point(rleft + ah, arrtopmargin + aw), new Point(rleft + (ah / 2), arrtopmargin + (aw * 2)));
            arr.AddLine(new Point(rleft + (ah / 2), arrtopmargin + (aw * 2)), new Point(rleft, arrtopmargin + aw));
            arr.CloseFigure();

            //Arrows are filled with the same coloe as the CaptionText color
            g.DrawPath(new Pen(ForeColor), arr);
            g.FillPath(new SolidBrush(ForeColor), arr);


            // draw the icon
            //if (fIconVisibility) {
            //    g.DrawIcon(fIcon, ((fBorderStyle != BorderStyleEx.None) ? fBorderWidth : 0) + ((fCaptionHeight / 2) - (fIcon.Height / 2)), ((fBorderStyle != BorderStyleEx.None) ? fBorderWidth : 0) + ((fCaptionHeight / 2) - (fIcon.Height / 2)));
            //}

            base.OnPaint(e);
        }



        protected override void OnMouseDown(MouseEventArgs e) {
            switch (frectover) {
                case 0: if (MoveLeft != null) MoveLeft(this);
                    break;
                case 1: if (MoveRight != null) MoveRight(this);
                    break;
                case 2: if (MoveDown != null) MoveDown(this);
                    break;
            }
            base.OnMouseDown(e);
        }


        protected override void OnMouseMove(MouseEventArgs e) {
            frectover = -1;
            for (int i = 0; i < rects.Length; i++) {
                if ((rects[i].Right > e.X) && (e.X > rects[i].Left)) {
                    if ((rects[i].Bottom > e.Y) && (e.Y > rects[i].Top)) {
                        frectover = i;
                        break;
                    }
                }
            }

            for (int j = 0; j < rects.Length; j++) Invalidate(rects[j]);
            base.OnMouseMove(e);
        }


        protected override void OnResize(EventArgs e) {
            fmargin = Width - 55;
            rects[0] = new Rectangle(fmargin - 5, arrtopmargin - 4, 16, 16);
            rects[1] = new Rectangle(fmargin - 5 + 15, arrtopmargin - 4, 16, 16);
            rects[2] = new Rectangle(fmargin - 5 + 36, arrtopmargin - 4, 16, 16);
            Invalidate(new Rectangle(0, 0, Width, fCaptionHeight));
            base.OnResize(e);
        }

        public override Rectangle DisplayRectangle {
            get {
                return new Rectangle(1,
                                     fCaptionHeight,
                                     Width - 2,
                                     Height - fCaptionHeight - 2);
            }
        }

        protected override void OnColorPainterChanged(object Sender) {
            doPaintPanel();
        }

        protected override void doPaintPanel() {
            fCaptionColor = fColorPainter.HeaderColor;
            ForeColor = fColorPainter.HeaderText;
            InvalidateCaption();
        }



    }
        
    public class TextBoxEx: TextBox {

        PictureBox fpicLoading;        
        bool fShowLoading = false;

        public TextBoxEx() {

            Assembly rAssembly = Assembly.GetExecutingAssembly();
            Stream rStream = rAssembly.GetManifestResourceStream("eQuran.Resources.loading.gif");

            fpicLoading = new PictureBox();
            fpicLoading.Image = new Bitmap(rStream);
            fpicLoading.SizeMode = PictureBoxSizeMode.AutoSize;
            fpicLoading.Parent = this;
            fpicLoading.Visible = false;

            Cursor = Cursors.Default;
            Multiline = true;
        }

        protected override void OnSizeChanged(EventArgs e) {
            
            fpicLoading.Left = (ClientRectangle.Width / 2) - (fpicLoading.Width / 2);
            fpicLoading.Top = (ClientRectangle.Height / 3) - (fpicLoading.Height / 2);
            
            base.OnSizeChanged(e);
        }

        /* Apparently, the OnPaint method in never called from classes derived from
           TextBox. I just clear the Text property for now to get the same effect*/
        protected override void OnPaint(PaintEventArgs e) {

            if (fShowLoading) {
                Graphics g = e.Graphics;
                g.FillRectangle(new SolidBrush(Color.White), ClientRectangle);
                Console.WriteLine("In TextBoxEx Paint");                
            }
            else {               
                base.OnPaint(e);
            }

        }
        
        public void ShowLoading() {
            fShowLoading = true;
            fpicLoading.Visible = true;
            Text = "";
            Invalidate();
        }

        public void HideLoading() {
            fShowLoading = false;
            fpicLoading.Visible = false;
            Invalidate();
        }



    }

    public class TreeViewEx : TreeView {

        Bitmap bExpand, bCollapse;

        public TreeViewEx() {

            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            

            bExpand = eQuran.Properties.Resources.tree_plus;
            bCollapse = eQuran.Properties.Resources.tree_minus;

            DrawMode = TreeViewDrawMode.OwnerDrawAll;


        }

        protected override void OnDrawNode(DrawTreeNodeEventArgs e) {

            Graphics g = e.Graphics;
            StringFormat FormatRL = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            Rectangle rectDraw = new Rectangle( e.Bounds.Left,
                                                e.Bounds.Top,
                                                e.Bounds.Width,
                                                e.Bounds.Height );
            Bitmap bExpandedState;
            Color colorText;

            g.FillRectangle(Brushes.White, rectDraw);
            rectDraw.Offset(20 * e.Node.Level, 0);

            /* Draw the expand and collapse images */
            if (e.Node.Nodes.Count > 0 ) {
                bExpandedState = e.Node.IsExpanded ? bCollapse : bExpand;
                if (Environment.OSVersion.Version.Major <= 5)                
                    g.DrawImage(bExpandedState,rectDraw.Left ,rectDraw.Top + 2, 
                                            bExpandedState.Width, bExpandedState.Height);
                else if (Environment.OSVersion.Version.Major >= 6)
                    g.DrawImage(bExpandedState, rectDraw.Right - bExpand.Width, rectDraw.Top + 2,
                                            bExpandedState.Width, bExpandedState.Height);

            }
            rectDraw.Offset(16, 0);
            
            /* Draw the text of the node */
            colorText = (e.State & TreeNodeStates.Selected) == 0 ?
                        Color.Black :
                        Color.FromArgb(252, 77, 34);
            //g.DrawString(e.Node.Text, Font, brushText, rectDraw, FormatRL);            
            TextRenderer.DrawText(g, e.Node.Text, Font, rectDraw, colorText, TextFormatFlags.RightToLeft);
            

            base.OnDrawNode(e);
        }


    }


}
