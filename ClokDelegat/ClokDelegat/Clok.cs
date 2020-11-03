using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClokDelegat
{
    class Clok
    {
        int h;
        int m;
        public int H { get; set; }
        public int M { get; set; }
        public Clok(int h,int m)
        {
            this.H = h;
            this.M = m;
        }
        public void TornOf()
        {
            this.H = 0;
            this.M = 0;
            MyEventHendler args = new MyEventHendler();
            args.Massege = $"The alarm clock is torn off";
            TimeToWakeUp(args);
        }
        public void Tick()
        {
            this.M++;
            MyEventHendler args = new MyEventHendler();
            args.Massege = $"Its time to wake up! {this.H}/{this.M}";
            TimeToWakeUp(args);
        }
        protected virtual void TimeToWakeUp(MyEventHendler e)
        {
            EventHandler<MyEventHendler> handler = AlarmClock;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        public event EventHandler<MyEventHendler> AlarmClock;
    }

    class MyEventHendler : EventArgs
    {
        public string Massege { get; set; }
    }
}
