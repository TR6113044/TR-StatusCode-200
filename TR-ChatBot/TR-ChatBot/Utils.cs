using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace TR_ChatBot
{
   public static class Utils
    {
        public static int GetTextBoxTextHeight(TextBox txtInCht)
        {
            using(Graphics g = txtInCht.CreateGraphics())
            {
                SizeF size = g.MeasureString(txtInCht.Text, txtInCht.Font, 495);
                return (int)Math.Ceiling(size.Height);
            }
            
        }
    }
}
