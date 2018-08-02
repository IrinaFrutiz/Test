using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Circle : Figure 
    {
        private int rad;
        

        public Circle(int rad)
        {
            this.rad = rad;
        }
        public int Rad
        {
            get
            {
                return rad;
            }
            set
            {
                rad = value;
            }
        }
       
    }
}
