// See https://aka.ms/new-console-template for more information
using Composite;

//组合模式 定义：组合模式允许以相同的方式处理单个对象和对象的组合体

//适用场景
//1.当你的程序结构有类似树一样的层级关系时，例如文件系统，视图树，公司组织架构等等
//2.当你要以统一的方式操作单个对象和由这些对象组成的组合对象的时候。


var org =new CompositeClient().ConstructOrganization();

Console.WriteLine($"{org.GetName()}共有{org.GetStaffCount()}d名员工");
 

OrganizationComponent? subOrg = org.GetChild("天津分公司行政部");

if (subOrg != null)
{
    Console.WriteLine($"{subOrg.GetName()}共有{subOrg.GetStaffCount()}d名员工");
}
 
 