// See https://aka.ms/new-console-template for more information
/*using Asssignment1;

Student obj = new Student(70,70,70);
obj.CalculateAverage(); */
/*using Asssignment1;

Product[] p1 = new Product[3];
p1[0] = new("TV", 25000, 1);
p1[1] = new("FRIDGE", 50000, 2);
p1[2] = new("AC", 10000000, 3);
foreach (var item in p1)
{
    Console.WriteLine("product name:" + item.ProductName);
    Console.WriteLine("product price:" + item.Price);
    Console.WriteLine("product quantity " + item.Quantity);
    Console.WriteLine("total price" + item.ProductValue());
} */
using Asssignment1;

Students[] students = new Students[]
{

 new("Aiswarya", new double[] {89,80,80}, 'A'),
 new("Aswin", new double[] {90,99,90}, 'B'),
 new("ammu", new double[] {70,79,70}, 'C'),



};
foreach (Students item in students)
{
    Console.WriteLine($"Student Name is :{item.Name}");
    Console.WriteLine($"Student Grade is: {item.Grade}");
    double[] marks = new double[3];
    double total = 0;
    Console.WriteLine("Marks of student is:\t");
    for (int i = 0; i < marks.Length; i++)
    {
        marks[i] = item.Marks[i];
        total = total + marks[i];
        Console.WriteLine(marks[i]);
    }
    Console.WriteLine($"Total Marks is:{total}");
    Console.WriteLine($"Average Marks is: {item.CalculateAverage()}");
    Console.WriteLine(item.GetMarksSummary());
}






