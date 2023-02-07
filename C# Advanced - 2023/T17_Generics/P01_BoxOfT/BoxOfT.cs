using BoxOfT;

namespace BoxOfT
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Box<int> box = new();

            box.Add(1);
            box.Add(2);
            box.Add(3);

            Console.WriteLine(box.Remove());
        }
    }
}