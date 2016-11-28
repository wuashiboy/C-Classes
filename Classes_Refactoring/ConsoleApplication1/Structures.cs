﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Refactoring
    {
    public class Structures
    {
        public string Name { get; set; }
        public string BldType { get; set; }
        public string ContrucitonMaterial { get; set; }
        public int NumberOfRoom { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double Squarefootage
        {
            get { return Length * Width; }
        }

        public int Floors { get; set; }
        public int Bathrooms { get; set; }
        public double Volume
        {
            get { return Length * Width * Height; }
        }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set;}
        public string State { get; set; }
        public int Zip { get; set; }
        public string FullAddress
        {
            get { return ($" {Address1}, {Address2},  {City}, {State}, {Zip}"); }
        }

        public Structures()
        {
            this.Name = Name;
            this.BldType = BldType;
            this.NumberOfRoom = 0;
            this.Height = 0;
            this.Width = 0;
            this.Length = 0;
            this.Floors = 0;
            this.Bathrooms = 0;
            this.Address1 = Address1;
            this.Address2 = Address2;
            this.City = City;
            this.State = State;
            this.Zip = Zip;
        }
        public int IncreaseOccupants(int CurrentOccupants)
        {
            return CurrentOccupants++;
        }

        public int DecreaseOccupants(int CurrentOccupants)
        {
            return CurrentOccupants--;
        }
    }

}