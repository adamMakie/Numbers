Console.CursorVisible = false;

int firstGivenNumber;
int secondGivenNumber;

bool applicationRunning = true;

do
{
    Console.WriteLine("(1) Addera");
    Console.WriteLine("(2) Subtrahera");
    Console.WriteLine("(3) Multiplicera");
    Console.WriteLine("(4) Dividera");
    Console.WriteLine("(5) Modulus / Rest");
    Console.WriteLine("(6) Avsluta");

    bool invalidSelection;

    ConsoleKeyInfo userInput;

    do
    {
        userInput = Console.ReadKey(true);

        invalidSelection = !(userInput.Key == ConsoleKey.D1 ||
                             userInput.Key == ConsoleKey.NumPad1 ||
                             userInput.Key == ConsoleKey.D2 ||
                             userInput.Key == ConsoleKey.NumPad2 ||
                             userInput.Key == ConsoleKey.D3 ||
                             userInput.Key == ConsoleKey.NumPad3 ||
                             userInput.Key == ConsoleKey.D4 ||
                             userInput.Key == ConsoleKey.NumPad4 ||
                             userInput.Key == ConsoleKey.D5 ||
                             userInput.Key == ConsoleKey.NumPad5 ||
                             userInput.Key == ConsoleKey.D6 ||
                             userInput.Key == ConsoleKey.NumPad6);

    } while (invalidSelection);

    Console.Clear();
    Console.CursorVisible = true;

    switch (userInput.Key)
    {
        case ConsoleKey.D1:
        case ConsoleKey.NumPad1:

            Console.WriteLine("Addera");

            Console.Write("Nummer 1: ");
            firstGivenNumber = int.Parse(Console.ReadLine());

            Console.Write("Nummer 2: ");
            secondGivenNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(firstGivenNumber + secondGivenNumber);


            break;

        case ConsoleKey.D2:
        case ConsoleKey.NumPad2:

            Console.WriteLine("Subtrahera");

            Console.Write("Nummer 1: ");
            firstGivenNumber = int.Parse(Console.ReadLine());

            Console.Write("Nummer 2: ");
            secondGivenNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(firstGivenNumber - secondGivenNumber);

            break;

        case ConsoleKey.D3:
        case ConsoleKey.NumPad3:

            Console.WriteLine("Multiplicera");

            Console.Write("Nummer 1: ");
            firstGivenNumber = int.Parse(Console.ReadLine());

            Console.Write("Nummer 2: ");
            secondGivenNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(firstGivenNumber * secondGivenNumber);

            break;

        case ConsoleKey.D4:
        case ConsoleKey.NumPad4:

            Console.WriteLine("Dividera");

            Console.Write("Nummer 1: ");
            firstGivenNumber = int.Parse(Console.ReadLine());

            Console.Write("Nummer 2: ");
            secondGivenNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(firstGivenNumber / secondGivenNumber);

            break;

        case ConsoleKey.D5:
        case ConsoleKey.NumPad5:

            Console.WriteLine("Modulus / Rest");

            Console.Write("Nummer 1: ");
            firstGivenNumber = int.Parse(Console.ReadLine());

            Console.Write("Nummer 2: ");
            secondGivenNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(firstGivenNumber % secondGivenNumber);

            break;

        case ConsoleKey.D6:
        case ConsoleKey.NumPad6:

            applicationRunning = false;

            break;
    }

    Console.ReadKey();

    Console.Clear();

} while (applicationRunning);




