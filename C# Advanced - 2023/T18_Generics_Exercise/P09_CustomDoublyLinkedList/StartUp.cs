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

            list.RemoveFirst();

            list.RemoveLast();

            Action<string> action = new Action<string>(x => Console.WriteLine(x));
            list.ForEach(action);

            string[] arr = list.ToArray();
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}