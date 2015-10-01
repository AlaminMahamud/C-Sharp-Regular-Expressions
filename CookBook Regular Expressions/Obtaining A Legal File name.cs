//Obtaining a Legal File Name
string input = "My \"good\" <recipes>.txt";
char[] invalidChars = System.IO.Path.GetInvalidPathChars();
string invalidString = Regex.Escape (new string (invalidChars));
string valid = Regex.Replace (input, "[" + invalidString + "]", "");
Console.WriteLine (valid);
My good recipes.txt