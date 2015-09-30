Console.WriteLine(Regex.Match("a", "A", RegexOptions.IgnoreCase)); // a


Console.WriteLine(Regex.Match("a", "A", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant));

Console.WriteLine(Regex.Match("a", @"(?i)a(?-i)a")); // Aa

