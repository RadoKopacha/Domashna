

namespace ListsCreate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a coler palet of random colors:");
            List<string> colorList = new List<string>();
            string input = Console.ReadLine();
             while (input != "Done")
             {
               colorList.Add(input);
               input = Console.ReadLine();
                
             }
            Console.WriteLine("What element do you wana delete from " + (colorList.Count- 1));
            int index = int.Parse(Console.ReadLine());
            colorList.RemoveAt(index);
            //for (int i = 0; i < colorList.Count; i++)
            //{
            //   Console.WriteLine(colorList[i]);
            //}
            foreach (string redblock in colorList)
            {
                Console.WriteLine(redblock);
            }
        }
    }
}
