using System;
using System.IO;
using System.Text;

namespace consoleApp1
{

    class Program
    {
        static void Main()
        {
            int[] sectors = { 6, 28, 15, 15, 17 };
            bool isOpen = true;

            while (isOpen)
            {
                Console.SetCursorPosition(0, 18);

                for (int i = 0; i < sectors.Length; i++)
                {
                    Console.WriteLine($"В секторе {i + 1} свободно {sectors[i]} мест.");
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Регистрация рейса!");
                Console.WriteLine("\n\n1 - Забронировать места\n\n2 - Выход из программы\n\n");
                Console.Write("Введите номер команды: ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:

                        int userSector, userPlaceAmount;

                        Console.Write("Какой сектор вы хотите выбрать?");
                        userSector = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (userSector >= sectors.Length || userSector < 0)
                        {
                            Console.WriteLine("Такого сектора не существует");
                            break;
                        }


                        Console.Write("Сколько мест вы хотите забронировать?");
                        userPlaceAmount = Convert.ToInt32(Console.ReadLine());

                        if (sectors[userSector] < userPlaceAmount || userPlaceAmount < 0)
                        {
                            Console.WriteLine($"В секторе не достаточно мест. Остаток {sectors[userSector]} мест. ");
                            break;
                        }

                        sectors[userSector] -= userPlaceAmount;

                        break;
                    case 2:
                        isOpen = false;
                        break;
                }




                Console.ReadKey();
                Console.Clear();
            }
        }



    }
}


