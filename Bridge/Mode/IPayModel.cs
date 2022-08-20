using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Mode
{
    public interface IPayModel
    {
        bool security(string uid);
    }

 
    public class PayCypher : IPayModel
    {
        public bool security(string uid)
        {
            Console.WriteLine("密码支付");
            return true;
        }
    }

    public class PayFace : IPayModel
    {
        public bool security(string uid)
        {
            Console.WriteLine("人脸识别支付");
            return true;
        }
    }


    public class PayFingerprint : IPayModel
    {
        public bool security(string uid)
        {
            Console.WriteLine("指纹识别支付");
            return true;
        }
    }
}
