int number1, number2, result;
char symbol;

Console.Write("1.sayıyı giriniz:");
number1 = int.Parse(Console.ReadLine());

Console.Write("2.sayıyı giriniz:");
number2 = int.Parse(Console.ReadLine());

Console.Write("lütfen yapmakn istediğiniz işlemi giriniz:");
symbol = char.Parse(Console.ReadLine());

switch (symbol)
{
    case '+':
        result = number1 + number2;
        Console.WriteLine("toplam: " + result);
        break;

    case '-':
        result = number1 - number2;
        Console.WriteLine("fark: " + result);
        break;

    case '*':
        result = number1 * number2;
        Console.WriteLine("çarpım: " + result);
        break;

    case '/':
        result = number1 / number2;
        Console.WriteLine("bölüm: " + result);
        break;
}