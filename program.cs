namespace C_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input count");
            int count = Convert.ToInt32(Console.ReadLine());
            Book[] books = new Book[count];
            if(count<=0)
            Console.WriteLine("Input possible count");
            else

            {
                for (int i = 1; i < count; i++)
                {
                    Console.WriteLine($"Input count");
                    int no = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Input name");
                    string name = Console.ReadLine();

                    Console.WriteLine($"Input price");
                    float price = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine($"Input genre");
                    string genre = Console.ReadLine();

                    books[i] = new Book(no, name, price, count, genre);
                }
                for (int i = 1; i < count; i++)
                {
                    Console.WriteLine($"{books[i].Name} {books[i].Price}");
                }
            }
        }
    }
}