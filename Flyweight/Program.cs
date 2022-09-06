// See https://aka.ms/new-console-template for more information
using Flyweight;

Console.WriteLine("Hello, World!");
/*
//享元模式  顾名思义共享元素的模式
//比较出名的就是池技术
//优点：通过池技术 减少对象创建数量，节约系统资源，内外状态相互分离使对象可以在不同环境中被共享
//缺点：外部状态都需要客户端进行传入 ，复杂了系统的设计
*/

//构建主要组成元素
//1 .享元工厂 （包含池存储） //这里设计成单例
//2 .享元抽象以及享元实现类
//3 .客户端通过 享元工厂取资源



var bick1=BickFlyWeightFactory.GetInstance().GetBike();
bick1.Ride(userName:"张三");
//bick1.Back();  //没有归还 所以接下来 获取自行车实例不可以获取到相同的

var bick2 = BickFlyWeightFactory.GetInstance().GetBike();
bick2.Ride(userName: "李四");
bick2.Back();  //用完归还 接下来用户来取自行车 可以取到这部自行车 ，做到了共享

var bick3 = BickFlyWeightFactory.GetInstance().GetBike();
bick3.Ride(userName: "王五");
bick3.Back();