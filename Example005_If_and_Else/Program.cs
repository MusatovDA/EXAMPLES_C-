Console.WriteLine("Введите имя пользователя:");
string username = Console.ReadLine();

if (username.ToLower() == "demon")
{
    Console.WriteLine("УРА! Привет бро!");
}
else
{
    Console.Write("Здравствуйте!, ");
    Console.WriteLine(username);
}