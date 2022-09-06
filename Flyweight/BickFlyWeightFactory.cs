using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    /// <summary>
    /// 享元工厂
    /// </summary>
    public class BickFlyWeightFactory
    {
        private static BickFlyWeightFactory instance = new BickFlyWeightFactory();//饿汉单例模式

        //模拟共享池
        private List<MoBikeFlyWeight> pools = new List<MoBikeFlyWeight>();
        public static BickFlyWeightFactory GetInstance()
        {
            return instance;
        }
        /// <summary>
        /// 构造函数 默认初始化构造摩拜单车
        /// </summary>
        private BickFlyWeightFactory()
        {
            for (int i = 0; i < 3; i++)
            {
                pools.Add(new MoBikeFlyWeight(bikcId:i.ToString()));
            }
        }
         
        /// <summary>
        /// 获取自行车
        /// </summary>
        /// <returns></returns>
        public BikeFlyWeight GetBike()
        {
            foreach (var item in pools)
            {
                if (item.GetStatus() == 0)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
