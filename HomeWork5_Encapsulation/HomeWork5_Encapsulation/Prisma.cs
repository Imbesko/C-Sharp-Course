using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Prisma
    {
        int height { get; set; }
        float volume { get; set; }

        public byte menu()
        {
            Console.WriteLine("Сделайте выбор: ");
            Console.Write("\n0. - Выход\n1. - Показать высоту призмы.\n2. - Показать количество боковых граней\n3. - Показать площадь основания\n4. - Показать длинну сторон призмы\n5. - Показать объем призмы\n6. - Установить высоту призмы\n7. - Установить длинну сторон призмы\n8. - Установить кол-во граней\n9. - Задать площадь основания\n>> ");
            byte choose = byte.Parse(Console.ReadLine());
            return choose;
        }
    }
}
