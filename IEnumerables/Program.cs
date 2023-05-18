using IEnumerables;

bool endApp = false;
while (!endApp)
{
    Console.WriteLine("===============================");
    Console.WriteLine("     Exercises Enumerables");
    Console.WriteLine("===============================");
    Console.WriteLine(" 1. Ex33 Matrix Multiplication");
    Console.WriteLine(" 2. Ex34 Hourglass");
    Console.WriteLine(" 3. Ex35 Descomposition of a number into its prime factors");
    Console.WriteLine(" 4. Ex36 Harvesting On Horse");
    Console.WriteLine(" 5. Ex37 Horses In Conflict");
    Console.WriteLine(" 6. Exit");
    Console.Write("\nEnter your choice: ");

    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            #region Ex33MatrixMultiplication
            Console.Write("\nEnter the value of m: ");
            var m = int.Parse(Console.ReadLine());
            Console.Write("Enter the value of n: ");
            var n = int.Parse(Console.ReadLine());
            Console.Write("Enter the value of p: ");
            var p = int.Parse(Console.ReadLine());
            List<List<int>> matrixA = new List<List<int>>();
            Utilities.GenerateMatrixA(matrixA, m, n);
            Console.WriteLine("*** A ***");
            Console.Write(Utilities.ShowMatrix(matrixA, m, n));
            List<List<int>> matrixB = new List<List<int>>();
            Utilities.GenerateMatrixB(matrixB, n, p);
            Console.WriteLine("*** B ***");
            Console.Write(Utilities.ShowMatrix(matrixB, n, p));
            List<List<int>> matrixC = Utilities.MultiplyMatrices(matrixA, matrixB);
            Console.WriteLine("*** C ***");
            Console.Write(Utilities.ShowMatrix(matrixC, m, p));
            Console.WriteLine();
            #endregion
            break;
        case "2":
            #region Ex34Hourglass
            var NotIsOddInteger = false;
            var N = 1;
            do
            {
                Console.Write("\nEnter the order of the array (must be an odd integer): ");
                N = int.Parse(Console.ReadLine());
                if ((N + 1) % 2 != 0)
                {
                    Console.WriteLine("\nWrong entry! The order must be an odd integer!");
                    NotIsOddInteger = true;
                }
            } while (NotIsOddInteger);
            Console.WriteLine();
            List<List<int>> matrixOriginal = new List<List<int>>();
            List<List<int>> matrixHourglass = new List<List<int>>();
            Utilities.GenerateFullMatrix(matrixOriginal, N);
            Console.WriteLine("FULL MATRIX:");
            Console.WriteLine(Utilities.ShowFullMatrix(matrixOriginal, N));
            Console.WriteLine();
            Utilities.GenerateHourglassMatrix(matrixOriginal, matrixHourglass, N);
            Console.WriteLine("HOURGLASS:");
            Console.WriteLine(Utilities.ShowHourglassMatrix(matrixHourglass, N));
            Console.WriteLine();
            #endregion
            break;
        case "3":
            #region Ex35PrimeFactors
            Console.Write("\nEnter the number to decompose: ");
            int number = int.Parse(Console.ReadLine());
            LinkedList<int> factors = Utilities.GetPrimeFactors(number);
            Console.WriteLine(Utilities.ShowPrimeFactors(factors, number));
            Console.WriteLine();
            #endregion
            break;
        case "4":
            #region Ex36HarvestingOnHorse
            Console.Write("\nEnter location of the fruits: ");
            string fruits = Console.ReadLine();
            Console.Write("Enter horse starting position: ");
            string initialPosition = Console.ReadLine();
            Console.Write("Enter the horse's moves: ");
            string movements = Console.ReadLine();
            Harvest harvest = new Harvest(fruits, initialPosition);
            string collectedFruits = harvest.CollectFruits(movements);
            Console.WriteLine($"The collected fruits are: {collectedFruits}");
            Console.WriteLine();
            #endregion
            break;
        case "5":
            #region Ex37HorsesInConflict
            Console.Write("\nEnter location of horses: ");
            string input = Console.ReadLine();
            HorseConflictSolver solver = new HorseConflictSolver();
            solver.ProcessInput(input);
            Console.WriteLine(solver.GetResults());
            #endregion
            break;
        case "6":
            Console.WriteLine();
            endApp = true;
            break;
        default:
            Console.WriteLine("Invalid choice!!");
            Console.WriteLine();
            break;
    }
}
