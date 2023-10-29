using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_5
{
    internal interface ICalc
    {
        double Result { get; set; }

        void Sum(double x);
        void Sub(double x);
        void Mul(double x);
        void Div(double x);

        event EventHandler<EventArgs> MyEvent;
        void CancelLast();
    }
}
