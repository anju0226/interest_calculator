using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculator
{
    class calculate
    {
            float p;
            float t;
            float r;

            public calculate(float x,float y,float z)
            {
                this.p = x;
                this.t = y;
                this.r = z;
            }


            public float cal()
            {
                return ((p * t * r) / 100);
            }

            
    }
}
