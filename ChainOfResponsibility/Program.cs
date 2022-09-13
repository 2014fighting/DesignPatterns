// See https://aka.ms/new-console-template for more information
using ChainOfResponsibility;

Console.WriteLine("Hello, World!");

//责任链模式  就是将处理事务抽象 然后分不同的类来处理，通过指定下一个处理者将这些实现类串成一条链
//优点是将请求和处理分开，请求者不需要知道谁去处理，其次可以提高处理灵活性，需要新增处理直接新增一个实现类即可
//缺点每个请求都需要从链头到链尾，比较长是性能下降

//请假三天
new ChainOfRespPattern().Leave(3);

//请假13天
new ChainOfRespPattern().Leave(13);