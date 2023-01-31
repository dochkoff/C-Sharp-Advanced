namespace DefiningClasses
{
    public static class DateModifier
    {
        public static void GetDaysBetweenToDates(string start, string end)
        {
            DateTime startDate = DateTime.Parse(start);
            DateTime endDate = DateTime.Parse(end);

            var difference = endDate - startDate;

            Console.WriteLine(Math.Abs(difference.Days));
        }
    }
}