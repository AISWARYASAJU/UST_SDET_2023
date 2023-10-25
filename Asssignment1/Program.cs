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
/*using Asssignment1;

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
*/

/*using Asssignment1;

ElectronicsProduct o = new ElectronicsProduct("aaa",1.1,2.2,10) ; */

/*using Asssignment1;

ElectronicProduct EP = new ElectronicProduct("PEN", 10, 5, 2);
Console.WriteLine("***Electronics ProductDetails***\n");
EP.DisplayWarrantyPeriod();
Console.WriteLine($"Product Name:{EP.ProductName}\nPrice:{EP.Price}\nQuantity:{EP.Quantity}");
Console.WriteLine($"Product Value:{EP.ProductValue()}");

Console.WriteLine("\n\n");
Console.WriteLine("***Digital ProductDetails***\n");

DigitalElectronics DP = new DigitalElectronics("WASHINGMACHINE", 20000, 1, 2, "Full-option");
Console.WriteLine($"Product Name:{DP.ProductName}\nPrice:{DP.Price}\nQuantity:{DP.Quantity}");
Console.WriteLine(DP.ProductValue());
DP.DisplayWarrantyPeriod();
DP.DisplayFileformat();


Console.WriteLine("\n\n");



Console.WriteLine("***Clothing ProductDetails***\n");
ClothingProduct clothingProduct = new ClothingProduct("Shirt", "XL", 2000, 1);
Console.WriteLine($"Product Name:{clothingProduct.ProductName}\nPrice:{clothingProduct.Price}\nQuantity:{clothingProduct.Quantity}");
clothingProduct.DisplayClothingProductSize();
Console.WriteLine($"Total Value Of Product:{clothingProduct.ProductValue()}"); */


/*using Asssignment1;

Console.Write("enter employee id");
int id = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the first name:");
string firstName= Console.ReadLine();
Console.Write("Enter the last name");
string lastName= Console.ReadLine();
Console.WriteLine("enter the age");
int age= Convert.ToInt32(Console.ReadLine());

Employee employee = new Employee(firstName, lastName, age,id);
employee.DisplayInfo(age); */

/*using Asssignment1;

Rectangle rectangle = new Rectangle(100, 10);
rectangle.Draw();
rectangle.CalculateArea();
rectangle.CalculatePerimeter();

Circle circle = new Circle(1);
circle.Draw();
circle.CalculateArea();
circle.CalculatePerimeter(); */

/*using Asssignment1;

InsurancePolicy i= new InsurancePolicy("aiswarya", 10, 100000);
i.RenewPolicy();
i.RenewPolicy(10000000); */

using Asssignment1;

Console.WriteLine("enter the policy ID:");
int PolicyId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Policy Name:");
string? PolicyName = Console.ReadLine();
Console.WriteLine(" Enter the premmium amount:");
double PremiumAmount = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("enter the age:");
int age = Convert.ToInt32(Console.ReadLine());
LifeInsurance life = new LifeInsurance(PolicyId, PolicyName, PremiumAmount, age);
Console.WriteLine(life.CalculatePremium());
Console.WriteLine("enter the policy ID:");
int Policy1Id = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Policy Name:");
string? PolicyName1 = Console.ReadLine();
Console.WriteLine(" Enter the premmium amount:");
double PremiumAmount1 = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("enter the Car Type:");
string? cartype = Console.ReadLine();
CarInsurance car = new CarInsurance(PolicyId, PolicyName1, PremiumAmount1, cartype);
Console.WriteLine(car.CalculatePremium());














