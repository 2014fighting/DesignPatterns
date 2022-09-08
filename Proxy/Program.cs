// See https://aka.ms/new-console-template for more information
using Proxy;

Console.WriteLine("Hello, World!");


//代理模式：本质就是 为其它对下个体统一种代理来控制对这个对象的访问
//关注点：通过代理去访问对象
//和装饰器很像  ，但是解决问题的侧重点不一样，代理更侧重访问，装饰器更侧重于功能的新增和扩展

new RealSubjectProxy(new RealSubject()).DoWork();