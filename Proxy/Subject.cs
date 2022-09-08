using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ProxyPattern
    { 
    
    }


    public interface ISubject
    {
        public void DoWork();
    }

    public class RealSubject : ISubject
    {
        public void DoWork()
        {

        }
    }

    public class RealSubjectProxy : ISubject
    {

        private readonly RealSubject _subject;

        public   RealSubjectProxy(RealSubject subject)
        {
            _subject = subject;
        }

        public void Connect()
        {
            Console.WriteLine("建立链接。");
        }

        public void Log()
        {
            Console.WriteLine("日志记录。");
        }

        public void DoWork()
        {
            Connect();
            _subject.DoWork();
            Log();
        }
    }


}
