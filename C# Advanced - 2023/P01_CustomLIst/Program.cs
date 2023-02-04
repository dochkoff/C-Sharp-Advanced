using P01_CustomLIst;

CustomLIst customLIst = new();

customLIst.Add(1);
customLIst.Add(2);
customLIst.Add(3);

customLIst.RemoveAt(1);

customLIst.Insert(1, 2);

customLIst.Swap(0, 2);

Console.WriteLine(customLIst.Contains(2));

Console.WriteLine(customLIst.Count);