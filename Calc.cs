using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_5
{


    internal class Calc : ICalc
    {
        public double Result { get; set; }
        private Stack<double> LastResult { get; set; } = new Stack<double>();

        public event EventHandler<EventArgs> MyEvent;

            private void PrintEvent()
            {
                MyEvent?.Invoke(this, new EventArgs());
            }

            public void Div(double x)
            {
                Result /= x;
                PrintEvent();
                LastResult.Push(Result);
            }

            public void Mul(double x)
            {
                Result *= x;
                PrintEvent();
                LastResult.Push(Result);
            }

            public void Sub(double x)
            {
                Result -= x;
                PrintEvent();
                LastResult.Push(Result);
            }

            public void Sum(double x)
            {
                Result += x;
                PrintEvent();
                LastResult.Push(Result);
            }

            public void CancelLast()
            {
                if (LastResult.TryPop(out double res))
                {
                    Result = res;
                    Console.WriteLine("Canceled");
                    PrintEvent();
                }
                else
                {
                    Console.WriteLine("Невозможно отменить");
                }
            }    
    }

}
