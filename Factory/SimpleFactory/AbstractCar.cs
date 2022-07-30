using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.SimpleFactory
{

    /// <summary>
    /// 产品枚举
    /// </summary>
    public enum ProductEnum
    {
        ConcreateProductA,
        ConcreateProductB,
        ConcreateProductC,
    }
    /// <summary>
    /// 简单工厂模式的工厂类一般是使用静态方法，通过接收的参数的不同来返回不同的对象实例。
    /// 不修改代码的话，是无法扩展的。（如果增加新的产品，需要增加工厂的Swith分支）不符合【开放封闭原则】
    /// </summary>
    public static class AbstractCar
    {
        public static Factory.AbstractCar? Create(ProductEnum productType)
        {
            switch (productType)
            {
                case ProductEnum.ConcreateProductA:
                    return new ConcreateCarA();
                case ProductEnum.ConcreateProductB:
                    return new ConcreateCarB();
                case ProductEnum.ConcreateProductC:
                    return new ConcreateCarC();
                default:
                    return null;
            }
        }
    }
}
