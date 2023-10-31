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

Console.WriteLine("##Testing petri dish##");

int [] petri = new int[] {1,5,2,6,1,3,4,6};

int [] petriExpanded = ArrayAlgorithms.petriPropagation(petri);

Array.ForEach(petriExpanded, (petri)=> {
    Console.Write(petri.ToString() + " ");
});

Console.WriteLine(" ");
petriExpanded = new int[0];
ArrayAlgorithms.petriPropagation(petriExpanded);
petriExpanded = null;
ArrayAlgorithms.petriPropagation(petriExpanded);
Console.WriteLine("## Ended petri ##");

