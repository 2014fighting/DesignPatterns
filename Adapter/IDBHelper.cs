using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    /// 现有系统标准接口或者市场上标准接口
    /// </summary>
    public interface IDBHelper
    {
        public void Add<T>();

        public void Delete<T>();

        public void Update<T>();

        public void GetAll<T>();
    }

    /// <summary>
    /// 模拟 现有系统标准统一实现
    /// </summary>
    public class MySqlHelper : IDBHelper
    {
        public void Add<T>()
        {
            throw new NotImplementedException();
        }

        public void Delete<T>()
        {
            throw new NotImplementedException();
        }

        public void GetAll<T>()
        {
            throw new NotImplementedException();
        }

        public void Update<T>()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 模拟 现有系统标准统一实现
    /// </summary>
    public class SqlServerHelper : IDBHelper
    {
        public void Add<T>()
        {
            throw new NotImplementedException();
        }

        public void Delete<T>()
        {
            throw new NotImplementedException();
        }

        public void GetAll<T>()
        {
            throw new NotImplementedException();
        }

        public void Update<T>()
        {
            throw new NotImplementedException();
        }
    }
}
