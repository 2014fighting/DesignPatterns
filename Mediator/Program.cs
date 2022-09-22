// See https://aka.ms/new-console-template for more information
using Mediator;

Console.WriteLine("Hello, World!");

//中介者模式：通过中介类来降低对象和类之间通信的复杂性
//优点：松耦合，代码易维护，符合迪米特（最小知道）原则
//缺点：中介类容易在后期不断庞大

//应用：如房屋中介  ，珍爱网对象介绍

var houseAgent = new HouseAgent();
houseAgent.ContactOwner(new House() { IdNumber = 1111, Condition = "300平大平层" }) ;
houseAgent.ContactOwner(new House() { IdNumber = 2222, Condition = "3房一厅" });
houseAgent.ContactOwner(new House() { IdNumber = 3333,  Condition = "精装新房" });

 

houseAgent.ContactUser(new User() { Name = "张三", PhoneNumber="123333" , Requirement= "精装新房" });
 
