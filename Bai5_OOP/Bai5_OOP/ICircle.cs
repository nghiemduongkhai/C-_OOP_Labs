using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_OOP
{
    interface ICircle
    {
        float cal_area(ref float area);
        void showCircle();
        void relPosition(Object other, float d);
    }
}
