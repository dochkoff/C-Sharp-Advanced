Dictionary<string, int> peaks = new()
{
    { "Vihren", 80 },
    { "Kutelo", 90 },
    { "Banski Suhodol", 100 },
    { "Polezhan", 60 },
    { "Kamenitza", 70 }
};

Queue<string> peaksNames = new(new List<string> { "Vihren", "Kutelo", "Banski Suhodol", "Polezhan", "Kamenitza" });

List<string> conqueredPeaks = new() { };

Stack<int> foodPortions = new(
    Console.ReadLine()
        .Split(", ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse));

Queue<int> staminaQuantities = new(
    Console.ReadLine()
        .Split(", ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse));

while (foodPortions.Any() && staminaQuantities.Any() && peaksNames.Any())
{
    int foodPortion = foodPortions.Pop();
    int staminaQuantity = staminaQuantities.Dequeue();
    int peakDifficulty = peaks[peaksNames.Peek()];

    if (foodPortion + staminaQuantity >= peakDifficulty)
    {
        conqueredPeaks.Add(peaksNames.Dequeue());
    }
}

if (peaksNames.Any())
{
    Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
}
else
{
    Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
}

if (conqueredPeaks.Any())
{
    Console.WriteLine("Conquered peaks:");

    foreach (string peak in conqueredPeaks)
    {
        Console.WriteLine(peak);
    }
}

//My solution -> Judge 87/100 (1 incorrect test)


//Peak peak1 = new Peak("Vihren", 80, false);
//Peak peak2 = new Peak("Kutelo", 90, false);
//Peak peak3 = new Peak("Banski Suhodol", 100, false);
//Peak peak4 = new Peak("Polezhan", 60, false);
//Peak peak5 = new Peak("Kamenitza", 70, false);

//List<Peak> peaks = new() { peak1, peak2, peak3, peak4, peak5 };

//Stack<int> food = new(Console.ReadLine()
//    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
//    .Select(int.Parse));

//Queue<int> stamina = new(Console.ReadLine()
//    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
//    .Select(int.Parse));


//while (peaks.Any(p => p.Conquered == false) && food.Any() && stamina.Any())
//{
//    int daylyFood = food.Pop();
//    int daylyStamina = stamina.Dequeue();

//    if (daylyFood + daylyStamina >= peaks.First(p => p.Conquered == false).Difficulty)
//    {
//        peaks.First(p => p.Conquered == false).Conquered = true;
//    }
//}

//if (peaks.Any(p => p.Conquered == false))
//{
//    Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
//}
//else
//{
//    Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
//}

//if (peaks.Any(p => p.Conquered == true))
//{
//    Console.WriteLine("Conquered peaks:");

//    foreach (var peak in peaks)
//    {
//        Console.WriteLine(peak.Name);
//    }
//}


//internal class Peak
//{
//    public Peak(string name, int difficulty, bool conquered)
//    {
//        Name = name;
//        Difficulty = difficulty;
//        Conquered = conquered;
//    }

//    public string Name { get; set; }
//    public int Difficulty { get; set; }
//    public bool Conquered { get; set; }
//}