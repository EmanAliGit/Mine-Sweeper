using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MineSweeper
{
    class Cell:Button
    {
        int Num;
       public bool IsOpen = false;
        public bool flag = false;
       public int ri, ci;
       public Cell(int r,int c,int H,int W)
        {
           this.ri = r;
           this.ci = c;
            this.Height = H;
            this.Width = W;
        }
        public void SetNum(int n)
        {
            Num = n;
        }
        public int getnum()
        {
            return Num;
        }
    }
}
