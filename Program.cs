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

        public Pen(string penColor, int penCost)
        {
            color = penColor;
            cost = penCost;
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

    class Bus
    {
        public int? Load;

        public void PrintStatus()
        {
            if (Load.HasValue)
            {
                Console.WriteLine("В автобусе {0} пассажиров", Load.Value);
            }
            else
            {
                Console.WriteLine("Автобус пуст!");
            }
        }
    }

    class Car
    {
        public double Fuel;
        public int Mileage;

        public Car()
        {
            Fuel = 50;
            Mileage = 0;
        }

        public void Move()
        {
            // Move a kilometer
            Mileage++;
            Fuel -= 0.1;
        }

        public void FillTheCar()
        {
            Fuel = 50;
        }
    }

    class TrafficLight
    {
        private string color;

        public string Color
        {
            set
            {
                color = value;
            }

            get
            {
                return color;
            }
        }
    }

    class User
    {
        public int Age { private get; set; }

        private string login;

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Логин должен быть длиной от 3 символов");
                }
                else
                {
                    login = value;
                }
            }
        }

        private string email;

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                if (!value.Contains('@'))
                {
                    Console.WriteLine("Неверный формат адреса электронной почты");
                }
                else
                {
                    email = value;
                }
            }
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

            Pen pen1 = new Pen();
            Console.WriteLine("Ручка, цвет \"{0}\", цена {1}", pen1.color, pen1.cost);

            Pen pen2 = new Pen("Blue", 200);
            Console.WriteLine("Ручка, цвет \"{0}\", цена {1}", pen2.color, pen2.cost);

            Rectangle rectangle1 = new Rectangle();
            Console.WriteLine(rectangle1.Square());

            Rectangle rectangle2 = new Rectangle(5);
            Console.WriteLine(rectangle2.Square());

            Rectangle rectangle3 = new Rectangle(9, 3);
            Console.WriteLine(rectangle3.Square());

            Bus bus = new Bus();
            bus.Load = 10;
            bus.PrintStatus();

            Car car = new Car();
            while (car.Fuel > 0)
            {
                car.Move();
            }
            Console.WriteLine("Машина проехала {0} км", car.Mileage);

            TrafficLight trafficLight = new TrafficLight();
            trafficLight.Color = "зелёный";
            Console.WriteLine("Сигнал светофора {0}", trafficLight.Color);

            User user = new User();
            user.Age = 37;
            user.Login = "v-king777";
            user.Email = "v.kolpashchikov@gmail.com";
            //Console.WriteLine("Ваш возраст: {0}", user.Age);
            Console.WriteLine("Ваш логин: {0}", user.Login);
            Console.WriteLine("Ваш email: {0}", user.Email);

            Console.ReadKey(true);
        }
    }
}
