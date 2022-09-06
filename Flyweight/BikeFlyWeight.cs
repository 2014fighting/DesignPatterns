using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    /// <summary>
    /// 共享单车抽象类
    /// </summary>
    public abstract class BikeFlyWeight
    {
        protected int status=0;//0 :未使用  1：使用中

        /// <summary>
        /// 骑行
        /// </summary>
        /// <param name="userName"></param>
        public abstract void Ride(string userName);

        /// <summary>
        /// 归还
        /// </summary>
 
        public abstract void Back();

        public int GetStatus()
        {
            return status;
        }
    }


    /// <summary>
    /// 实例享元类
    /// </summary>
    public class MoBikeFlyWeight : BikeFlyWeight
    {
        private string _bickId;
        public MoBikeFlyWeight(string bikcId)
        {
            this._bickId = bikcId;
        }
        public override void Ride(string userName)
        {
            Console.WriteLine($"用户：{userName}骑{_bickId} 自行车出行");
            status = 1;
        }

        public override void Back()
        {
            status = 0;
        }
    }
}
