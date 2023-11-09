namespace Yost_LinkedList
{
    internal class Program
    {
        static bool Exit = false;
        static void Main(string[] args)
        {
            MyLinkedList myLL = new MyLinkedList();

            while (!Exit)
            {

                Console.WriteLine($"1. Add Item {Environment.NewLine}2. Remove Item {Environment.NewLine}3. Search For Item {Environment.NewLine}4. Print {Environment.NewLine}5. Exit");
                string result = Console.ReadLine();
                switch (result)
                {
                    case "1":
                        Console.WriteLine("What is the name you want to add?");
                        string nameToAdd = Console.ReadLine().Trim();
                        myLL.Add(nameToAdd);
                        break;
                    case "2":
                        Console.WriteLine("What is the name you want to remove?");
                        string nameToRemove = Console.ReadLine().Trim();
                        Console.WriteLine($"Removed {nameToRemove} = {myLL.Remove(nameToRemove)}");
                        break;
                    case "3":
                        Console.WriteLine("What is the name you want to find?");
                        string nameToFind = Console.ReadLine().Trim();
                        Console.WriteLine($"Contains {nameToFind} = {myLL.Contains(nameToFind)}");
                        break;
                    case "4":
                        Console.WriteLine(myLL.PrintAllNodes());
                        break;
                    case "5":
                        Exit = true;
                        break;
                }


            }
        }
    }
}