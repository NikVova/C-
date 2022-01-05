Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "сева"){
    Console.WriteLine("Ура, это же Всеволод !!!");
}
else{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
