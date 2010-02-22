using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace eQuran {
    public class MediaControls : Control {

        ColorPainter fColorPainter;
        
        public enum ButtonType { Play, Pause, Stop };
        ButtonType fButtonType = ButtonType.Play;
        GraphicsPath rglyph;        
        bool mouseIn = false;
        Rectangle CircleRect;

        public MediaControls() {
            rglyph = new GraphicsPath();
            drawGlyph();
            CircleRect = new Rectangle(2, 2, Width - 2, Height - 2);
        }

        public ButtonType ButtonGlyph {
            get { return fButtonType; }
            set {
                fButtonType = value;
                drawGlyph();
                Refresh();
            }
        }

        private void drawGlyph(){
            rglyph.Reset();
            switch (fButtonType){
		        case ButtonType.Play:
                    rglyph.StartFigure();
                    rglyph.AddLine(CircleRect.X + 5, CircleRect.X + 5, CircleRect.Width - 2, (CircleRect.Height / 2) +2);
                    rglyph.AddLine(CircleRect.Width - 2, (CircleRect.Height / 2)+2, CircleRect.X + 5, CircleRect.Height - 2);
                    rglyph.AddLine(CircleRect.X + 5, CircleRect.Height - 2, CircleRect.X + 5, CircleRect.X + 5);
                    rglyph.CloseFigure();
                    break;
                case ButtonType.Pause:
                    rglyph.StartFigure();
                    rglyph.AddRectangle(new Rectangle(CircleRect.X + 4, CircleRect.Y + 4, 3, CircleRect.Height - 8));
                    rglyph.AddRectangle(new Rectangle(CircleRect.X + 4 + 5, CircleRect.Y + 4, 3, CircleRect.Height - 8));
                    rglyph.CloseFigure();
                    break;
                case ButtonType.Stop:                    
                    rglyph.StartFigure();
                    rglyph.AddRectangle(new Rectangle(CircleRect.X + 4,CircleRect.Y+4,
                                                      CircleRect.Width -8,CircleRect.Height-8));
                    rglyph.CloseFigure();
                    break;
	        } 

        }
        
        protected override void OnPaint(PaintEventArgs e) {
            Graphics g = e.Graphics;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            
            g.FillPath(new SolidBrush(ForeColor), rglyph);
            if (mouseIn) {
                g.FillEllipse(new SolidBrush(ForeColor), CircleRect);
                g.FillPath(new SolidBrush(BackColor), rglyph);
            }
            base.OnPaint(e);            
        }

        protected override void OnMouseEnter(EventArgs e) {
            mouseIn = true;
            Refresh();
            base.OnMouseEnter(e);            
        }

        protected override void OnMouseLeave(EventArgs e) {        
            mouseIn = false;
            Refresh();
            base.OnMouseLeave(e);            

        }

        protected override void OnSizeChanged(EventArgs e) {
            CircleRect.Height = Height - 4;
            CircleRect.Width = Width - 4;
            drawGlyph(); 
            Refresh();
            base.OnSizeChanged(e);
        }

        protected override void OnResize(EventArgs e) {
            Width = Height;
            base.OnResize(e);
        }

        #region Color Painting
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

        protected virtual void OnColorPainterChanged(object Sender) {
            doPaintPanel();
        }

        protected virtual void doPaintPanel() {
            BackColor = fColorPainter.HeaderColor;
            ForeColor = fColorPainter.HeaderText;
        }
        #endregion

    }

    public class VolumeBar : Control {

        ColorPainter fColorPainter;

        public delegate void VolumeChangedEvent(Object Sender);
        public event VolumeChangedEvent VolumeChanged;

        Rectangle VolumeTextRect, CircleRect, BarRect;
        StringFormat VolumeTextFormat;
        Pen CircleStroke;
        SolidBrush BrushNormal, BrushCircle;
        int fPosition;
        bool captureMouse = false, inClientArea = false;

        const int CIRCLE_DIAMETER = 6;
        const int BAR_THICKNESS = 3;

        public VolumeBar() {
            DoubleBuffered = true;
            MinimumSize = new Size(60, 16);

            VolumeTextRect = new Rectangle();
            VolumeTextFormat = new StringFormat();
            VolumeTextFormat.Alignment = StringAlignment.Center;
            CircleStroke = new Pen(ForeColor, 1);
            BrushNormal = new SolidBrush(ForeColor); // used for painting the whole figure
            BrushCircle = new SolidBrush(BackColor);
            CircleRect = new Rectangle(18, 3, CIRCLE_DIAMETER, CIRCLE_DIAMETER);
            BarRect = new Rectangle(18, 0, Width - 32, Height); //covers the whole veritcal area, used when RePainting
        }

        public int Position {
            get {
                return fPosition;
            }
            set {
                fPosition = value;
                Invalidate();
            }
        }

        public Color CircleColor {
            get { return BrushCircle.Color; }
            set {
                BrushCircle.Color = value;
                Invalidate(CircleRect);
            }
        }

        protected override void OnSizeChanged(EventArgs e) {
            BarRect.Width = Width - 32;
            BarRect.Height = Height;
            VolumeTextRect.Width = 30;
            VolumeTextRect.Height = Font.Height;
            VolumeTextRect.X = (Width / 2) - 13;
            VolumeTextRect.Y = Height - VolumeTextRect.Height;

            base.OnSizeChanged(e);
        }

        protected override void OnMouseClick(MouseEventArgs e) {
            if ((e.X > 18) && (e.X < Width - 32)) {
                int barLength = Width - 32 - 18;
                fPosition = ((e.X - 18) * 100) / barLength;
                Invalidate(VolumeTextRect);
                Invalidate(BarRect);
                if (VolumeChanged != null) VolumeChanged(this);

            }
            base.OnMouseClick(e);
        }

        protected override void OnMouseDown(MouseEventArgs e) {
            captureMouse = true;
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e) {
            captureMouse = false;
            base.OnMouseUp(e);
        }

        protected override void OnMouseEnter(EventArgs e) {
            inClientArea = true;
            Invalidate(VolumeTextRect);
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e) {
            captureMouse = false;
            inClientArea = false;
            Invalidate(VolumeTextRect);
            base.OnMouseLeave(e);
        }

        protected override void OnMouseMove(MouseEventArgs e) {
            if (captureMouse) {

                if (e.X < 18) fPosition = 0;
                else if (e.X > (Width - 32)) fPosition = 100;
                else {
                    int barLength = Width - 32 - 18;
                    fPosition = ((e.X - 18) * 100) / barLength;
                }

                Invalidate(VolumeTextRect);
                Invalidate(BarRect);
                if (VolumeChanged != null) VolumeChanged(this);
            }

            base.OnMouseMove(e);
        }

        protected override void OnForeColorChanged(EventArgs e) {
            CircleStroke.Color = ForeColor;
            BrushNormal.Color = ForeColor;
            base.OnForeColorChanged(e);
        }

        protected override void OnBackColorChanged(EventArgs e) {
            BrushCircle.Color = BackColor;
            base.OnBackColorChanged(e);
        }

        protected override void OnPaint(PaintEventArgs e) {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            //soundIcon is 16x16

            Rectangle rpie = new Rectangle(2, 0, 12, 12);
            Rectangle rrect = new Rectangle(0, 4, 4, 4);
            GraphicsPath soundPath = new GraphicsPath(FillMode.Winding);
            soundPath.AddPie(rpie, 90, 180);
            soundPath.AddRectangle(rrect);
            g.FillPath(BrushNormal, soundPath);
            Matrix mTransform = new Matrix(); mTransform.Translate(Width - 20, 0);
            soundPath.Transform(mTransform);
            g.FillPath(BrushNormal, soundPath);

            GraphicsPath trackPath = new GraphicsPath(FillMode.Winding);
            trackPath.AddPie(18, 5, BAR_THICKNESS + 1, BAR_THICKNESS, 90, 180);
            trackPath.AddRectangle(new Rectangle(20, 5, Width - 50, BAR_THICKNESS));
            trackPath.AddPie(Width - 32, 5, BAR_THICKNESS, BAR_THICKNESS, 270, 180);
            g.FillPath(BrushNormal, trackPath);

            /*  Draw Trackball ====*====  */
            int barLength = Width - 32 - 18;
            CircleRect.X = ((fPosition * barLength) / 100) + 18;
            g.FillEllipse(BrushCircle, CircleRect);
            g.DrawEllipse(CircleStroke, CircleRect);


            if (inClientArea) {
                g.FillRectangle(BrushNormal, VolumeTextRect);
                g.DrawString(fPosition.ToString(), Font, BrushCircle,
                             VolumeTextRect, VolumeTextFormat);
            }

            g.PixelOffsetMode = PixelOffsetMode.Default;
            g.DrawLine(CircleStroke, Width - 10, 4, Width - 10, 8);
            g.DrawLine(CircleStroke, Width - 8, 2, Width - 8, 10);

            base.OnPaint(e);
        }


        #region Color Painting
        public ColorPainter ColorPainter {
            get { return fColorPainter; }
            set {
                if (value is ColorPainter) {
                    fColorPainter = value;
                    ReflectPainter();
                    fColorPainter.ColorChanged += new ColorPainter.ColorsChangedEventHandler(OnColorPainterChanged);
                }
                else fColorPainter = null;
            }
        }

        protected virtual void OnColorPainterChanged(object Sender) {
            ReflectPainter();
        }

        protected virtual void ReflectPainter() {
            BackColor = fColorPainter.HeaderColor;
            ForeColor = fColorPainter.HeaderText;

        }
        #endregion
    }


}
