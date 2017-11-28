using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace ImageProcessing
{
    class Processing
    {
        public Processing()
        {

        }
        public static bool ConvertToGray(Bitmap b)
        {
            for (int i = 0; i < b.Width; i++)
                for (int j = 0; j < b.Height; j++)
                {
                    Color cl = b.GetPixel(i, j);
                    int r1 = cl.R;
                    int g1 = cl.G;
                    int b1 = cl.B;
                    int gray = (byte)(.299 * r1 + .587 * g1 + .114 * b1);
                    r1 = gray;
                    g1 = gray;
                    b1 = gray;
                    b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            return true;
        }
        public static bool ConvertToNegative(Bitmap b)
        {
            for(int i=0;i<b.Width;i++)
                for(int j = 0; j < b.Height; j++)
                {
                    Color cl = b.GetPixel(i, j);
                    int a = cl.A;
                    int r1 = cl.R;
                    int g1 = cl.G;
                    int b1 = cl.B;
                    r1 = 255 - r1;
                    g1 = 255 - g1;
                    b1 = 255 - b1;
                    b.SetPixel(i, j, Color.FromArgb(a,r1, g1, b1));
                }
            return true;
        }
        public static bool Brightening(Bitmap b, int f)
        {
            for(int i=0;i<b.Width;i++)
                for(int j = 0; j < b.Height; j++)
                {
                    int tempR, tempG, tempB;
                    Color rgb = b.GetPixel(i, j);
                    int rl = rgb.R;
                    int gl = rgb.G;
                    int bl = rgb.B;
                    tempR = rl + f;
                    tempG = gl + f;
                    tempB = bl + f;
                    if (tempR < 0)
                        tempR = 0;
                    else if (tempR > 255)
                        tempR = 255;
                    if (tempG < 0)
                        tempG = 0;
                    else if (tempG > 255)
                        tempG = 255;
                    if (tempB < 0)
                        tempB = 0;
                    else if (tempB > 255)
                        tempB = 255;
                    b.SetPixel(i, j, Color.FromArgb(tempR,tempG,tempB));
                }
            return true;
        }
    }
}
