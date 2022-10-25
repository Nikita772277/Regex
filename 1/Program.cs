using System.Text.RegularExpressions;

void Number()
{
    Console.WriteLine($"Введите номер");
    Console.WriteLine();
    Console.WriteLine($"Примеры ввода: +7 123 456 78 91");
    Console.WriteLine($"7 123 456 78 91");
    Console.WriteLine($"8 123 456 78 91");
    Console.WriteLine();
    string a = Console.ReadLine();
    Regex regex = new Regex(@"[7]{1} [0-9]{3} [0-9]{3} [0-9]{2} [0-9]{2}$");
    Regex regex3 = new Regex(@"[8]{1} [0-9]{3} [0-9]{3} [0-9]{2} [0-9]{2}$");
    Regex regex2 = new Regex(@"[+7]{1} [0-9]{3} [0-9]{3} [0-9]{2} [0-9]{2}$");
    regex.IsMatch(a);
    regex2.IsMatch(a);
    regex3.IsMatch(a);
    if (regex2.IsMatch(a) || regex3.IsMatch(a))
    {
        Console.WriteLine($"Введённый номер принят");
        Console.WriteLine();
        Console.WriteLine($"Введённый номер телефона - {a}");
    }
    else if (regex.IsMatch(a))
    {
        Console.WriteLine($"Введённый номер принят");
        Console.WriteLine();
        Console.WriteLine($"Введённый номер телефона - +{a}");
    }
    else
    {
        Console.WriteLine($"Номер введён неверно");
    }
}
void Mail()
{
    Console.WriteLine($"Введите почту");
    Console.WriteLine();
    Console.WriteLine($"Пример ввода nikita@mail.ru");
    Console.WriteLine();
    string mail = Console.ReadLine();
    Regex regex = new Regex(@"^[a-z,0-9]{6,20}@yandex.ru$");
    Regex regex2 = new Regex(@"^[a-z,0-9]{6,20}@mail.ru$");
    Regex regex3 = new Regex(@"^[a-z,0-9]{6,20}@gmail.ru$");
    regex.IsMatch(mail);
    regex2.IsMatch(mail);
    regex3.IsMatch(mail);
    if (regex.IsMatch(mail) || regex2.IsMatch(mail) || regex3.IsMatch(mail))
    {
        Console.WriteLine($"Введённая почта - {mail} ");
    }
    else
    {
        Console.WriteLine($"Номер введён неверно");
    }
}
while (true)
{
    Number();
    Mail();
}
