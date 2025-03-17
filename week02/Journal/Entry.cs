using System;


public class Entry 
{
   public DateTime _date = DateTime.Now;
   public string _promptText;
   public string  _entryText;

   public void Display()
   {
    Console.WriteLine($"{_date},");
   }
}