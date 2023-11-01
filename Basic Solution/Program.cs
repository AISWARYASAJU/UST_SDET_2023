// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Hai");
//Console.ReadLine();
/*Console.WriteLine("Enter 2 numbers");
int num1, num2, ans;
num1 = Convert.ToInt32(Console.ReadLine());
num2 = Convert.ToInt32(Console.ReadLine());
ans = num1 + num2;
Console.WriteLine(ans); */
/*
string s1;
string s2;
string s3;
s1=Console.ReadLine();
s2=Console.ReadLine();
s3 = s1 + " " + s2;
Console.WriteLine(s3);
Console.WriteLine(s1.Equals(s2));
Console.WriteLine(s1.ToUpper());
Console.WriteLine(s1.ToLower());
Console.WriteLine(s2.Substring(3));
string[] s=s3.Split(' ');
for(int i=0;i<s.Length;i++)

    Console.WriteLine(s[i]);
*/



//driver
//
/*char x = '5';
switch (x)
{
    case 1:
        Console.WriteLine();
        break;
    case 2:
        Console.WriteLine();
        break;
    case 3:
    default:
        Console.WriteLine();
        break;
}
*/


/*
using Basic_Program;



Calculation calculation = new Calculation();
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
double res = calculation.add(num1, num2);
Console.WriteLine(res); */

/*using Basic_Solution;

Electricity electricity1= new Electricity(12345, 9000, 9300, "XX");
Console.WriteLine(electricity1.consumernumber);
Console.WriteLine(electricity1.consumername);
Console.WriteLine(electricity1.CalculateBill());

Electricity electricity2= new Electricity(12345, 9000, 9300, "XX");
Console.WriteLine(electricity2.consumernumber);
Console.WriteLine(electricity2.consumername);
Console.WriteLine(electricity2.CalculateBill());
*/


/*using Basic_Solution;

Employee employee = new(111, "AISWARYA", "ECE", 100000);
Console.WriteLine("Emp Id: {0} \n Name: {1} \n" + "Dept : {2} \n Basic Pay : {3}",
  employee.Eid,
  employee.Ename,
  employee.Dept,
  employee.Basicpay);
//Console.WriteLine(employee.Dept);
//Console.WriteLine(employee.Basicpay);
//Console.WriteLine(employee.CalculateSalary());

Console.WriteLine("Net Pay:{0}", employee.CalculateSalary());*/



/*using Basic_Solution;

ArraysEx arraysEx = new();
//arraysEx.Onedim();
//arraysEx.Twodim();

arraysEx.Ja(); */

/*using Basic_Solution;
StudentMarks marks = new();
marks.RollNo = 10000;
marks.StudName = "Me";
marks.Mark1 = 10;
marks.Mark2 = 20;
marks.mark3 = 30;
//StudentMarks marks = new(1000, "aaa", "tvm", 98, 89, 92, 0, 0);
marks.DisplayStudentDetails();
Console.WriteLine(" total"+marks.CalculateTotal());
Console.WriteLine("Average" +marks.CalculateAverage()); */


/*using Basic_Solution;

StudentGrade grade = new();
grade.RollNo = 0;
grade.StudName = " Myname";
grade.Mark1 = 1;
grade.Mark2 = 12;
grade.mark3 = 1;
grade.DisplayStudentDetails();
Console.WriteLine(grade.CalculateTotal());
Console.WriteLine(grade.CalculateAverage());
Console.WriteLine(grade.CalculateGrade()); */

/*using Basic_Solution;
Console.WriteLine("1. TS 2. NTS");
switch(Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        TeachingStaff ts = new TeachingStaff();
        ts.Staffid = 111;
        ts.Name = "TS";
            ts.Dept = "CS";
        ts.Specializations = "Os, DBMS, DS";
        ts.Sem = 2;
        ts.DisplayStaffDetails();
        ts.DisplayTSStaffDetails();
        break;
    case 2:
        NonTeachingStaff nts = new NonTeachingStaff();
        nts.Staffid = 111;
        nts.Name = "TS";
        nts.Dept = "CS";
        nts.Responsibilities = "Att, Sal";
        nts.Experience = 3;
        nts.DisplayStaffDetails();
        nts.DisplayNTStaffDetails();
        break;
    } */



/*using Basic_Solution;

EV ev = new();
ev.Vehnum = 444;
ev.Brand = "XX";
ev.Model = "AA";
ev.Disp();
Console.WriteLine(ev.setTypeForVehicle());


PV pv = new PV();
pv.Vehnum = 444;
pv.Brand = "XX";
pv.Model = "AA";
pv.Disp();
Console.WriteLine(pv.setTypeForVehicle()); */
/*using Basic_Solution;

Doctor doc= new Doctor();
doc.AddNewDoctor(123,"aa");
doc.DisplayDoctorDetails(1,"ss");
doc.ModifyDoctor(2,"aaas");
doc.DisplayDoctorDetails(3,"aa");
doc.BookApp(920, "xx");
doc.DelApp("yu"); */

/*using Basic_Solution;

//BankDetails  bank= new BankDetails(1234, 1223333333334L, "AA", "Inactive");
//Console.WriteLine("1. Custid 2. Accno 3. Name");
//int ch = Convert.ToInt32(Console.ReadLine());
BankDetails  bank2= new (1234, 1223333333334L, "AA", "Inactive");
bank2.WelcomeMessage();
bank2.WelcomeMessage("Aiswarya");
Console.WriteLine("1. Custid 2. Accno 3. Name");
int ch = Convert.ToInt32
switch (ch)
{
    case 1:
        Console.WriteLine("Custid :");
        bank.GetAccountDetails(Convert.ToInt32(Console.ReadLine()));
        break;

    case 2:
        Console.WriteLine("Accno :");
        bank.GetAccountDetails(Convert.ToInt64(Console.ReadLine()));
        break;

    case 3:
        Console.WriteLine("Name :");
        bank.GetAccountDetails(Convert.ToInt64(Console.ReadLine()));
        break;
    default: Console.WriteLine("Enter bet 1-3");
        break;
}



     */
/*using Basic_Solution;

NGC nGC = new NGC();
//nGC.ArrayListHandling();
//nGC.Stackhandling();
//nGC.Queuehandling();
//nGC.HThandling();
//nGC.SLHandling();
Basic_Solution.
    GC gC = new();

gC.Listhandling(); */
//using Basic_Solution;
//using Basic_Solution.ExceptionMessage;
//using System.Linq.Expressions;

//ExcepHandling excep = new ExcepHandling(10,0);
////excep.Divide();

//try
//{
//    excep.Divide();
//}
//catch (ArithmeticException ex)
//{
//                                                   //Console.WriteLine(ex.Message);
//    Console.WriteLine(MyException.exmesslist["div 0"]);
//}
//                                                  //Console.WriteLine(ex.Source);

//                     //Console.WriteLine("dont give 0 for deno");

//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine(MyException.exmesslist[2]);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(MyException.exmesslist[3]);
//}

//            // finally


//using Basic_Solution;
/////*
/////
//FileOperations fo= new FileOperations();
////fo.CreateFile();

////fo.WriteData();
//fo.FileProperties();

//using Basic_Solution;

//GenEx<int> g1 = new GenEx<int>(10,20);
//Console.WriteLine(g1.Val1 + " "+ g1.Val2);

//GenEx<double> g2 = new GenEx<double>(10.1, 20.22);
//Console.WriteLine(g2.Val1 + " " + g2.Val2);

//GenEx<string> g3 = new GenEx<string>("HAI", "AISWARYA");
//Console.WriteLine(g3.Val1 + " " + g3.Val2);

//GenEx<bool> g4 = new GenEx<bool>(true, false);
//Console.WriteLine(g4.Val1 + " " + g4.Val2);

//using Basic_Solution;


//GenEx<int> ga = new GenEx<int> (new int[3] {10,20,30});

//ga.Disp();
//static void Swap<T>(ref T num1, ref T num2)
//{
//    T temp;
//    temp = num1;
//    num1 = num2;
//    num2 = temp;
//}

//int n1 = 10, n2 = 20;
//char c1 = 'A', c2 = 'B';
//Swap<int>(ref n1, ref n2);
//Swap<char>(ref c1, ref c2);

//Console.WriteLine("a= {0}, b={1}", n1, n2);
//Console.WriteLine("c={0}, d={1}", c1, c2);

//using Basic_Solution;

//public delegate void Del1();      //Del1 delegate name
//class Program
//{
    
//    public static void Main(string[] args)

//    {
//        Del1 dobj1 = DelEx.MethodA;
//        dobj1("Hello how r u");

//        DelEx delEx = new();
//        DelEx delEx2 = new();
//        dobj2(10, 20);




//       // dobj1.Invoke();

//    }
//}
    


