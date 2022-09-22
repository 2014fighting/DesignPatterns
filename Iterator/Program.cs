// See https://aka.ms/new-console-template for more information
using IteratorPattern;

Console.WriteLine("Hello, World!");
//迭代器模式：提供一种方法顺序访问一个聚合对象中各个元素, 而又无须暴露该对象的内部表示。
//优点： 
//缺点： 

//构建主要组成元素
//1 .hasNext, next

//案例
//1.java中的 iterator  c# 中的 IEnumerator

var nameRepository = new NameRepository();
 
var iterator = nameRepository.GetIterator();

for (Iterator iter = nameRepository.GetIterator(); iter.HasNext();)
{
    string name = (String)iter.Next();
   Console.WriteLine("Name : " + name);
}