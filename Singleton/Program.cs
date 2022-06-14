// See https://www.runoob.com/design-pattern/singleton-pattern.html for more information


using Singleton;

TestStaticSingleton();
TestDoubleCheckSingleton();


 void TestStaticSingleton()
{
    Console.WriteLine("===============常规单例模式!====================");

    var s1 = Singleton1.GetInstance();
    var s2 = Singleton1.GetInstance();
    if (object.ReferenceEquals(s1, s2))
    {
        Console.WriteLine("两个对象是相同的！");
    }
}


void TestDoubleCheckSingleton()
{
    Console.WriteLine("===============多线程场景下单例模式!====================");

    for (int i = 0; i < 3; i++)
    {
        Task.Run(() => ThreadExecute());
    }
    Console.ReadLine();
}

 void ThreadExecute()
{
    Console.WriteLine($"ManagedThreadId {Thread.CurrentThread.ManagedThreadId}");

    var singleton2 = Singleton2.GetInstance();
  
    Console.WriteLine(singleton2.GetHashCode());
}
