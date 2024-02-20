namespace zad_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vyvedi imena: ");
            List<string> names = Console.ReadLine().Split(", ").ToList();

            foreach (var fullName in names)
            {
                string[] parts = fullName.Split(' ');
                string firstName = parts[1];
                string lastName = parts[0];

                Console.WriteLine($"{firstName} {lastName}");
            }
        }
    }
}