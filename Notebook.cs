using System;

namespace Homework_Theme_01
{
    /// <summary>
    /// Класс описывающий записную книжку
    /// </summary>
    class Notebook
    {
        /// <summary>
        /// Имя контакта в записной книжке
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возраст контакта в записной книжке
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Рост контака в записной книжке
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Оценка по истории
        /// </summary>
        int PerfomanceHistory { get; set; }

        /// <summary>
        /// Оценка по математике
        /// </summary>

        int PerfomanceMath { get; set; }

        /// <summary>
        /// Оценка по русскому языку
        /// </summary>

        int PerfomanceRus { get; set; }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Notebook(string Name, int Age, int Height, int perfomanceHistory, int perfomanceMath, int perfomanceRus)
        {
            this.Name = Name;
            this.Age = Age;
            this.Height = Height;
            this.PerfomanceHistory = perfomanceHistory;
            this.PerfomanceMath = perfomanceMath;
            this.PerfomanceRus = perfomanceRus;
        }

        /// <summary>
        /// Высчитывает средний балл на основании данных введённых при создании экземпляра
        /// </summary>
        /// <returns>Возвращает строкое представление среднего балла</returns>
        public string GPA()
        {
            double Gpa;
            Gpa = (this.PerfomanceHistory + this.PerfomanceMath + this.PerfomanceRus) / 3d;
            return 
                Gpa.ToString("#.##");
        }

        public string pattern = "Имя {0}; Возраст {1}; Рост {2}; Средний балл по трём предметам {3};";

        /// <summary>
        /// Вывод информации ко контакте.
        /// </summary>
        /// <returns>Строковое представление информации.</returns>
        public override string ToString()
        {
            return
                "Имя " + Name + "; " + "Возраст " + Age + "; " + "Рост " + Height + "; " + "Средний балл по трём предметам " + this.GPA();
        }


    }
}

