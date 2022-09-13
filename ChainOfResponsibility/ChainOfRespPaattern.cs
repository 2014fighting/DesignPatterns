using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ChainOfRespPattern
    {
        /// <summary>
        /// 请假方法
        /// </summary>
        public void Leave(int day)
        {
            var level1 = new Leader();
            var level2 = new Boss();

            level1.SetNextHandler(level2);

            level1.Process(day);
        }

    }

    /// <summary>
    /// 先抽象一个处理类
    /// </summary>
    public abstract class Handler
    {
        protected Handler? _nextHandler;
        public void SetNextHandler(Handler nextHandler)
        {
            this._nextHandler = nextHandler;
        }

        public abstract void Process(int info);
    }

    //实现处理类
    public class Leader : Handler
    {
        public override void Process(int info)
        {

            if (_nextHandler == null)
            {
                //logrecode
                return;
            }
            if (info > 0 && info < 11)
            {
                Console.WriteLine($"请假天数{info}天，经理 处理完成审批！");
            }
            else
                _nextHandler.Process(info);

        }
    }

    //实现处理类
    public class Boss : Handler
    {
        public override void Process(int info)
        {

            Console.WriteLine($"请假天数{info}天，老板 处理完成审批！");

        }
    }

}
