// See https://aka.ms/new-console-template for more information

using HNSDotNetTraining.ConsoleApp;
using System.Data;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");

//AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Create();
//adoDotNetExample.Read();
//adoDotNetExample.Edit();
//adoDotNetExample.Update();
//adoDotNetExample.Delete();

DapperExample dapperExample = new DapperExample();
//dapperExample.Read();
//dapperExample.Create("hhh","hh","heiehiebg");
//dapperExample.Edit(6);
//dapperExample.Delete(6);

EFCoreExample ef = new EFCoreExample();
//ef.Create("Test","sss","Testing");
//ef.Read();
ef.Edit(7);
//ef.Update(7,"Update1","snhh","Updating...");













