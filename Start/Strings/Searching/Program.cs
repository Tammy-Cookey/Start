// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Example file for searching string content

string teststr = "The quick brown Fox jumps over the lazy Dog";

// TODO: Contains determines whether a string contains certain content
Console.WriteLine($"{teststr.Contains("fox")}"); // Outputs: True
Console.WriteLine($"{teststr.Contains("fox", StringComparison.CurrentCultureIgnoreCase)}"); // Outputs: True
// TODO: StartsWith and EndsWith determine if a string starts 
// or ends with a given test string
Console.WriteLine($"{teststr.StartsWith("the")}"); // Outputs: True
Console.WriteLine($"{teststr.StartsWith("the", StringComparison.CurrentCultureIgnoreCase)}"); // Outputs: True
Console.WriteLine($"{teststr.EndsWith("dog")}"); // Outputs: True
Console.WriteLine($"{teststr.EndsWith("dog", StringComparison.CurrentCultureIgnoreCase)}"); // Outputs: True
// TODO: IndexOf, LastIndexOf finds the index of a substring
Console.WriteLine($"{teststr.IndexOf("the")}"); // Outputs: 16
Console.WriteLine($"{teststr.IndexOf("the", StringComparison.CurrentCultureIgnoreCase)}"); // Outputs: 16
Console.WriteLine($"{teststr.LastIndexOf("the")}"); // Outputs: 43
// TODO: Determining empty, null, or whitespace
string str1 = null;
string str2 = "   ";
string str3 = String.Empty;
Console.WriteLine($"{String.IsNullOrEmpty(str1)}"); // Outputs: True
Console.WriteLine($"{String.IsNullOrEmpty(str3)}"); // Outputs: False
Console.WriteLine($"{String.IsNullOrWhiteSpace(str2)}"); // Outputs: True