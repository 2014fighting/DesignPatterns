using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    /// 类适配方式实现适配模式
    /// 用继承的第三方oracle的dbhelper
    /// </summary>

    public class OracleHelperAdapter : OracleHelper, IDBHelper
    {
        public void Add<T>()
        {
            base.Insert<T>();
        }

        public void GetAll<T>()
        {
            base.Query<T>();
        }

        public void Update<T>()
        {
            base.Modify<T>();
        }
    }
}
