// Match Evalutator Delegate

Console.WriteLine(Regex.Replace("5 is less than 10", @"\d+", m=> (int.Parse(m.Value) * 10).ToString()));