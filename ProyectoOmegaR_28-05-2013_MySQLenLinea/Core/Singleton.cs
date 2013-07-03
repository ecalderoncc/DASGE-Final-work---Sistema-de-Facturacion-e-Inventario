using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public sealed class Singleton
    {
        private int counter = 0;
        private static volatile Singleton instance = null;
        private static readonly object padlock = new object();

        private Singleton() { }

        public static int IncrementCounter()
        {
            if (instance == null)
            {
                lock (padlock)
                {
                    if (instance == null)
                        instance = new Singleton();
                }
            }
            return instance.counter++;
        }
        public static int DescuentoSustentado(int t)
        {
            int tmp=t;
            if (t >= 1000)
            {
                t = (t * 5) / 100;
                tmp = tmp - t;
            }
            return tmp;
        }
        public static int CalcularIgv(int t)
        {
            int tmp=0;
            tmp = (t * 18) / 100; 
            return tmp;
        }
    }
}
