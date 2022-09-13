using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commond
{

    //抽象命令
    public abstract class Command
    {
        public abstract void Execute();
    }


    /// <summary>
    /// 具体命令1
    /// </summary>
    public class ConcreteCommand1 : Command
    {
        private Receiver _receiver;
        public ConcreteCommand1(Receiver receiver)
        {
            this._receiver = receiver;
        }
        public override void Execute()
        {
            _receiver.Action1();
        }
    }

    /// <summary>
    /// 具体命令2
    /// </summary>
    public class ConcreteCommand2 : Command
    {
        private Receiver _receiver;
        public ConcreteCommand2(Receiver receiver)
        {
            this._receiver = receiver;
        }
        public override void Execute()
        {
            _receiver.Action2();
        }
    }


    public class Receiver
    {
       public void Action1()
        {
            Console.WriteLine("接收者Action1 方法被调用。。");
        }

        public void Action2()
        {
            Console.WriteLine("接收者Action2 方法被调用。。");
        }
    }

    public class Invoke 
    {
        private List<Command> commanList = new List<Command>();

        public void SetCommand(Command comman)
        {
            commanList.Add(comman);
        }

        public void ExecuteCommand()
        {
            foreach (var c in commanList)
            {
                c.Execute();
            }
            commanList.Clear();
        }

    }


}
