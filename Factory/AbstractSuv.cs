using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// 抽象SUV
    /// </summary>
    public abstract class AbstractSuv
    {
        protected abstract void DoOperation();

        public void GetInfo()
        {
            Console.WriteLine(string.Format("I am {0}.", this.GetType().Name));
        }
    }

    public class ConcreateSuvA : AbstractSuv
    {

        protected override void DoOperation()
        {

            throw new System.NotImplementedException();
        }
    }

    public class ConcreateSuvB : AbstractSuv
    {
        protected override void DoOperation()
        {
            throw new System.NotImplementedException();
        }
    }

    public class ConcreateSuvC : AbstractSuv
    {
        protected override void DoOperation()
        {
            throw new System.NotImplementedException();
        }
    }
}
