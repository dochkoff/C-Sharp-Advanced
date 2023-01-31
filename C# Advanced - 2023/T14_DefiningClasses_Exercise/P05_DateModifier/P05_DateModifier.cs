namespace DefiningClasses
{
    public class P05_DateModifier
    {
        public static void Main(string[] args)
        {
            string startData = Console.ReadLine();
            string endDate = Console.ReadLine();

            DateModifier.GetDaysBetweenToDates(startData, endDate);
        }
    }
}