using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton2
    {
        private static Singleton2? _instance;
        private static readonly object Locker = new object();
        private Singleton2()//私有化构造函数，阻止外界利用new关键词来创建实例
        {}

        public static Singleton2 GetInstance()
        {
            if (_instance == null)//加个判断防止资源浪费
            {
                lock (Locker)
                {
                    //Double-Check Locking 双重检查锁定
                    if (_instance == null)
                    {
                        _instance = new Singleton2();
                    }
                }
            }

            return _instance;
        }
    }
}
