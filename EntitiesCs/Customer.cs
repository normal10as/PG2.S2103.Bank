using System;

namespace EntitiesCs
{
    public class Customer
    {
        public Customer()
        {
            Name = "";
            Id = 0;
            BirthDay = null;
        }
        public Customer(string Name, int id) : this ()
        {
            this.Name = Name;
            this.Id = id;
            //BirthDay = null;
        }
        public Customer(string name, int id, DateTime BirthDate) : this(name, id)
        {
            //this.Name = name;
            //this.Id = id;
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
        private int id;
        public int Id { get => id; set => id = value; }
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
