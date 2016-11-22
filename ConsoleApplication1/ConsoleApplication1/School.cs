using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class School
    {
        public string Name { get; set; }
        public string BldType { get; set; }
        public string ConstructionMaterial { get; set; }
        public int NumberOfRoom { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double squarefootage
        {
            get { return Length * Width; }
        }

        public int Floors { get; set; }
        public int Classrooms { get; set; }
        public int Bathrooms { get; set; }
        public double Volume
        {
            get { return Length * Width * Height; }
        }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }

        public string FullAddress
        {
            get { return ($" {Address1}, {Address2},  {City}, {State}, {Zip}"); }
        }

        public int Occupants
        {
            get { return Occupants; }

        }

        public int NumberOfStudent { get; set; }
        public Boolean InSession { get; set; }
        public int NumberOfTeacher { get; set; }

        public School()
        {

            this.Name = Name;
            this.BldType = BldType;
            this.NumberOfRoom = 0;
            this.Height = 0;
            this.Width = 0;
            this.Length = 0;
            this.Floors = 0;
            this.Classrooms = 0;
            this.Bathrooms = 0;
            this.Address1 = Address1;
            this.Address2 = Address2;
            this.City = City;
            this.State = State;
            this.Zip = Zip;
            this.NumberOfStudent = 0;
            this.InSession = true;
            this.NumberOfTeacher = 0;


        }
        public static int IncreaseOccupants(int CurrentOccupants)
        {
            return CurrentOccupants++;
        }

        public static int DecreaseOccupants(int CurrentOccupants)
        {
            return CurrentOccupants--;
        }

        public void TeacherStudentRatio (int NumberOfTeacher, int NumberOfStudent)
        {
            Console.WriteLine($"{NumberOfTeacher} : {NumberOfStudent}");
        }
   }
}
