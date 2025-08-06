using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    public class Complex_Number
    {
    private int Real { get; set; }
    private int Img { get; set; }

        public static Complex_Number operator +(Complex_Number left, Complex_Number right) {

            return new Complex_Number
            {

                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Img= (left?.Img ?? 0) + (right?.Img ?? 0)

            };
            }
        public static Complex_Number operator -(Complex_Number left, Complex_Number right)
        {

            return new Complex_Number
            {

                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Img = (left?.Img ?? 0) - (right?.Img ?? 0)

            };
        }








    }
}
