// See https://aka.ms/new-console-template for more information
Console.WriteLine("Number of small carpet ");
int numSmall = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number of  Large carpet");
int numLarge = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The small carpet = 25$");
Console.WriteLine("The large carpet = 35$");
Console.WriteLine("Sales tax rate is 6% Estimates are valid for 30 days");
double totalCost = (25 * numSmall + 35 * numLarge) ;
Console.WriteLine($"The cost:{(totalCost):C}");
double totalTax = totalCost * (6.0/100);
Console.WriteLine($"The tax:{(totalTax):C}");
Console.WriteLine($"Total Estimates : {(totalCost + totalTax):C}");


