Console.WriteLine(Regee.Match("cv15.doc", @"cv\d*\.doc").Success);

Console.Write (Regex.Match ("cvjoint.doc", @"cv.*\.doc").Success);

Console.Write (Regex.Matches ("slow! yeah slooow!", "slo+w").Count);

Regex bp = new Regex (@"\d{2,3}/\d{2,3}");
Console.WriteLine (bp.Match ("It used to be 160/110")); // 160/110
Console.WriteLine (bp.Match ("Now it's only 115/75")); // 115/75