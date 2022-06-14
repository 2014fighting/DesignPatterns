// See https://www.runoob.com/design-pattern/builder-pattern.html for more information

// 一些基本部件不会变，而其组合经常变化的时候,本例中 不同汽车品牌其内部发动机，变速箱或者轮胎都可以更换成其它
// 汽车商店是不需要关系内部建造实现的，内部构建变更不会影响商店采购
using Builder;

Console.WriteLine("Hello, 建造者模式!");
CarShop carShop = new CarShop();
BydBulider bydBulider = new BydBulider();
GreatWallBulider greatWallBulider = new GreatWallBulider();

 
Car byd = carShop.Construct(bydBulider);
byd.ShowSteps();

Car gw = carShop.Construct(greatWallBulider);
gw.ShowSteps();

Console.ReadLine();