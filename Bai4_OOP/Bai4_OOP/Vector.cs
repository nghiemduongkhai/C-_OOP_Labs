using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_OOP
{
    public abstract class Vector
    {
        public abstract void showinfo();
        public abstract void sum(Vector other, Vector result);
        public abstract void orth(Vector other);
    }
}
