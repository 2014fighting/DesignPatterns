// See https://aka.ms/new-console-template for more information
using Decorator;

Console.WriteLine("Hello, World!");

//装饰器模式的简单实现 
new RobotDecorator(new FirstRobot()).DoMoreSomething();