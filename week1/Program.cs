Console.WriteLine("Estimate for carpet cleaning service");

//Get the number of small carpet from the user
Console.Write("Number of small carpets: ");
int NumSmallCarpets = Convert.ToInt32(Console.ReadLine());

//Get the number of large carpets from the user
Console.Write("Number of large carpets: ");
int NumLargeCarpets = Convert.ToInt32(Console.ReadLine());

//Pricing Guide 
Console.WriteLine("Price per small room: $25 ");
int priceOfSmall = 25;
Console.WriteLine("Price per large room: $35 ");
int priceOflarge = 35;

//Calculate the cost
int cost = (NumSmallCarpets * priceOfSmall) + (NumLargeCarpets * priceOflarge);
Console.WriteLine($"Cost: {cost:C1}");

//Calculate tax (Sales tax rate is 6%)
double tax = Convert.ToDouble(cost) * (6.0 / 100);
Console.WriteLine($"Tax: {tax:C1}");
Console.WriteLine("===============================");

//Calculate the total estimate
double totaEstimate = cost + tax;
Console.WriteLine($"Total estimate: {totaEstimate:C1}");//C1 indicate sign dolar and one decimal
Console.WriteLine("This estimate is valid for 30 days");
