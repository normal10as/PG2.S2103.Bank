using System;

namespace EntitiesCs
{
    public class Customer
    {
        public Customer()
        {
            Name = "";
            Dni = 0;
            BirthDate = null;
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
        private DateTime? birthDate;
        public DateTime? BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                birthDate = value;
            }
        }
    }
}
