Console.WriteLine("Введите Имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "Маша")
{
    Console.WriteLine("Ура это МАША");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
