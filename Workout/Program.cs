// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Hai");
//Console.WriteLine("Enter 2 numbers");
//ADDITION
/*int n1, n2, n3;
n1= Convert.ToInt32(Console.ReadLine());
n2= Convert.ToInt32(Console.ReadLine());
n3 = n1 + n2;
Console.WriteLine(n3); */

string s1;
string s2;
string s3;
s1 = Console.ReadLine();
s2 = Console.ReadLine();
s3 = s1 + " " + s2;
Console.WriteLine(s3);
Console.WriteLine(s1.Equals(s2));
Console.WriteLine(s1.ToUpper());
Console.WriteLine(s1.ToLower());
Console.WriteLine(s2.Substring(3));
string[] s = s3.Split(' ');

for (int i = 0; i < s.Length; i++)

    Console.WriteLine(s[i]);
