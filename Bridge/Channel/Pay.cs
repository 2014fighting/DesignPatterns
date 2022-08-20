using Bridge.Mode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Channel
{
    /// <summary>
    /// 桥接处理
    /// </summary>
    public abstract class Pay
    {
        protected IPayModel payModel;

        public Pay(IPayModel payModel)
        {
            this.payModel = payModel;
        }
        public abstract string Transfer(string uid, string tradeId, decimal amount);
    }
}
