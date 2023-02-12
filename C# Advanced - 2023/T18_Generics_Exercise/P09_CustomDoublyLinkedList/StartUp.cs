using System.Security.Cryptography.X509Certificates;

namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            DoublyLinkedList<string> list = new();

            list.AddFirst("a");
            list.AddFirst("b");
            list.AddFirst("c");
            list.AddFirst("d");
            list.AddFirst("e");
            list.AddFirst("f");

            list.AddLast("z");

            Console.WriteLine(list.RemoveFirst());

            Console.WriteLine(list.RemoveLast());

            list.ForEach(x => Console.WriteLine($"Node: {x}"));

            string[] arr = list.ToArray();
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}