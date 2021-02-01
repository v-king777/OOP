using System;

namespace OOP
{
    class Human
    {
        // Поля класса
        public string name;
        public int age;

        // Метод класса
        public void Greetings()
        {
            Console.WriteLine("Меня зовут {0}, мне {1}", name, age);
        }

        // Конструктор 1
        public Human()
        {
            name = "Неизвестно";
            age = 20;
        }

        // Конструктор 2
        public Human(string n)
        {
            name = n;
            age = 20;
        }

        // Конструктор 3
        public Human(string n, int a)
        {
            name = n;
            age = a;
        }
    }

    struct Animal
    {
        // Поля структуры
        public string type;
        public string name;
        public int age;

        // Метод структуры
        public void Info()
        {
            Console.WriteLine("Это {0} по кличке {1}, ему {2}", type, name, age);
        }
    }

    class Pen
    {
        public string color;
        public int cost;

        public Pen()
        {
            color = "Black";
            cost = 100;
        }

        public Pen(string penColor, int penCcost)
        {
            color = penColor;
            cost = penCcost;
        }
    }

    class Rectangle
    {
        public int a;
        public int b;

        public Rectangle()
        {
            a = 6;
            b = 4;
        }

        public Rectangle(int side)
        {
            a = side;
            b = side;
        }

        public Rectangle(int first, int second)
        {
            a = first;
            b = second;
        }

        public int Square()
        {
            return a * b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();
            human1.Greetings();

            Human human2 = new Human("Владимир");
            human2.Greetings();

            Human human3 = new Human("Владимир", 37);
            human3.Greetings();

            Animal animal = new Animal { type = "Собака", name = "Вольт", age = 4 };
            animal.Info();

            Rectangle rectangle1 = new Rectangle();
            Console.WriteLine(rectangle1.Square());

            Rectangle rectangle2 = new Rectangle(5);
            Console.WriteLine(rectangle2.Square());

            Rectangle rectangle3 = new Rectangle(7, 3);
            Console.WriteLine(rectangle3.Square());

            Console.ReadKey(true);
        }
    }
}
