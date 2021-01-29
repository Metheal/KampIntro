using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    public class Citizen : Player
    {
        public override int ID { get; set; }
        public override string FirstName { get; set; }
        public override string LastName { get; set; }
        public override DateTime DateOfBirth { get; set; }
        public override string NationalityID { get; set; }
        public override string Nationality { get { return "Turkey"; } set { } }
        public override int Points { get; set; }
        public override double Wallet { get; set; }
    }
}
