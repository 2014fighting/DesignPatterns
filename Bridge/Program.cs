// See https://aka.ms/new-console-template for more information
using Bridge.Channel;
using Bridge.Mode;

//（桥接）本质将不同的抽象链接起来，使其各自实现能够独立变化（新增修改或移除）

// 适用场景
//1.一个类存在两个（或多个）独立变化的维度，且这两个（或多个）维度都需要独立进行扩展。
//2.对于那些不希望使用继承或因为多层继承导致系统类的个数急剧增加的系统，桥接模式尤为适用

Console.WriteLine("微信刷脸支付开始");
var wxPay = new WxPay(new PayFace());
wxPay.Transfer("wx_zf12121212", "1212121", 100);



Console.WriteLine("支付宝指纹支付开始");
var zfbPay = new ZfbPay(new PayFingerprint());
zfbPay.Transfer("wx_zf32323232", "2323232", 10000);