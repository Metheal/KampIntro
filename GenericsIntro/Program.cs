using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");

            Console.WriteLine("Hello World!");

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Ilk deger");
            myDictionary.Add(2, "Ikinci deger");
            myDictionary.Add(3, "Ucuncu deger");
        }
    }
}
