using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_OOP
{
    interface IPoint
    {        
        void cal_dist(Object other, ref float dist);
        void showinfo();
    }
}
