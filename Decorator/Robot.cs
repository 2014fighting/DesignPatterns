using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{ 
    public abstract class  Robot
    {
      public abstract void DoSomething();
    }


    /// <summary>
    /// 第一代机器人
    /// </summary>
    public class FirstRobot : Robot
    {
        public override void DoSomething()
        {
            Console.WriteLine("对话");
            Console.WriteLine("唱歌");
        }
    }

    /// <summary>
    /// 机器人装饰器 即可做原有的事情 也可以做新的东西
    /// 这就是实现了装饰器的本质  实现方式和类适配器 一样 但是侧重点不一样 一个是为了适配接口进行转换，
    /// 另一个是为了对功能或者接口的增强和扩展，可以说目的不一样
    /// </summary>
    public class RobotDecorator : Robot
    {
        private Robot robot;
        public RobotDecorator(Robot robot)
        {
            this.robot = robot;
        }
        public override void DoSomething()
        {
            robot.DoSomething();
        }
        public void DoMoreSomething()
        {
            robot.DoSomething();

            Console.WriteLine("跳舞");
        }
    }
}
