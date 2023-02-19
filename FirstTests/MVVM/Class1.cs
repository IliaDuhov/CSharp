using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    class Class1 : Interface1
    {
        public void openWindow(Note n)
        {
            new Editor(n).Show();
        }
    }
}
