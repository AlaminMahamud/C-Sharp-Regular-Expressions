// Matching U.S. Social Security Number

string ssNum = @"\d{3}-\d{2}-\d{4}";
Console.WriteLine(Regex.IsMatch("123-45-6789", ssNum)); // True

string phone = @"(?x)
				 (\d{3}[-\s] | \(\d{3})\s?)
				  \d{3}[-\s]?
				  \d{4}				
				";
Console.WriteLine(Regex.IsMatch("123-456-789", phone));
Console.WriteLine(Regex.isMatch("(123) 456-789", phone));


string r = @"(?m)^\s*(?'name'\w+)\s*=\s*(?'value'.*)\s*(?=\r?$)";
string text =
@"id = 3
secure = true
timeout = 30";
foreach (Match m in Regex.Matches (text, r))
Console.WriteLine (m.Groups["name"] + " is " + m.Groups["value"]);
id is 3 secure is true timeout is 30