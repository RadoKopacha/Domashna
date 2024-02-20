namespace zad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vyvedi imenata: ");
            List<string> names = Console.ReadLine().Split(' ').ToList();
            names.Reverse();
            Console.WriteLine(string.Join("; ", names));
        }
    }
}