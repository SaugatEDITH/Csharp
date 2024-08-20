using System;
class program{
    static void Main(string[] args){
var num=0;
  string text=Console.ReadLine();
  int.TryParse(text,out num);
  System.Console.WriteLine(num);
    }
}