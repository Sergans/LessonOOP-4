using System;

namespace LessonOOP_4_1
{
    public class Building
    {
        private int Nomber;
        private int Floor;
        private int Entrance;
        private int Apartment;
        private float Height; 
        private static int unicNomber; 
        public Building(int floor,int entrance,int apartment,float height)
        {
            this.Floor = floor;
            this.Entrance = entrance;
            this.Apartment = apartment;
            this.Height = height;
            this.Nomber = ++unicNomber;

        }
        public float GetHeightFloor()
        {
            return this.Height / this.Floor;
        }
        public int GetApartmentInEntrance()
        {
            return this.Apartment / this.Entrance;
        }
        public int GetApartmentInFloor()
        {
            int apartmentInentance = GetApartmentInEntrance();
            return apartmentInentance / this.Floor;
        }
        public void Print()
        {
            Console.WriteLine(
            $"Номер здания- {this.Nomber}\r\n" +
            $"Этажность- {this.Floor}\r\n" +
            $"Количество подъездов- {this.Entrance}\r\n" +
            $"Количество квартир- {this.Apartment}\r\n" +
            $"Высота здания- {this.Height} метров");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Building building1 = new Building(5, 3, 48, 13);
            Building building2 = new Building(5, 3, 50, 10);
            building1.Print();
            Console.WriteLine();
            building2.Print();
            Console.WriteLine(building1.GetHeightFloor());
            Console.WriteLine(building1.GetApartmentInEntrance());
            Console.WriteLine(building1.GetApartmentInFloor());
        }
    }
}
