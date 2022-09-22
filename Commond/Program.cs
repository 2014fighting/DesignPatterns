// See https://aka.ms/new-console-template for more information
using Commond;

Console.WriteLine("Hello, World!");

//命令模式：将请求封装成对象，使发起请求和执行请求分开，两者之间通过命令进行沟通，
//优点：通过引入命令类 降低系统耦合，增加删除命令类方便，符合开闭原则
//缺点：使用命令模式可能会导致某些系统有过多的具体命令类。

//应用场景：遥控器操作

var cInvoke =new Commond.Invoke();


var receiver = new Receiver();
cInvoke.SetCommand(new ConcreteCommand1(receiver));
cInvoke.SetCommand(new ConcreteCommand2(receiver));