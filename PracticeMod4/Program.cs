namespace PracticeMod4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                (string name, string lastName, string login, int loginLength, bool hasPet, int age, string[] favcolor) user;
                Console.WriteLine("Введите ваше имя:");
                user.name = Console.ReadLine();
                Console.WriteLine("Введите вашу фамилию:");
                user.lastName = Console.ReadLine();
                Console.WriteLine("Введите логин:");
                user.login = Console.ReadLine();
                user.loginLength = user.login.Length;
                Console.WriteLine("Есть ли у вас домашние животные? Да или Нет");
                string pet = Console.ReadLine();
                if (pet == "Да")
                {
                    user.hasPet = true;
                    Console.WriteLine(user.hasPet);
                }
                else
                {
                    user.hasPet = false;
                    Console.WriteLine(user.hasPet);
                }
                Console.WriteLine("Введите ваш возраст:");
                user.age = int.Parse(Console.ReadLine());
                user.favcolor = new string[3];
                Console.WriteLine("Введите три любимых цвета:");
                for (int b = 0; b < user.favcolor.Length; b++)
                {
                    user.favcolor[b] = Console.ReadLine();
                }
            }
            

        }
    }
}
