using System.Runtime.InteropServices;
using Algorithms;

string input = "the sky is blue";

string result = StringAlgorithms.ReverseWords(input);

Console.WriteLine(result);

input = " the new era of doom ";
result = StringAlgorithms.ReverseWords(input);

Console.WriteLine(result);

input = " this   is    a funky string";
result = StringAlgorithms.ReverseWords(input);

Console.WriteLine(result);




