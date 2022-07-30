using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.AbstractFactory
{
    /// <summary>
    /// 宝马工厂
    /// </summary>
    public class BMWFactory : IAbstractFactory
    {
        public new AbstractCar CreateCar()
        {
            return new ConcreateCarA();
        }

        public new AbstractBus CreateBus()
        {
            return new ConcreateBusA();
        }  
        public new AbstractBus CreateSuv()
        {
            return new ConcreateBusA();
        }
    }
}
