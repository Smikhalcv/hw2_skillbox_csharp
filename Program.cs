using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заказчик просит написать программу «Записная книжка». Оплата фиксированная - $ 120.

            // В данной программе, должна быть возможность изменения значений нескольких переменных для того,
            // чтобы персонифецировать вывод данных, под конкретного пользователя.

            // Для этого нужно: 
            // 1. Создать несколько переменных разных типов, в которых могут храниться данные
            //    - имя;
            //    - возраст;
            //    - рост;
            //    - баллы по трем предметам: история, математика, русский язык;

            // 2. Реализовать в системе автоматический подсчёт среднего балла по трем предметам, 
            //    указанным в пункте 1.

            // 3. Реализовать возможность печатки информации на консоли при помощи 
            //    - обычного вывода;
            //    - форматированного вывода;
            //    - использования интерполяции строк;

            // 4. Весь код должен быть откомментирован с использованием обычных и хml-комментариев

            // **
            // 5. В качестве бонусной части, за дополнительную оплату $50, заказчик просит реализовать 
            //    возможность вывода данных в центре консоли.

            /// <summary>
            /// Выводит текст посреди окна консоли
            /// <summary>
            void WriteLineCentered(string text)
            {
                int width = Console.WindowWidth;
                if (text.Length < width)
                {
                    text = text.PadLeft((width - text.Length) / 2 + text.Length, ' ');  
                }
                Console.WriteLine(text);
            };

            Notebook Tom = new Notebook("Tom", 29, 172, 6, 9, 1);
            
            // Вывод конкотенации из переопределения в классе записной книги
            WriteLineCentered(Tom + "");

            // Вывод интерполяцией
            WriteLineCentered($"Имя {Tom.Name,15}; Возраст {Tom.Age,5}; Рост {Tom.Height,5}; Средний балл по трём предметам {Tom.gpa.ToString("#.##"),5}");

            // Форматированный вывод
            Console.WriteLine(Tom.pattern, Tom.Name, Tom.Age, Tom.Height, Tom.gpa.ToString("#.##"));
            Console.ReadKey(); Console.Clear();
            Console.WriteLine();
        }
    }
}
