// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

// username.ToLower() - эта шляпа не работает, наверное из библиотеки тянется
if (username.ToLower() == "Маша") {
    System.Console.WriteLine("Машку за ляшку! Кого я вижу!");
} else {
    System.Console.WriteLine("Привет, " + username);
}
