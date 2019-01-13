using CalCalTracker.Domain.Base;
using System;
namespace CalCalTracker.Domain
{
    public abstract class User : CalCalEntity
    {
        protected Sex _sex;
        protected string _firstName;
        protected string _lastName;
        protected DateTimeOffset _dateOfBirth;
        protected double _weight;
        protected double _height;
        protected int _age;

        private User() { }

        public User(string firstName, string lastName, int? age, double? weight, 
            double? height, DateTimeOffset dateOfBirth) :  base()
        { }




        public string FirstName => _firstName;
        public string LastName => _lastName;
        public DateTimeOffset DateOfBirth => _dateOfBirth;
        public Sex Sex => _sex;
        public double Weight => _weight;
    }
}
