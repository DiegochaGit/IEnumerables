using IEnumerables;

Console.WriteLine("===============================");
Console.WriteLine("     Exercises Enumerables");
Console.WriteLine("===============================");


//#region Ex33MatrixMultiplication
//Console.Write("\nEnter the value of m: ");
//var m = int.Parse(Console.ReadLine());
//Console.Write("Enter the value of n: ");
//var n = int.Parse(Console.ReadLine());
//Console.Write("Enter the value of p: ");
//var p = int.Parse(Console.ReadLine());

//List<List<int>> matrixA = new List<List<int>>();
//Utilities.GenerateMatrixA(matrixA, m, n);
//Console.WriteLine("*** A ***");
//Console.Write(Utilities.ShowMatrix(matrixA, m, n));

//List<List<int>> matrixB = new List<List<int>>();
//Utilities.GenerateMatrixB(matrixB, n, p);
//Console.WriteLine("*** B ***");
//Console.Write(Utilities.ShowMatrix(matrixB, n, p));

//List<List<int>> matrixC = Utilities.MultiplyMatrices(matrixA, matrixB);
//Console.WriteLine("*** C ***");
//Console.Write(Utilities.ShowMatrix(matrixC, m, p));
//Console.WriteLine();
//#endregion


//#region Ex34Hourglass
//var NotIsOddInteger = false;
//var n = 1;
//do
//{
//    Console.Write("\nEnter the order of the array (must be an odd integer): ");
//    n = int.Parse(Console.ReadLine());
//    if ((n + 1) % 2 != 0)
//    {
//        Console.WriteLine("\nWrong entry! The order must be an odd integer!");
//        NotIsOddInteger = true;
//    }
//} while (NotIsOddInteger);
//Console.WriteLine();

//List<List<int>> matrixOriginal = new List<List<int>>();
//List<List<int>> matrixHourglass = new List<List<int>>();

//Utilities.GenerateFullMatrix(matrixOriginal, n);
//Console.WriteLine("FULL MATRIX:");
//Console.WriteLine(Utilities.ShowFullMatrix(matrixOriginal, n));
//Console.WriteLine();

//Utilities.GenerateHourglassMatrix(matrixOriginal, matrixHourglass, n);
//Console.WriteLine("HOURGLASS:");
//Console.WriteLine(Utilities.ShowHourglassMatrix(matrixHourglass, n));
//Console.WriteLine();
//#endregion


//#region Ex35PrimeFactors
//Console.WriteLine("\nDESCOMPOSITION OF A NUMBER INTO ITS PRIME FACTORS:");
//Console.Write("\nEnter the number to decompose: ");
//int number = int.Parse(Console.ReadLine());

//LinkedList<int> factors = Utilities.GetPrimeFactors(number);

//Console.WriteLine(Utilities.ShowPrimeFactors(factors, number));
//Console.WriteLine();
//#endregion


//#region Ex36HarvestingOnHorse
//Console.WriteLine("\nHARVESTING ON HORSE:");
//Console.Write("\nEnter location of the fruits: ");
//string fruits = Console.ReadLine();

//Console.Write("Enter horse starting position: ");
//string initialPosition = Console.ReadLine();

//Console.Write("Enter the horse's moves: ");
//string movements = Console.ReadLine();

//Harvest harvest = new Harvest(fruits, initialPosition);
//string collectedFruits = harvest.CollectFruits(movements);

//Console.WriteLine($"The collected fruits are: {collectedFruits}");
//Console.WriteLine();
//#endregion


#region Ex37HorsesInConflict
Console.WriteLine("\nHORSES IN CONFLICT:");
Console.Write("\nEnter location of horses: ");
string input = Console.ReadLine();
string[] locations = input.Split(',');

HorseConflict solver = new HorseConflict();

foreach (string location in locations)
{
    LinkedList<string> conflicts = solver.GetConflicts(location);
    Console.Write($"Analyzing Horse in {location} => ");
    if (conflicts.Count == 0)
    {
        Console.WriteLine("none");
    }
    else
    {
        Console.WriteLine($"Conflict with: {string.Join(", ", conflicts)}");
    }
}
Console.WriteLine();
#endregion