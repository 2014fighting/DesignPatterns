// See https://aka.ms/new-console-template for more information
using Factory.AbstractFactory;
using Factory.FactoryMethod;
using Factory.SimpleFactory;

Console.WriteLine("Hello, 工厂模式!");


//简单工厂模式：简单实用，但违反开放封闭；
var car1 = SimpleFactory.Create(ProductEnum.ConcreateProductA);
if (car1 != null)
{
    car1.GetInfo();
}


//工厂方法模式：解决简单工厂违背开闭原则的问题，一个产品需要一个工厂类，类容易过多
IFactoryMethod factoryB = new ConcreateFactoryB();
var productB = factoryB.Create();
productB.GetInfo();



//抽象工厂模式：具体不是到产品，也就是可以实现不同工厂不同产品线的创建，符合开闭原则
var bmwFactory = new BMWFactory();
bmwFactory.CreateCar().GetInfo();
bmwFactory.CreateBus().GetInfo();
bmwFactory.CreateSuv().GetInfo();

var bydFactory = new BYDFactory();
bydFactory.CreateCar().GetInfo();
bydFactory.CreateBus().GetInfo();
bydFactory.CreateSuv().GetInfo();