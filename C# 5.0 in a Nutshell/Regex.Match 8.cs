Console.WriteLine(Regex.Match("\\","\\\\"));

Console.WriteLine(Regex.IsMatch("\\", "\\\\"));

Console.WriteLine("hello world", @"hello world"); // True


Character Sets

Expression

[abcdef]
[^abcdef]
[a-f]
[^a-f]
\d
\D
[0-9]
[^0-9]
\w
\W
[a-zA-Z_0-9]
[^a-zA-Z_0-9]
\s
\S
[\n\r\t\f]
[^\n\r\t\f]
\p{}
\P
.
.
\n
\n