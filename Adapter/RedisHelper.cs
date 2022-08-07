using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    /// 模拟 redis  第三方sdk 实现  和现有系统接口有所不同 ，需要适配器进行适配
    /// </summary>
    public class RedisHelper : IRedisHelper
    {
        public void AddCache<T>()
        {
            throw new NotImplementedException();
        }

        public void DeleteCache<T>()
        {
            throw new NotImplementedException();
        }

        public void ModifyCache<T>()
        {
            throw new NotImplementedException();
        }

        public void QueryCache<T>()
        {
            throw new NotImplementedException();
        }
    }

    public interface IRedisHelper
    {
        public void AddCache<T>();

        public void DeleteCache<T>();

        public void ModifyCache<T>();

        public void QueryCache<T>();
    }

}
