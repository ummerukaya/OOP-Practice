using System;
using System.Collections.Generic;

class Car
{
    public string color = "red";
}

class Program 
{
    static public void Main(string[] args)
    {
        //creating dictionary using Dictionary<TKey,TValue> class
        Dictionary<int,string> d = new Dictionary<int,string>();

       //adding value
       d.Add(1, "A");
       d.Add(2, "B");
       d.Add(3, "C");

       foreach(KeyValuePair<int,string> i in d) {
           Console.WriteLine("{0} and {1}", i.Key, i.Value);
       }
       Console.WriteLine();
       d.Remove(2);

       foreach (KeyValuePair<int, string> i in d)
       {
           Console.WriteLine("{0} and {1}", i.Key, i.Value);
       }

       if (d.ContainsKey(2) == true)
           Console.WriteLine("Found the key");
       if (d.ContainsValue("A") == true)
           Console.WriteLine("Value exists");

   }


   
}

