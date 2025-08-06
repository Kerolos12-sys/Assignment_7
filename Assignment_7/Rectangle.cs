using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    public class Rectangle
    {
        private int Width { get; set; }
        private int Height { get; set; }
        public Rectangle() { 
            Width = 0;
            Height = 0;
        
        }
        public Rectangle(int x,int y)
        {
            Width = x;
            Height = y;

        }
        public Rectangle(int x)
        {
            Width = x;
            Height = x;

        }

    }
}
