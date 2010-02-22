using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Drawing;

namespace eQuran {
    public class ColorPainter : Component{

        private Color fHeaderColor, fBarColor, fHeaderText,
                      fBackgroundColor;
        public delegate void ColorsChangedEventHandler(Object Sender);
        public event ColorsChangedEventHandler ColorChanged;

        public ColorPainter() {
            fHeaderColor = Color.Gray;
            fBarColor = Color.GhostWhite;
            fHeaderText = Color.Black;
            fBackgroundColor = Color.FromKnownColor(KnownColor.Control);

        }

        public Color HeaderColor {
            get { return fHeaderColor; }
            set { 
                fHeaderColor = value;
                if (ColorChanged != null) ColorChanged(this);            
            }
        }
        
        public Color BarColor {
            get { return fBarColor; }
            set { fBarColor = value;
                if (ColorChanged != null) ColorChanged(this);
            }
        }
        
        public Color HeaderText {
            get { return fHeaderText; }
            set { fHeaderText = value;
                  if (ColorChanged != null) ColorChanged(this);
            }
        }

    }
}
