// See https://aka.ms/new-console-template for more information
using FirstCode;
using System.Diagnostics;
//switch case
//start: //label
//Console.WriteLine("please choose  1-5");

//int number = int.Parse(Console.ReadLine());

//switch (number)
//{
//    case 1:
//        Console.WriteLine("sorry lottery missed");
//        break;
//    case 2:
//        Console.WriteLine("try again next time");
//        break;
//   case 3:
//        Console.WriteLine("try again next time");
//        break;
//   case 4:
//        Console.WriteLine("congratulations you won the lottery");
//        break;
//  case 5:
//        Console.WriteLine("try your luck again");
//        break;
//        default: Console.WriteLine("figures not available");
//    goto start;
//}

//conditional looping
// foreach
// dowhile
//while
//for

//foreach

string[] words = { "chalk", "mouse", "ipad", "maker", "board", "charger", "headset" };
foreach(string word in words)
{
    Console.WriteLine(word);
}


//for(int v = 0; v < words.Length;)
//{
//    Console.WriteLine(words[v]);
//}

for(int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("------------");

int x = 0;
while(x < 10)
{
    Console.WriteLine(x);
    x++;
}

Looping str = new Looping();
str.checking();
str.result4(4,5,6);
str.result3();


    