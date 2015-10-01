Splitting a Camel Case Word

string r = @"(?=\r?$)";
foreach (string s in Regex.Split ("oneTwoThree", r))
Console.Write (s + " "); // one Two Three