using System;

namespace LessonOOP_4_1
{
    public class Building
    {
        string messagefloor;
        string messageentrance;
        string messageapartment;
        string messageheight;
        private int Nomber;
        private int Floor=1;
        private int Entrance=1;
        private int Apartment=1;
        private float Height=5; 
        private static int unicNomber; 
        //public Building(int floor,int entrance,int apartment,float height)
        //{
        //    this.Floor = floor;
        //    this.Entrance = entrance;
        //    this.Apartment = apartment;
        //    this.Height = height;
        //    this.Nomber = ++unicNomber;

        //}
        public void CreateBuilding(int floor, int entrance, int apartment, float height)
        {
            //string messagefloor;
            //string messageentrance;
            //string messageapartment;
            //string messageheight;
            this.Nomber = ++unicNomber;
            if (floor >0)
            {
                messagefloor = "";
                this.Floor = floor;
                
            }
            else
            {
                messagefloor = "(Этажность должна быть больше 0, присвоено значение 1 по умолчанию)";
                
            }
            if (entrance != 0)
            {
                this.Entrance = entrance;
            }
            else
            {
                messageentrance= "(Количество подъездов должно быть больше 0, присвоено значение 1 по умолчанию)";
               
            }
            if (apartment != 0)
            {
                this.Apartment = apartment;
            }
            else
            {
                messageapartment = "(Количество квартир должно быть больше 0, присвоено значение 1 по умолчанию)";
            }
            if (height >= 5)
            {
                this.Height = height;
                messageheight = "Метров";
            }
            else
            {
                messageheight = "(Высота здания должна быть больше 5 метров, присвоено значение 1 по умолчанию)";
            }

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
            $"Этажность- {this.Floor} {messagefloor}\r\n" +
            $"Количество подъездов- {this.Entrance} {messageentrance}\r\n" +
            $"Количество квартир- {this.Apartment} {messageapartment}\r\n" +
            $"Высота здания- {this.Height} {messageheight}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Building building1 = new Building();
            building1.CreateBuilding(0, 0, 50, 4);
           // Building building2 = new Building(5, 3, 50, 10);
            building1.Print();
            Console.WriteLine();
           // building2.Print();
            Console.WriteLine(building1.GetHeightFloor());
            Console.WriteLine(building1.GetApartmentInEntrance());
            Console.WriteLine(building1.GetApartmentInFloor());
        }
    }
}
