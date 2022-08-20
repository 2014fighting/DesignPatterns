using Bridge.Mode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Channel
{
    public class WxPay : Pay
    {
        public WxPay(IPayModel payModel) : base(payModel)
        {

        }

        public override string Transfer(string uid, string tradeId, decimal amount)
        {
            Console.WriteLine("模拟微信支付渠道开支转移资金");
            var security = payModel.security(uid);

            if (security)
            {
                Console.WriteLine("支付成功。");
                return "0001";
            }
            Console.WriteLine("check失败，请重试..");
            return "0000";
        }
    }
}
