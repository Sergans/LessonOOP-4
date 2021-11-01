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
        public void CreateBuilding(int floor, int entrance, int apartment, float height)
        {
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
            $"Высота здания- {this.Height} {messageheight}\r\n" +
            $"Высота этажа-{GetHeightFloor()}\r\n" +
            $"Количество квартир в подъезде-{GetApartmentInEntrance()}\r\n" +
            $"Количество квартир на этаже-{GetApartmentInFloor()}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Building building1 = new Building();
            building1.CreateBuilding(5, 3, 48, 24);
            building1.Print();
           
        }
    }
}
