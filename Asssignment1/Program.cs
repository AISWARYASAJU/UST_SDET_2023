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

//using Asssignment1;

//Console.WriteLine("enter the policy ID:");
//int PolicyId = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter the Policy Name:");
//string? PolicyName = Console.ReadLine();
//Console.WriteLine(" Enter the premmium amount:");
//double PremiumAmount = Convert.ToInt64(Console.ReadLine());
//Console.WriteLine("enter the age:");
//int age = Convert.ToInt32(Console.ReadLine());
//LifeInsurance life = new LifeInsurance(PolicyId, PolicyName, PremiumAmount, age);
//Console.WriteLine(life.CalculatePremium());
//Console.WriteLine("enter the policy ID:");
//int Policy1Id = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter the Policy Name:");
//string? PolicyName1 = Console.ReadLine();
//Console.WriteLine(" Enter the premmium amount:");
//double PremiumAmount1 = Convert.ToInt64(Console.ReadLine());
//Console.WriteLine("enter the Car Type:");
//string? cartype = Console.ReadLine();
//CarInsurance car = new CarInsurance(PolicyId, PolicyName1, PremiumAmount1, cartype);
//Console.WriteLine(car.CalculatePremium()); 

/*using Asssignment1;

Custumer customer= new Custumer();

Console.WriteLine("enter ph num");
long phoneNumber= Convert.ToInt64(Console.ReadLine());
customer.custumerDetails(phoneNumber);
customer.custumerAllDetails(); */

/*using Asssignment1;

CallRecord record = new CallRecord();
Console.WriteLine("Enter the phone number");
long number = Convert.ToInt64(Console.ReadLine());
CallRecord.CallHistory(number);  */

//using Asssignment1.MyException;
//using Asssignment1;

//Patient patient = new Patient();
//Console.Write("Enter the patient Id:");
//int id = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter the Name:");
//string name = Console.ReadLine();
//Console.Write("Enter the Age:");
//int age = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter the Diagnosis:");
//string diagnosis = Console.ReadLine();
//try
//{
//    patient.AddPatient(id, name, age, diagnosis);

//}
//catch (MyExceptions ex)
//{
//    Console.WriteLine(ex.Message);
//}

//using Asssignment1.MyException;
//using Asssignment1;

//Patient patient = new Patient();
//Console.Write("Enter the patient Id:");
//int id = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter the Name:");
//string name = Console.ReadLine();
//Console.Write("Enter the Age:");
//int age = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter the Diagnosis:");
//string diagnosis = Console.ReadLine();
//try
//{
//    patient.AddPatient(id, name, age, diagnosis);

//}
//catch (MyExceptions ex)
//{
//    Console.WriteLine(ex.Message);
//}


//using Asssignment1;

//MedicalHistory medicalHistory = new MedicalHistory();
//int option = 1;
//do
//{
//    Console.WriteLine("Enter  choice:");
//    Console.WriteLine("1.Add Record of patient\n2.View  Record of Patient\n3.Exit");
//    switch (Convert.ToInt32(Console.ReadLine()))
//    {
//        case 1:
//            Console.Write("Enter the record Id:");
//            int r_id = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Enter the patient Id:");
//            int p_id = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Enter the Description:");
//            string description = Console.ReadLine();
//            Console.Write("Enter the Date:");
//            string date = Console.ReadLine();
//            medicalHistory.AddMedicalHistory(r_id, p_id, description, date);
//            medicalHistory.AddToFile(r_id, p_id, description, date);
//            break;
//        default:
//            Console.WriteLine("Invalid choice");
//            break;
//    }
//    Console.WriteLine("Do you wish to continue?\n1.Yes\n2.No");
//    option = Convert.ToInt32(Console.ReadLine());
//} while (option != 2);

//using Asssignment1;

//HotelRoom hotel = new HotelRoom(600, "Double", true);
//RoomReservation<HotelRoom> room = new();

//room.BookRoom(hotel);
//Console.WriteLine("  Successfully Booked hotel Room");
//Console.WriteLine("Details are :");
//string? status;
//foreach (var item in RoomReservation<HotelRoom>.values)
//{
//    if (item.IsBooked)
//        status = "Engaged";
//    else
//        status = "Not Engaged";
//    Console.WriteLine("Room Number:{0} Room Type:{1} Status:{2} ", item.RoomNumber, item.RoomType, status);
//}
//Console.WriteLine("Enter  room No for canceling:");
//int num = Convert.ToInt32(Console.ReadLine());
//var roomNum = HotelRoom.GetRoom(num);
//if (roomNum != null)
//{
//    room.CancelRoom(roomNum);
//    Console.WriteLine("Room canceled");
//}
//else
//{
//    Console.WriteLine("Room doesn't exist");
//}


//using Asssignment1;

//Product1Info<string> product = new Product1Info<string>();
//int choice, option;
//do
//{
//    Console.WriteLine("Choose The option");
//    Console.WriteLine("1.Add Product\n2.Remove Product\n3.Update Product\n4.Get Product By Id\n5.Get Product By Name");
//    choice = Convert.ToInt32(Console.ReadLine());
//    switch (choice)
//    {
//        case 1:
//            Console.WriteLine("Enter The Product Id :");
//            int id = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter The Product Name :");
//            string? productname = Console.ReadLine();
//            Console.WriteLine("Enter The Price :");
//            double price = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("Enter the stock quantity");
//            int quantity = Convert.ToInt32(Console.ReadLine());
//            product.AddProduct(new Product1<string>(id, productname, price, quantity));
//            break;
//        case 2:
//            Console.WriteLine("Enter the product Id to Delete");
//            int productId = Convert.ToInt32(Console.ReadLine());
//            var item = product.GetProductById(productId);
//            if (item != null)
//            {
//                product.RemoveProduct(productId);
//                Console.WriteLine("Product Deleted Successfully!!!!");
//            }
//            else
//            {
//                Console.WriteLine("No Product Found!!!");
//            }
//            break;

//        case 3:
//            Console.WriteLine("Enter the product id for updation");
//            int productid = Convert.ToInt32(Console.ReadLine());
//            var prId = product.GetProductById(productid);
//            if (prId != null)
//            {
//                Console.WriteLine("Enter the Product Name :");
//                string? name = Console.ReadLine();
//                Console.WriteLine("Enter the price :");
//                double pric = Convert.ToDouble(Console.ReadLine());
//                Console.WriteLine("Enter the stock quantity :");
//                int qt = Convert.ToInt32(Console.ReadLine());
//                product.UpdateProduct(productid, name, pric, qt);
//                Console.WriteLine("Updated Successfully ");

//            }
//            else
//            {
//                Console.WriteLine("No Product Found!!!");
//            }

//            break;

//        case 4:
//            Console.WriteLine("View Product BY Id");
//            Console.WriteLine("Enter The Product Id");
//            int pid = Convert.ToInt32(Console.ReadLine());
//            Product1<string> pro = product.GetProductById(pid);
//            if (pro != null)
//            {
//                Console.WriteLine($"Product Id:{pro.ProductId}\nProduct Name:{pro.Name}" +
//                    $"\nPrice:{pro.Price}\nQuantity:{pro.StockQuantity}");
//            }
//            else
//            {
//                Console.WriteLine("No Product Found!!!");
//            }



//            break;
//        case 5:
//            Console.WriteLine("Search Product By Name");
//            string? proname = Console.ReadLine();
//            List<Product1<string>> data = product.GetProductByName(proname);
//            if (data != null)
//            {
//                foreach (Product1<string> p in data)
//                {
//                    Console.WriteLine($"Product Id:{p.ProductId}\nProduct Name:{p.Name}" +
//                    $"\nPrice:{p.Price}\nQuantity:{p.StockQuantity}");
//                }
//            }
//            else
//            {
//                Console.WriteLine("No Product Found!!!");
//            }
//            break;
//        case 6:
//            Environment.Exit(0);
//            break;
//        default:
//            Console.WriteLine("Invalid Option!!!!");
//            break;
//    }
//    Console.WriteLine("Do you want to continue \n1. Yes \n2.No");
//    option = Convert.ToInt32(Console.ReadLine());

//} while (option == 1);

//using Asssignment1;

//class Program
//{
//    public delegate string DelegateMessageOne(string msg);
//    public delegate string DelegateMessageTwo(string msg);
//    public static void Main(string[] args)
//    {
//        HotelEvent hotelEvent = new("Dj", "Trivandrum", "12.00:12-10-2023", 4);
//        DelegateMessageOne delegateMessageOne = HotelEvent.EventRegistration;
//        if (hotelEvent != null)
//        {
//            Console.WriteLine(delegateMessageOne($"Hai {hotelEvent.EventName} is Successfully Registered the event on {hotelEvent.EventDate}"));
//        }
//        else
//        {
//            Console.WriteLine(delegateMessageOne("Unsuccessfully registered"));
//        }
//        HotelEvent hotelEventone = new("Hallowing", "Kollam", "12.0013-10-2023", 6);

//        DelegateMessageTwo delegateMessageTwo = HotelEvent.EventRegistration;
//        if (hotelEventone != null)
//        {
//            Console.WriteLine(delegateMessageTwo($"Hai {hotelEventone.EventName} is Successfully Registered the event on {hotelEventone.EventDate}"));
//        }
//        else
//        {
//            Console.WriteLine(delegateMessageTwo("Unsuccessfully registered"));
//        }
//    }
//}


//using Asssignment1;

//TourismDestination tourism1 = new TourismDestination("Kottayam", "India", 4);
//TourismDestination tourism2 = new TourismDestination("Kannur", "India", 2);
//TourismDestination tourism3 = new TourismDestination("TVM", "India", 3);
//TourismDestination.tourismDestinations.Add(tourism1);
//TourismDestination.tourismDestinations.Add(tourism2);
//TourismDestination.tourismDestinations.Add(tourism3);
//TourismDestination.SortngDestination();

//using Asssignment1;

//TourismDestination tourism1 = new TourismDestination("Kottayam", "India", 4);
//TourismDestination tourism2 = new TourismDestination("Kannur", "India", 2);
//TourismDestination tourism3 = new TourismDestination("TVM", "India", 3);
//TourismDestination.tourismDestinations.Add(tourism1);
//TourismDestination.tourismDestinations.Add(tourism2);
//TourismDestination.tourismDestinations.Add(tourism3);
//TourismDestination.SortngDestination();

//using Asssignment1;

//Hotel hotel = new Hotel("zm", 4, "ars", "ll", 45);
//Hotel hotel1 = new Hotel("an", 6, "ars", "nn", 45);
//Hotel hotel2 = new Hotel("qq", 17, "qq", "mn", aa);


//await hotel.HotelBookingig(6, hotel);
//await hotel1.HotelBookingig(5, hotel1);
//await hotel2.HotelBookingig(5, hotel2);

//using Asssignment1;

//Hotel hotel = new Hotel("name", 4, "bsh", "jjjj", 45);
//Hotel hotel1 = new Hotel("lakk", 6, "qqq", "asw", 45);
//Hotel hotel2 = new Hotel("name6", 17, "ars", "nnnn", 45);

//await hotel.HotelBookingig(6, hotel);
//await hotel1.HotelBookingig(5, hotel1);
//await hotel2.HotelBookingig(5, hotel2);



//using Asssignment1;

//ToDo toDo = new ToDo(1, "JAVA", "Completed");
//ToDo toDo1 = new ToDo(2, "c#", "Pending");

//ToDo.toDoList.Add(toDo);
//ToDo.AddTodo(toDo);
//ToDo.AddTodo(toDo1);
//ToDo.updateList(2, "Completed");
//ToDo.Display("Completed");
//ToDo.Remove(1);

using Asssignment1;

FamilyMember grandparent = new FamilyMember("Grandparent", 70);
FamilyMember parent1 = new FamilyMember("Parent 1", 40);
FamilyMember parent2 = new FamilyMember("Parent 2", 38);
FamilyMember child1 = new FamilyMember("Child 2", 12);
FamilyMember child2 = new FamilyMember("Child 2", 8);

grandparent.AddChild(parent1);
grandparent.AddChild(parent2);
parent1.AddChild(child1);
parent2.AddChild(child2);

FamilyTree familyTree = new FamilyTree(grandparent);
familyTree.DisplayFamilyTree();













