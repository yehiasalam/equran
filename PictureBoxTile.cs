using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace eQuran {
    class PictureBoxTile : PictureBox {

        protected override void OnPaint(PaintEventArgs pe) {
            if (Image != null) {
                int len = (int)(Width / Image.Width) + 1;
                for (int i = 0; i < len; i++) {                    
                    pe.Graphics.DrawImage(Image, i * Image.Width, 0,Image.Width,Image.Height );
                }
            }
            //base.OnPaint(pe);
        }

    }
}
