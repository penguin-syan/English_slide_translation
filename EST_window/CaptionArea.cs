using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EST_window
{
    class CaptionArea
    {
        internal int xs, ys, width, height;

        public CaptionArea()
        {
            xs = 0;
            ys = 0;
            width = 1920;
            height = 1080;
        }

        public void setStartArea(int x, int y)
        {
            xs = x;
            ys = y;
        }
        
        public void setEndArea(int x, int y)
        {
            width = x - xs;
            height = y - ys;
        }
    }

}
