using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingAssessment.Refactor
{
    /// <summary>
    /// refernce type used to hold person specific details like Name and DOB
    /// </summary>
    public class People
    {
        private static readonly DateTimeOffset Under16 = DateTimeOffset.UtcNow.AddYears(-15);

        /// <summary>
        /// Name of the person
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// DOB of the person
        /// </summary>
        public DateTimeOffset DOB { get; private set; }

        /// <summary>
        /// creating people object for the given name
        /// </summary>
        /// <param name="name">name</param>
        public People(string name) : this(name, Under16.Date)
        {
        }
        /// <summary>
        /// creating people object for the given name and DOB 
        /// </summary>
        /// <param name="name">person name</param>
        /// <param name="dob">person date of birth</param>
        public People(string name, DateTime dob)
        {
            Name = name;
            DOB = dob;
        }
    }

    /// <summary>
    /// Contains methods related persons
    /// </summary>
    public class BirthingUnit
    {
        /// <summary>
        /// MaxItemsToRetrieve
        /// </summary>
        private List<People> _people;

        public BirthingUnit()
        {
            _people = new List<People>();
        }

        /// <summary>
        /// Retrive Top/Bottom j peoples
        /// </summary>
        /// <param name="j">Top/Bottom j items</param>
        /// <returns>collection of People type</returns>
        public List<People> GetPeople(int i)
        {
            var random = new Random();
            for (int j = 0; j < i; j++)
            {
                try
                {
                    // Creates a dandon Name
                    string name = string.Empty;
                    name = random.Next(0, 1) == 0 ? "Bob" : "Betty";                   
                    // Adds new people to the list
                    _people.Add(new People(name, DateTime.UtcNow.Subtract(new TimeSpan(random.Next(18, 85) * 356, 0, 0, 0))));
                }
                catch (Exception e)
                {
                    // Dont think this should ever happen
                    throw new Exception(ApplicationConstants.ERROR_MESSAGE);
                }
            }
            return _people;
        }

        /// <summary>
        /// return collection of persons whose age is greater than 30
        /// </summary>
        /// <param name="name">person name</param>
        /// <param name="olderThan30"></param>
        /// <returns></returns>
        private IEnumerable<People> GetNames(string name,bool olderThan30)
        {
            return olderThan30 ? _people.Where(x => x.Name == name && x.DOB >= DateTime.Now.Subtract(new TimeSpan(30 * 356, 0, 0, 0))) : _people.Where(x => x.Name == name);
        }

        /// <summary>
        /// fetch the person new name after appending last name to the existing name
        /// </summary>
        /// <param name="p">person</param>
        /// <param name="lastName">person last name</param>
        /// <returns>person new name after appending last name</returns>
        public string GetMarried(People p, string lastName)
        {
            //null check
            if (lastName.Contains(ApplicationConstants.DEFAULT_PERSON_LASTNAME))
                return p.Name;
            if ((p.Name.Length + lastName).Length > ApplicationConstants.PERSON_NAME_LIMIT_LENGTH)
            {
                (p.Name + " " + lastName).Substring(0, ApplicationConstants.PERSON_NAME_LIMIT_LENGTH);
            }

            return p.Name + " " + lastName;
        }
    }

    /// <summary>
    /// Application specific constants
    /// </summary>
    public class ApplicationConstants
    {
        public const string ERROR_MESSAGE = "Something failed in user creation";
        public const string DEFAULT_PERSON_LASTNAME = "test";
        public const int PERSON_NAME_LIMIT_LENGTH = 255;
    }
}