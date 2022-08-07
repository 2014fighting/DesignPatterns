using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{


    public interface IOracleDbHelper
    {
        public void Insert<T>();

        public void Delete<T>();

        public void Modify<T>();

        public void Query<T>();
    }
    /// <summary>
    /// 模拟 oracle  第三方的sdk 实现方式和现有系统的有所不同所以要使用适配器模式进行整合
    /// </summary>
    public class OracleHelper : IOracleDbHelper
    {
        public void Insert<T>()
        {

        }

        public void Delete<T>()
        {

        }

        public void Modify<T>()
        {

        }

        public void Query<T>()
        {

        }
    }


}
