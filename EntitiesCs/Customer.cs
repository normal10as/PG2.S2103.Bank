using System;

namespace EntitiesCs
{
    public class Customer
    {
        public Customer()
        {
            Name = "";
            Dni = 0;
            BirthDay = null;
        }
        public Customer(string Name, int Dni)
        {
            this.Name = Name;
            this.Dni = Dni;
            BirthDay = null;
        }
        public Customer(string Name, int Dni, DateTime BirthDate)
        {
            this.Name = Name;
            this.Dni = Dni;
            this.BirthDay = BirthDate;
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value.ToUpper();
            }
        }
        private int dni;
        public int Dni { get => dni; set => dni = value; }
        private DateTime? birthDay;
        public DateTime? BirthDay
        {
            get
            {
                return birthDay;
            }
            set
            {
                birthDay = value;
            }
        }
    }
}
