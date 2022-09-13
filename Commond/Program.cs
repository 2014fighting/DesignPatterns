// See https://aka.ms/new-console-template for more information
using Commond;

Console.WriteLine("Hello, World!");

//命令模式：将请求封装成对象，使发起请求和执行请求分开，两者之间通过命令进行沟通，
//优点：通过引入命令类 降低系统耦合，增加删除命令类方便，符合开闭原则


var cInvoke=new Commond.Invoke();


var receiver = new Receiver();
cInvoke.SetCommand();