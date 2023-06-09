//Links Files
using EComProductDetailsMethodOverLoading;
//Objects
Product info = new Product();
//Variables
string productName, productDescription, productCategory;
double productPrice;
//Code
Console.Write("Enter Product Name: ");
productName = Console.ReadLine();
Console.Write("Enter Product Description: ");
productDescription = Console.ReadLine();
Console.Write("Enter Product Category: ");
productCategory = Console.ReadLine();
Console.Write("Enter Product Price: ");
productPrice = double.Parse(Console.ReadLine());
info.SetValue(productName, productDescription, productCategory, productPrice);
info.GetValue();
Console.ReadKey();