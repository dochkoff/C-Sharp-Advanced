namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            DoublyLinkedList list = new();

            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddFirst(4);
            list.AddFirst(5);
            list.AddFirst(6);

            list.AddLast(0);

            list.RemoveFirst();

            list.RemoveLast();

            Action<int> action = new Action<int>(x => Console.WriteLine(x));
            list.ForEach(action);

            int[] arr = list.ToArray();
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}