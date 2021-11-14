using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EST_window
{
    class CaptionArea
    {
        internal int xs, ys, width, height;
        public int x0, y0, x1, y1;

        public CaptionArea()
        {
            xs = 0;
            ys = 0;
            width = Screen.PrimaryScreen.Bounds.Width;
            height = Screen.PrimaryScreen.Bounds.Height;
        }

        public void setStartArea(int x, int y)
        {
            x0 = x;
            y0 = y;
        }
        
        public void setEndArea(int x, int y)
        {
            x1 = x;
            y1 = y;

            if(x0 < x1)
            {
                xs = x0;
                width = x1 - x0;
            }
            else
            {
                xs = x1;
                width = x0 - x1;
            }

            if (y0 < y1)
            {
                ys = y0;
                height = y1 - y0;
            }
            else
            {
                ys = y1;
                height = y0 - y1;
            }
        }
    }

}
