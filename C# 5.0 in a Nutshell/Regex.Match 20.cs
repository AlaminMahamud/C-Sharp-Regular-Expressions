// the following splits a camel-case string into separate words

foreach(string s in Regex.Split("oneTwoThree", @"(?=[A-Z])"}));
	Console.Write(s+ " "); // one Two Three