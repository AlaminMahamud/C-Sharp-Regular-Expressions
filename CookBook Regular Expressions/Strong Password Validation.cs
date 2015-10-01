//Strong Password Validation


//The following checks whether a password has at least six characters, and whether
it contains a digit, symbol, or punctuation mark:

string r = @"(?x)^(?=.* ( \d | \p{P} | \p{S} )).{6,}";

Console.WriteLine (Regex.IsMatch ("abc12", r)); // False
Console.WriteLine (Regex.IsMatch ("abcdef", r)); // False
Console.WriteLine (Regex.IsMatch ("ab88yz", r)); // True

