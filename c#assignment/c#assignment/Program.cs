// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//GRADE CALCULATOR

//Console.WriteLine("GRADE CALCULATOR enter marks from 0 to 100");
//Your program should:Prompt the user to input marks for Mathematics, Science, and English
//Console.WriteLine("Enter marks for Mathematics : ");
//int math = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter marks for Science : ");
//int sci = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter marks for English : ");
//int eng = Convert.ToInt32(Console.ReadLine());
//Calculate the average marks
//int avg = (math + sci + eng) / 3;
//Console.WriteLine($"Average marks : {avg}");

//.Determine the final grade based on the average marks using a switch case statement
//switch (avg/10)
//{
//    case 10:
//    case 9:
//        Console.WriteLine("Final Grade : A");
//        break;
//    case 8:
//        Console.WriteLine("Final Grade : B");
//        break;
//    case 7:
//        Console.WriteLine("Final Grade : C");
//        break;
//    case 6:
//        Console.WriteLine("Final Grade : D");
//        break;
//    default:
//        Console.WriteLine("Final Grade : F");
//        break;
//}

//Temperature converter
Console.WriteLine("Choose the temperature scale to convert from: 1. Celsius 2. Fahrenheit");
Console.WriteLine("Enter your choice: ");
int choice= Convert.ToInt32(Console.ReadLine());
if (choice == 1)
{
    Console.WriteLine("Enter temperature in Celsius ");
    double cel = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"{cel}°C equal to {cel * 9 / 5 + 32}°F");
}
if (choice == 2)
{
    Console.WriteLine("Enter temperature in  Fahrenheit ");
    double feh = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"{feh}°F equal to {(feh - 32) * 5 / 9}°C");
}
Console.WriteLine("Do you want to convert another temperature? (Y/N):");
char temp =Convert.ToChar(Console.ReadLine());
if (temp == 'y' || temp == 'Y')
{
    Console.WriteLine("Choose the temperature scale to convert from: 1. Celsius 2. Fahrenheit");
    Console.WriteLine("Enter your choice: ");
    int ch = Convert.ToInt32(Console.ReadLine());
    if (ch == 1)
    {
        Console.WriteLine("Enter temperature in Celsius ");
        double cel = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{cel}°C equal to {(cel * 9) / 5 + 32}°F");
    }
    if (ch == 2)
    {
        Console.WriteLine("Enter temperature in  Fahrenheit ");
        double feh = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{feh}°F equal to {(feh - 32) * 5 / 9}°C");
    }  
}
if (temp == 'n' || temp == 'N')
{
    Console.WriteLine("Thank you for using the temperature converter!");
}

    Console.WriteLine("Do you want to convert another temperature? (Y/N):");
char tem = Convert.ToChar(Console.ReadLine());
if (tem == 'y' || tem == 'Y')
{
    Console.WriteLine("Choose the temperature scale to convert from: 1. Celsius 2. Fahrenheit");
    Console.WriteLine("Enter your choice: ");
    int ch = Convert.ToInt32(Console.ReadLine());
    if (ch == 1)
    {
        Console.WriteLine("Enter temperature in Celsius ");
        double cel = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{cel}°C equal to {(cel * 9) / 5 + 32}°F");
    }
    if (ch == 2)
    {
        Console.WriteLine("Enter temperature in  Fahrenheit ");
        double feh = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{feh}°F equal to {(feh - 32) * 5 / 9}°C");
    }
}
if (tem == 'n' || tem == 'N')
{
    Console.WriteLine("Thank you for using the temperature converter!");
}





