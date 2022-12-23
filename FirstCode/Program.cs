// See https://aka.ms/new-console-template for more information
using FirstCode;

Console.WriteLine("Hello, World!");
int v = 45;
Console.WriteLine(v);

//object
//instatiation 
Student std = new Student();
std.Name = "Venkat";
std.Age = 35;
std.Gender = "Male";
std.GetList();


string word = "hello";
//array
string[] words = { "hello", "church", "chalk", "yoga" };

Logic Logic= new Logic();
Logic.result();
Logic.result1();
Logic.result2();
Logic.result3();
Logic.result4(4,5,6);

Looping Looping= new Looping();
Looping.checking();
Looping.check();