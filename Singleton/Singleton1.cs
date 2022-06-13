using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton1
    {
        private static Singleton1? _instance;

        private Singleton1()//私有化构造函数，阻止外界利用new关键词来创建实例
        {}

        public static Singleton1 GetInstance()
        {
            return _instance??= new Singleton1();
        }
    }
}
