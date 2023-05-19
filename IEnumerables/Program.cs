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
            Console.Write("\nEnter the value of m: ");
            var m = int.Parse(Console.ReadLine());
            Console.Write("Enter the value of n: ");
            var n = int.Parse(Console.ReadLine());
            Console.Write("Enter the value of p: ");
            var p = int.Parse(Console.ReadLine());

            List<List<int>> matrixA = new List<List<int>>();
            Utilities.GenerateMatrixA(matrixA, m, n);
            List<List<int>> matrixB = new List<List<int>>();
            Utilities.GenerateMatrixB(matrixB, n, p);
            List<List<int>> matrixC = Utilities.MultiplyMatrices(matrixA, matrixB);

            Console.WriteLine("*** A ***");
            Console.Write(Utilities.ShowMatrix(matrixA, m, n));
            Console.WriteLine("*** B ***");
            Console.Write(Utilities.ShowMatrix(matrixB, n, p));
            Console.WriteLine("*** C ***");
            Console.Write(Utilities.ShowMatrix(matrixC, m, p));
            Console.WriteLine();
            break;
        case "2":
            try
            {
                Console.Write("\nEnter the order of the array: ");
                var N = int.Parse(Console.ReadLine());
                Utilities.ValidateSize(N);

                List<List<int>> matrixOriginal = new List<List<int>>();
                Utilities.GenerateFullMatrix(matrixOriginal, N);
                List<List<int>> matrixHourglass = new List<List<int>>();
                Utilities.GenerateHourglassMatrix(matrixOriginal, matrixHourglass, N);

                Console.WriteLine("FULL MATRIX:");
                Console.Write(Utilities.ShowFullMatrix(matrixOriginal, N));
                Console.WriteLine("HOURGLASS:");
                Console.Write(Utilities.ShowHourglassMatrix(matrixHourglass, N));
                Console.WriteLine();
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                Console.WriteLine();
                continue;
            }
        case "3":
            try
            {
                Console.Write("\nEnter the number to decompose: ");
                var number = int.Parse(Console.ReadLine());
                Utilities.ValidateNumber(number);

                LinkedList<int> factors = Utilities.GetPrimeFactors(number);

                Console.WriteLine(Utilities.ShowPrimeFactors(factors, number));
                Console.WriteLine();
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                Console.WriteLine();
                continue;
            }
        case "4":
            try
            {
                Console.Write("\nEnter location of the fruits: ");
                string fruits = Console.ReadLine();
                Harvest.ValidateFruits(fruits);
                Console.Write("Enter horse starting position: ");
                string initialPosition = Console.ReadLine();
                Harvest.ValidateInitialPosition(initialPosition);
                Console.Write("Enter the horse's moves: ");
                string movements = Console.ReadLine();

                Harvest harvest = new Harvest(fruits, initialPosition);
                string collectedFruits = harvest.CollectFruits(movements);

                Console.WriteLine($"The collected fruits are: {collectedFruits}");
                Console.WriteLine();
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                Console.WriteLine();
                continue;
            }
        case "5":
            try
            {
                Console.Write("\nEnter location of horses: ");
                string locations = Console.ReadLine();
                HorseConflictSolver.ValidateLocations(locations);
                HorseConflictSolver solver = new HorseConflictSolver();
                solver.ProcessInput(locations);

                Console.WriteLine(solver.GetResults());
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                Console.WriteLine();
                continue;
            }
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
