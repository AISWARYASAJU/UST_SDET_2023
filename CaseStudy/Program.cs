﻿
using static CaseStudy.CustomException.MyException;



//using System.Reflection;
//using CaseStudy;
//using static System.Reflection.Metadata.BlobBuilder;


//int num = 1;
//string? title;
//int customerid;
//string? customerName;
//string? phonenumber;
//string? orderdate;
//int total;

//do
//{

//    Console.WriteLine("1.Add Book\n2.Add Customer\n3.Place Order And Display Order\n4.Search Book\n5.Exit");
//    Console.WriteLine("Choose The Option");
//    int choice = Convert.ToInt32(Console.ReadLine());

//    BookType[] bookType = new BookType[]
//          {
//            new("Gitanjali","Tagore",1782,1998,"yes","Non-Fiction"),


//          };

//    switch (choice)
//    {
//        case 1:

//            Console.WriteLine("Book Added SuccessFully");
//            foreach (BookType booktypes in bookType)
//            {
//                booktypes.DisplayDetails();
//            }
//            break;
//        case 2:

//            Console.WriteLine("Enter Customer Id");
//            customerid = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter customer name");
//            customerName = Console.ReadLine();
//            Console.WriteLine("Enter Phonenumber");
//            phonenumber = Console.ReadLine();

//            Customer customer = new Customer(customerid, customerName, phonenumber);
//            customer.DisplayCustomer();
//            break;
//        case 3:

//            Console.WriteLine("Enter the Book Title");
//            title = Console.ReadLine();


//            if (bookType[0].Title.Equals(title))
//            {
//                foreach (var book in bookType)
//                {
//                    Console.WriteLine("Enter Order Date:");
//                    orderdate = Console.ReadLine();
//                    Console.WriteLine("Order Confirmed");
//                    total = book.Price;
//                    Order order = new Order(orderdate, total);

//                    Console.WriteLine("Order Details is");

//                    order.DisplayOrder();
//                    Console.WriteLine($"Book Title is:{book.Title}");
//                    Console.WriteLine($"Book Price is:{book.Price}");
//                    Console.WriteLine($"Book Type is:{book.Genre}");


//                }
//            }
//            else
//            {
//                Console.WriteLine("Not Available");
//            }
//            break;

//        case 4:

//            Console.WriteLine("Give Title of the BOOK");
//            title = Console.ReadLine();
//            foreach (var book in bookType)
//            {
//                if (book.Title.Equals(title))
//                {
//                    Console.WriteLine($"Book Title is:{book.Title}");
//                    Console.WriteLine($"Book Price is:{book.Price}");
//                    Console.WriteLine($"Book Availability is:{book.Availability}");




//                }

//                else
//                {
//                    Console.WriteLine("Book not available");
//                }

//            }

//            break;

//        case 5:


//            Environment.Exit(0);
//            break;
//        default:
//            Console.WriteLine("Invalid Option");
//            break;
//    }
//    Console.WriteLine("For Continue press 1 or 0 for exit");
//    num = Convert.ToInt32(Console.ReadLine());

//} while (num != 0);

using CaseStudy;
try
{
    Customers customers1 = new Customers();
    customers1.CustomerID = 1;
    customers1.CustomerName = "Anju Babu";
    customers1.CustomerEmail = "anju@ust";
    Customers.customers.Add(customers1);
    Customers customers2 = new Customers();
    customers2.CustomerID = 2;
    customers2.CustomerName = "devu s";
    customers2.CustomerEmail = "devu@ust";
    Customers.customers.Add(customers2);
    Customers customer13 = new Customers();
    customer13.CustomerID = 3;
    customer13.CustomerName = "Raman";
    customer13.CustomerEmail = "raman@ust";
    Customers.customers.Add(customer13);

    while (true)
    {
        Console.WriteLine("choose your option\n1.User\n2.Admin");
        int option = Convert.ToInt32(Console.ReadLine());
        if (option == 1)
        {
            Console.WriteLine("Enter the customer id");
            int cusId = Convert.ToInt32(Console.ReadLine());
            if (Customers.customers.Find(x => x.CustomerID == cusId) == null)
            {
                Console.WriteLine("Customer not found");
                break;
            }
            Console.WriteLine("choose your option\n1.Add product to cart\n2.view all product\n3.place order\n4.Support\n5.view orders");
            int optionuser = Convert.ToInt32(Console.ReadLine());
            switch (optionuser)
            {

                case 1:

                    Console.WriteLine("Enter Product id for add to cart");
                    int productId = Convert.ToInt32(Console.ReadLine());
                    Customers customer1 = Customers.customers.Find(x => x.CustomerID == cusId);
                    if (DigitalProduct.Products.Find(x => x.ProductId == productId) == null)
                    {
                        if (PhysicalProduct.Products.Find(x => x.ProductId == productId) == null)
                        {
                            Console.WriteLine("invalid product id");
                        }
                        else
                        {
                            customer1.ordersphy.Add(PhysicalProduct.Products.Find(x => x.ProductId == productId));
                            Console.WriteLine("product added to cart");
                        }
                    }
                    else
                    {
                        customer1.orders.Add(DigitalProduct.Products.Find(x => x.ProductId == productId));
                        Console.WriteLine("product added to cart");
                    }
                    break;
                case 2:
                    Console.WriteLine("Products are");
                    if (DigitalProduct.Products.Count == 0 && PhysicalProduct.Products.Count == 0)
                    {
                        Console.WriteLine("No Product Found found");
                    }
                    foreach (var item in DigitalProduct.Products)
                    {
                        Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
                            item.Name, item.Price, item.StockQuantity, item.FileFormat, item.DownloadLink);
                    }
                    foreach (var item in PhysicalProduct.Products)
                    {
                        Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
                            "\tDimension:{5}", item.ProductId,
                            item.Name, item.Price, item.StockQuantity, item.Weight, item.Dimensions);
                    }
                    break;
                case 3:
                    Customers customer = Customers.customers.Find(x => x.CustomerID == cusId);
                    if (customer.orders.Count == 0 && customer.ordersphy.Count == 0)
                    {
                        Console.WriteLine("no product found in cart");
                    }
                    else
                    {
                        foreach (var item in customer.orders)
                        {
                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
                             item.Name, item.Price, item.StockQuantity, item.FileFormat, item.DownloadLink);
                            item.PlacingOrder();
                            item.ProceesingPayment();
                            item.DeleveringProduct();

                        }
                        foreach (var item in customer.ordersphy)
                        {
                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
                           "\tDimension:{5}", item.ProductId, item.Name, item.Price, item.StockQuantity, item.Weight, item.Dimensions);
                            item.PlacingOrder();
                            item.ProceesingPayment();
                            item.DeleveringProduct();
                        }
                        Console.WriteLine("do you want to place all the order\n1.yes\n2.no");
                        int confirm = Convert.ToInt32(Console.ReadLine());
                        if (confirm == 1)
                        {
                            customer.confirmedorders.AddRange(customer.orders);
                            customer.orders.Clear();
                            customer.confirmedordersphy.AddRange(customer.ordersphy);
                            customer.ordersphy.Clear();
                            Console.WriteLine("order placed successfully");
                        }
                        else
                        {
                            Console.WriteLine("removing everything in cart");
                        }


                    }



                    break;
                case 4:
                    Console.WriteLine("call this number for support 987654321");
                    break;
                case 5:
                    Customers customer2 = Customers.customers.Find(x => x.CustomerID == cusId);
                    if (customer2.confirmedorders.Count == 0 && customer2.confirmedordersphy.Count == 0)
                    {
                        Console.WriteLine("no order details found");
                    }
                    else
                    {
                        Console.WriteLine("Orders are");
                        foreach (var item in customer2.confirmedorders)
                        {
                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
                            item.Name, item.Price, item.StockQuantity, item.FileFormat, item.DownloadLink);
                        }
                        foreach (var item in customer2.confirmedordersphy)
                        {
                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
                           "\tDimension:{5}", item.ProductId, item.Name, item.Price, item.StockQuantity, item.Weight, item.Dimensions);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("invalid input");

                    break;
            }

            Console.WriteLine("do you want to continue as user\n1.yes\n2.no");
            int optUser = Convert.ToInt32(Console.ReadLine());
            if (optUser == 1)
            {
                continue;
            }
            else if (optUser == 2)
            {
                break;
            }
            else
            {
                Console.WriteLine("invalid input");
            }


        }
        else if (option == 2)
        {
            Console.WriteLine("choose option\n1.Add Product\n2.View report");
            int optionadmin = Convert.ToInt32(Console.ReadLine());
            if (optionadmin == 1)
            {
                Console.WriteLine("choose the option \n1.Digital Product\n2.Physical Product");
                int optionProduct = Convert.ToInt32(Console.ReadLine());
                if (optionProduct == 1)
                {
                    Console.WriteLine("Enter Product id");
                    int productid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Product Name");
                    string? productName = Console.ReadLine();
                    Console.WriteLine("enter the price");
                    double productCost = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter the stock quantity");
                    int stock= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the fileformat");
                    string? fileFormat = Console.ReadLine();
                    Console.WriteLine("Enter downloadLink");
                    string? downloadLink = Console.ReadLine();


                    DigitalProduct digitalProduct = new DigitalProduct();
                    digitalProduct.Name = productName;
                    digitalProduct.ProductId = productid;
                    digitalProduct.FileFormat = fileFormat;
                    digitalProduct.DownloadLink = downloadLink;
                    digitalProduct.Price = productCost;
                    digitalProduct.StockQuantity = stock;
                    Product.AddProduct(digitalProduct);
                    DigitalProduct.Products.Add(digitalProduct);
                }
                else if (optionProduct == 2)
                {
                    Console.WriteLine("Enter Product id");
                    int productid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Product Name");
                    string? productName = Console.ReadLine();
                    Console.WriteLine("enter the price");
                    double productCost = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter the stock quantity");
                    int stock = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Weight");
                    int weight = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter dimension");
                    string? dimension = Console.ReadLine();

                    PhysicalProduct physicalProduct = new PhysicalProduct();
                    physicalProduct.Name = productName;
                    physicalProduct.ProductId = productid;
                    physicalProduct.Price = productCost;
                    physicalProduct.StockQuantity = stock;
                    physicalProduct.Dimensions = dimension;
                    physicalProduct.Weight = weight;
                    Product.AddProducts(physicalProduct);

                    PhysicalProduct.Products.Add(physicalProduct);
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            else if (optionadmin == 2)
            {
                Console.WriteLine("choose the option \n1.Digital Product\n2.Physical Product");
                int option2Product = Convert.ToInt32(Console.ReadLine());
                if (option2Product == 1)
                {
                    DigitalProduct dp = new DigitalProduct();
                    foreach (var item in DigitalProduct.Products)
                    {
                        Console.WriteLine("Product Id:{0}  Product Name:{1}  Price:{2}  Quantity:{3}  Download Link:{4}  File Format:{5} ", item.ProductId, item.Name, item.Price, item.StockQuantity, item.DownloadLink, item.FileFormat);
                    }

                }
                else if (option2Product == 2)
                {
                    // PhysicalProduct dp = new PhysicalProduct();
                    foreach (var item in PhysicalProduct.Products)
                    {
                        Console.WriteLine("Product Id:{0}  Product Name:{1}  Price:{2}  Quantity:{3}  Weight:{4}  Dimension:{5} ", item.ProductId, item.Name, item.Price, item.StockQuantity, item.Weight, item.Dimensions);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid");
                }

            }
            else if (optionadmin == 2)
            {
                Console.WriteLine("choose the option \n1.Digital Product\n2.Physical Product");
                int option2Product = Convert.ToInt32(Console.ReadLine());
                if (option2Product == 1)
                {
                    DigitalProduct dp = new DigitalProduct();
                    foreach (var item in DigitalProduct.Products)
                    {
                        Console.WriteLine("Product Id:{0}  Product Name:{1}  Price:{2}  Quantity:{3}  Download Link:{4}  File Format:{5} ", item.ProductId, item.Name, item.Price, item.StockQuantity, item.DownloadLink, item.FileFormat);
                    }

                }
                else if (option2Product == 2)
                {
                    // PhysicalProduct dp = new PhysicalProduct();
                    foreach (var item in PhysicalProduct.Products)
                    {
                        Console.WriteLine("Product Id:{0}  Product Name:{1}  Price:{2}  Quantity:{3}  Weight:{4}  Dimension:{5} ", item.ProductId, item.Name, item.Price, item.StockQuantity, item.Weight, item.Dimensions);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid");
                }

            }

        }
        else
        {
            Console.WriteLine("invalid option");
        }
        Console.WriteLine("do you want to continue\n1.yes\n2.no");
        int opt = Convert.ToInt32(Console.ReadLine());
        if (opt == 1)
        {
            continue;
        }
        else if (opt == 2)
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("invalid input");
        }

    }
}
catch(UserException ex)
{
Console.WriteLine(ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}