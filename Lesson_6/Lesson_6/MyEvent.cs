using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{  
    class MyEvent
    {
        public delegate double Handlers(double a, double x);

        public event Handlers HandlersEvent;

        public void OnHandlerEventSin()
        {
         
        }

        public void OnHandlerEventX_A()
        {

        }
    }
}
