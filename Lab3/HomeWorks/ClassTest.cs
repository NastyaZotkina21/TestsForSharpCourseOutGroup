using System;
using System.Collections.Generic;


namespace Lab3.HomeWorks
{
    /// <summary>
    /// Класс для реализации метода сравнения объектов
    /// </summary>
    public class ClassTest : IComparable
    {
        private string name = "";

        public ClassTest(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get; set; }

        public int CompareTo(object obj)
        {
            ClassTest temp = obj as ClassTest;

            if (temp == null)
                throw new Exception("Невозможно сравнить два объекта");
            if (this.Age > temp.Age)
                return 1;
            if (this.Age < temp.Age)
                return -1;
            else
                return 0;
        }

        public override bool Equals(object obj)
        {
            ClassTest temp = obj as ClassTest;

            if (temp == null)
                throw new Exception("Невозможно сравнить два объекта");
            if (this.Age == temp.Age && this.Name == temp.Name)
                return true;
            else 
                return false;
        }

    }
   }
