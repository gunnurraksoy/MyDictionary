using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> NameAge = new MyDictionary<string, int>();
            NameAge.Add("Günnur", 21);
            NameAge.Add("Esra", 20);
            NameAge.Add("Ufuk", 32);
            NameAge.Add("Mehmet", 25);


            Console.WriteLine(NameAge.Count);

            NameAge.ShowList();

            
        }
    }
}
