// See https://aka.ms/new-console-template for more information
using Decorator;

Console.WriteLine("Hello, World!");


/// <summary>
/// 机器人装饰器 即可做原有的事情 也可以做新的东西
/// 这就是实现了装饰器的本质  实现方式和类适配器 一样 但是侧重点不一样 一个是为了适配接口进行转换，
/// 另一个是为了对功能或者接口的增强和扩展，可以说目的不一样
/// </summary>

//装饰器模式的简单实现 
new RobotDecorator(new FirstRobot()).DoMoreSomething();