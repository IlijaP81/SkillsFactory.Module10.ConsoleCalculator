
using ConsoleCalculator;

class Program
{
    static ILogger logger {  get; set; }
    static void Main(string[] args)
    {
        StartProgram();
    }

    /// <summary>
    /// Checks user's input. Call appropriate method or exception.
    /// </summary>
    private static void StartProgram()
    {
        logger = new Logger();
        Calculator calculator = new Calculator(logger);
        try
        {
            Console.WriteLine("Введите первое слагаемое (дробное число введите через запятую): ");
            bool res1 = double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine("Введите второе слагаемое (дробное число введите через запятую): ");
            bool res2 = double.TryParse(Console.ReadLine(), out double y);

            if (res1 & res2)
            {
                calculator.Calculate(x, y);
            }
            else throw new SpecialException();
        }
        catch (SpecialException)
        {
            logger.Error("Неправильный формат. Необходимо ввести число");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка " + ex.ToString());
        }
        finally
        {
            logger.Event("Работа программы завершена");
        }
        
    }
}