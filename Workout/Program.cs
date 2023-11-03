//Console.WriteLine("first:"+ "hai");
//Console.ReadLine();

//ADDING 2 NUM FROM CONSOLE
//int a, b, result;
//a= Convert.ToInt32(Console.ReadLine());
//b= Convert.ToInt32(Console.ReadLine());
//result = a + b;
//Console.WriteLine(result);



//ADDING 2 strings FROM CONSOLE
//string s1, s2, s3;
//s1= Console.ReadLine();
//s2= Console.ReadLine();
//s3= s1 +" " + s2;
//Console.WriteLine(s3);
//Console.WriteLine(s3.ToLower());
//Console.WriteLine(s3.ToUpper());
//Console.WriteLine(s3.Replace('A','0'));



//SWITCH STATEMENTS
//int a = 5;
//switch(a)
//{
//   case 0:
//        Console.WriteLine(1);
//        break;
//   case 1:
//        Console.WriteLine(2);
//        break;
//   case 2:
//        Console.WriteLine(3);
//        break;       
//   case 12:
//        Console.WriteLine(4);
//        break;
//   default:
//        Console.WriteLine("quit");
//        break;
//}



//ADD NUMBERS USING OOPS CONCEPT
//using Workout;
//CalculationW obj = new CalculationW();
//int p= Convert.ToInt32(Console.ReadLine());
//int q = Convert.ToInt32(Console.ReadLine());
//int ans=obj.DisplayAdd(p, q);
//Console.WriteLine(ans);



//OOPS CONCEPT AND CONSTRUCTOR AND CONSTRUCTOR EXAMPLE



//using Workout;

//ElectricityW electricity1 = new ElectricityW(12345, 9000, 9300, "AISHU");
//Console.WriteLine(electricity1.consumernumber);
//Console.WriteLine(electricity1.consumername);
//Console.WriteLine(electricity1.CalculateBill());

//ElectricityW electricity2= new ElectricityW(12345, 9000, 9300, "ASWIN");
//Console.WriteLine(electricity2.consumernumber);
//Console.WriteLine(electricity2.consumername);
//Console.WriteLine(electricity2.CalculateBill());




//ENCAPSULATIONs
//using System.Security.Cryptography;
//using Workout;
////EmployeeW employee = new(111, "AISWARYA", "ECE", 100000);
//EmployeeW employee = new EmployeeW(111, "AISWARYA", "ECE", 100000);
//Console.WriteLine("Emp Id: {0} \n Name: {1} \n Dept : {2} \n Basic Pay : {3}",  employee.Eid,
//employee.Ename,employee.Dept,employee.Basicpay);


//Console.WriteLine(employee.Dept);
//Console.WriteLine(employee.Basicpay);
//Console.WriteLine(employee.CalculateSalary());

//Console.WriteLine("Net Pay:{0}", employee.CalculateSalary());

//using Workout;

//ArrEx arraysEx = new();
//arraysEx.Onedim();
////arraysEx.Twodim();

//using Workout;

//ReverseArray o= new ReverseArray();
//o.Display();

using Workout;

SortingArray sr = new SortingArray();
sr.DisplaySort();













