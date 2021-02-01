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
        public  int perfomanceHistory { get; set; }

        /// <summary>
        /// Оценка по математике
        /// </summary>
        
        public int perfomanceMath { get; set; }

        /// <summary>
        /// Оценка по русскому языку
        /// </summary>
         
        public int perfomanceRus { get; set; }

        /// <summary>
        /// Срдний балл
        /// </summary>

        public double gpa;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Notebook(string Name, int Age, int Height, int perfomanceHistory, int perfomanceMath, int perfomanceRus)
        {
            this.Name = Name;
            this.Age = Age;
            this.Height = Height;
            this.perfomanceHistory = perfomanceHistory;
            this.perfomanceMath = perfomanceMath;
            this.perfomanceRus = perfomanceRus;
            this.gpa = (this.perfomanceHistory + this.perfomanceMath + this.perfomanceRus) / 3d;
        }

        public string pattern = "Имя {0}; Возраст {1}; Рост {2}; Средний балл по трём предметам {3};";

        /// <summary>
        /// Вывод информации ко контакте.
        /// </summary>
        /// <returns>Строковое представление информации.</returns>
        public override string ToString()
        {
            return
                "Имя " + Name + "; " + "Возраст " + Age + "; " + "Рост " + Height + "; " + "Средний балл по трём предметам " + gpa.ToString("#.##");
        }


    }
}

