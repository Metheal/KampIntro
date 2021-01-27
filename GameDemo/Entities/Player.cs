using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    public abstract class Player : IEntity
    {
        public abstract int ID { get; set; }
        public abstract string FirstName { get; set; }
        public abstract string LastName { get; set; }
        public abstract DateTime DateOfBirth { get; set; }
        public abstract string NationalityID { get; set; }
        public abstract string Nationality { get; set; }
        public abstract int Points { get; set; }
    }

}
