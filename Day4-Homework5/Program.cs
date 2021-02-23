namespace Day4_Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            System.Console.WriteLine("--------------MyDictionary-------------");
            myDictionary.Add(1, "Nurbanu Kara");
            myDictionary.Add(2, "Belgin Kaya");
            myDictionary.Add(3, "Derya Malçok");
            myDictionary.ToList();
        }
    }
}
