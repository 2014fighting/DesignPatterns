using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.FactoryMethod
{
    public class ConcreateFactoryA : IFactoryMethod
    {
        public AbstractCar Create()
        {
            return new ConcreateCarA();
        }
    }
}
