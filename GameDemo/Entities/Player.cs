using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    public abstract class Player
    {
        public virtual int ID { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual DateTime DateOfBirth { get; set; }
        public virtual string NationalityID { get; set; }
        public virtual string Nationality { get; set; }
        public virtual int Points { get; set; }
        public virtual double Wallet { get; set; }
    }

}
