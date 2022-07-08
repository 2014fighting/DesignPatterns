// See https://aka.ms/new-console-template for more information
using Prototype;
//属于创建型设计模式 优点内存中进行二进制流拷贝的对比直接new对象性能要好，特别是需要创建大量对象的时候，同时简化创建对象的过程
Console.WriteLine("Hello, 原型模式!");

var msg = new ShortMessage()
{
    Sender = "15659229992",
    Subject = "扣费短信通知",
    Content = "批量发送短信通知，请咨询903220",
};

for (int i = 0; i < 10000; i++)
{
    string receiver = string.Format("156592299{0}", i);
    string name = string.Format("dear customer『{0}』:", i);
    var cloneMsg = msg.Clone() as ShortMessage;
    if (cloneMsg == null) continue;

    cloneMsg.Receiver = receiver;
    cloneMsg.UserName = name;

    SendMessage(cloneMsg);
}


void SendMessage(ShortMessage msg)
{
    Console.WriteLine(string.Format("短信已发送：『{0}』", msg.Receiver));
}