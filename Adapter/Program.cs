// See https://aka.ms/new-console-template for more information
using Adapter;

Console.WriteLine("Hello, World!");
//起初系统中使用的数据库访问
IDBHelper sqlserverDb = new SqlServerHelper();
//起初系统中使用的数据库访问
IDBHelper mysqlDb = new MySqlHelper();


//随着业务的发展需要引入  oracle  和  redis 并且使用第三方sdk，由于第三方sdk接口定义方式和系统不一致或者说和业界标准不一致
//这时候就需要通过适配器模式来实现接口适配

//类适配方式实现适配模式
IDBHelper oracleDb = new OracleHelperAdapter();

//使用对象适配实现适配器模式,基于面向对象基本设计原则：合成复用原则 ，该方式优于类适配方法
IRedisHelper redisHelp = new RedisHelper();
IDBHelper redisDb = new RedisHelperAdapter(redisHelp);