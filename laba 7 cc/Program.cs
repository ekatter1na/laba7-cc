namespace laba_7_cc
{
    abstract class Transport
    {
        public abstract int speed { get; set; }
        public abstract int load_capacity { get; set; }
        public abstract int distance { get; set; }

        public abstract int speed2();
        public abstract int load_capacity2();
        public abstract int distance2();
    }

    abstract class Car : Transport
    {
        public override int speed2() { return speed; }
        public override int distance2() { return load_capacity; }
        public override int load_capacity2() { return distance; }
    }

    abstract class Plane : Transport
    {
        public override int speed2() { return speed; }
        public override int distance2() { return load_capacity; }
        public override int load_capacity2() { return distance; }
    }
    abstract class Ship : Transport
    {
        public override int speed2() { return speed; }
        public override int distance2() { return load_capacity; }
        public override int load_capacity2() { return distance; }
    }

    class Volkswagen: Car
    {
        public override int speed { get; set; }
        public override int load_capacity { get; set; }
        public override int distance { get; set; }

        public override int speed2()
        {
            Console.Write("скорость вольсвагена: ");
            return speed;
            
        }
        public override int load_capacity2()
        {
            Console.Write("грузоподъемность вольсвагена: ");
            return load_capacity;
        }

        public override int distance2()
        {
            Console.Write("дальность расстояния вольсвагена: ");
            return distance;
        }

    }
    class Airplane : Plane
    {
        public override int speed { get; set; }
        public override int load_capacity { get; set; }
        public override int distance { get; set; }

        public override int speed2()
        {
            Console.Write("скорость самолетика: ");
            return speed;

        }
        public override int load_capacity2()
        {
            Console.Write("грузоподъемность самолетика: ");
            return load_capacity;
        }

        public override int distance2()
        {
            Console.Write("дальность расстояния самолетика: ");
            return distance;
        }

    }
    class Titanic : Ship
    {
        public override int speed { get; set; }
        public override int load_capacity { get; set; }
        public override int distance { get; set; }

        public override int speed2()
        {
            Console.Write("скорость титаника: ");
            return speed;

        }
        public override int load_capacity2()
        {
            Console.Write("грузоподъемность титаника: ");
            return load_capacity;
        }

        public override int distance2()
        {
            Console.Write("дальность расстояния титаника: ");
            return distance;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
           Volkswagen volkswagen= new Volkswagen();
            volkswagen.speed = 160;
            
            Console.Write(volkswagen.speed2());
            Console.WriteLine(" км/ч");
            volkswagen.load_capacity= 120;
            Console.Write(volkswagen.load_capacity2());
            Console.WriteLine(" кг");
            volkswagen.distance = 800000;
            Console.Write(volkswagen.distance2());
            Console.WriteLine(" км \n");

            Airplane airplane = new Airplane();
            airplane.speed = 600;
            Console.Write(airplane.speed2());
            Console.WriteLine(" км/ч");
            airplane.load_capacity = 10000;
            Console.Write(airplane.load_capacity2()); 
            Console.WriteLine(" кг");
            airplane.distance = 1000000;
            Console.Write(airplane.distance2());
            Console.WriteLine(" км \n");

            Titanic titanic = new Titanic();
            titanic.speed = 100;
            Console.Write(titanic.speed2());
            Console.WriteLine(" км/ч");
            titanic.load_capacity = 100000;
            Console.Write(titanic.load_capacity2());
            Console.WriteLine(" кг");
            titanic.distance = 100000;
            Console.Write(titanic.distance2());
            Console.WriteLine(" км \n");

        }
    }
}