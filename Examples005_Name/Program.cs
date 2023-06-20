// Программа реакции на определенное значение
Console.WriteLine("Введите имя пользовтеля ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Прости, Маша, мы все проебали...");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}