
using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1 Вивести кількість слів у тексті ");
            Console.WriteLine("2 Виконати математичну операцію ");
            Console.WriteLine("3 Вийти");
            Console.Write("Введіть номер операції ");
            int choise = int.Parse(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    CountWorldsLoremIpsum();
                    break;
                case 2:
                    MathOperation();
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Введіть коректний номер операції ");
                    break;
            }
        }
    }

    static void MathOperation()
    {
        System.Data.DataTable table = new System.Data.DataTable();
        Console.Write("Введіть приклад ");
        string expression = Console.ReadLine();
        try
        {
            double result = Convert.ToDouble(table.Compute(expression, string.Empty));
            Console.WriteLine("Результат:" + result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Помилка", ex.Message);
        }

    }
    static void CountWorldsLoremIpsum()
    {
        string filename = "LoremIpsum.txt";
        string content = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), filename));
        Console.WriteLine(content);
        var CountWords = content.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
        Console.WriteLine("Кількість слів:"+CountWords);
    }

   



}

