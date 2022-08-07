using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{

    /// <summary>
    /// 使用对象适配实现适配器模式
    /// 也就是依赖组合，第三方的实现
    /// </summary>
    public class RedisHelperAdapter:IDBHelper
    {
        public IRedisHelper RedisHelper { get; set; }
        public RedisHelperAdapter(IRedisHelper redisHelper)
        {
            RedisHelper = redisHelper;
        }
        public void Add<T>()
        {
            RedisHelper.AddCache<T>();
        }

        public void Delete<T>()
        {
            RedisHelper.DeleteCache<T>();
        }

        public void GetAll<T>()
        {
            RedisHelper.QueryCache<T>();
        }

        public void Update<T>()
        {
            RedisHelper.ModifyCache<T>();
        }
    }
}
