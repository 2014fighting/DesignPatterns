using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.AbstractFactory
{
    /// <summary>
    /// 比亚迪工厂
    /// </summary>
    public class BYDFactory : IAbstractFactory
    {
        public new AbstractCar CreateCar()
        {
            return new ConcreateCarB();
        }

        public new AbstractBus CreateBus()
        {
            return new ConcreateBusB();
        }

        public new AbstractBus CreateSuv()
        {
            return new ConcreateBusB();
        }
    }
}
