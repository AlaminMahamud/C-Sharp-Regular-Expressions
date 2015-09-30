Match m1 = Regex.Match("One Color? There are two colours in my head", @"colou?rs?");
Match m2 = m1.NextMatch();
Console.WriteLine(m1); // color
Console.WriteLine(m2); // colours

foreach(Match m in Regex.Matches("One Color? There are two colours in my head", @"colou?rs?"))
	Console.WriteLine(m);

