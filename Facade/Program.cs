// See https://aka.ms/new-console-template for more information
using Facade;

Console.WriteLine("Hello, World!");


//假设 需要证明自己的身份需要  分别取流程 1  ，2  ，3  个部门分别开具证明
//使用外观模式  只要跑一次就可以
//外观模式缺点 违反开闭原则
//优点 隐藏系统的复杂性 提供单一简便的调用


new FacadeProve().Prove();