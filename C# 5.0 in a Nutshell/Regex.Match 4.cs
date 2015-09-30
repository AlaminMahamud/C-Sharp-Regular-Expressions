Regex r = new Regex(@"sausages?");
Console.WriteLine(r.Match("sausage"));  // sausage
Console.WriteLine(r.Match("sausages")); // sausages
