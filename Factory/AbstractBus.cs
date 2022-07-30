using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{

    /// <summary>
    /// 抽象公交车
    /// </summary>
    public abstract class AbstractBus
    {
        protected abstract void DoOperation();

        public void GetInfo()
        {
            Console.WriteLine(string.Format("I am {0}.", this.GetType().Name));
        }
    }

    public class ConcreateBusA : AbstractBus
    {

        protected override void DoOperation()
        {

            throw new System.NotImplementedException();
        }
    }

    public class ConcreateBusB : AbstractBus
    {
        protected override void DoOperation()
        {
            throw new System.NotImplementedException();
        }
    }

    public class ConcreateBusC : AbstractCar
    {
        protected override void DoOperation()
        {
            throw new System.NotImplementedException();
        }
    }
}
