Match m = Regex.Match("any colour you like", @"colou?r");

Console.WriteLine(m.Success); // True
Console.WriteLine(m.Index);   // 4
Console.WriteLine(m.Length);  // 6
Console.WriteLine(m.Value);   // colour
Console.WriteLine(m.ToString);// colour

