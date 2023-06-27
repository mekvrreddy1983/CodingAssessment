using System;
using System.Collegctions.Generic;
using System.Linq;

namespace Utility.Valocity.ProfileHelper
{
    //need to provide description for the class People
    public class People
    {
    //need to provide provide description for each bpropertie, each parameterised constructor
     private static readonly DateTimeOffset Under16 = DateTimeOffset.UtcNow.AddYears(-15);
     public string Name { get; private set; }
     public DateTimeOffset DOB { get; private set; }
     public People(string name) : this(name, Under16.Date) { }
     public People(string name, DateTime dob) {
         Name = name;
         DOB = dob;
     }}

    //need to provide description for the class BirthingUnit
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

        //need to provide method description and also input parameters description and also return type description
        /// <summary>
        /// GetPeoples
        /// </summary>
        /// <param name="j"></param>
        /// <returns>List<object></returns>
        public List<People> GetPeople(int i)
        {
            //use proper naming for the variable
            for (int j = 0; j < i; j++)
            {
                try
                {
                    // Creates a dandon Name
                    string name = string.Empty;
                    /*
                     move this instance creation above for loop to avoid to create instance each iteration
                     code will never execute else block
                     hard coded values should be moved to application contant file
                    */
                    var random = new Random();
                    if (random.Next(0, 1) == 0) {
                        name = "Bob";
                    }
                    else {
                        name = "Betty";
                    }
                    // Adds new people to the list
                    _people.Add(new People(name, DateTime.UtcNow.Subtract(new TimeSpan(random.Next(18, 85) * 356, 0, 0, 0))));
                }
                catch (Exception e)
                {
                    //while thorwing user defined exception we are missing stack trace and actual error details 
                    // Dont think this should ever happen
                    throw new Exception("Something failed in user creation");
                }
            }
            return _people;
        }

        /*need to provide method description and also input parameters description and also return type description
         method should take one new parameter(Name) as input that is going to used to apply the filter on Name propertie
         hard coded values should be moved to applicarion constant file
        */
        private IEnumerable<People> GetBobs(bool olderThan30)
        {
            return olderThan30 ? _people.Where(x => x.Name == "Bob" && x.DOB >= DateTime.Now.Subtract(new TimeSpan(30 * 356, 0, 0, 0))) : _people.Where(x => x.Name == "Bob");
        }

        //need to provide method description and also input parameters description and also return type description
        public string GetMarried(People p, string lastName)
        {
            /* 
             null check to be done before accesing propertie
             hard coded values to be moved to some application constant file
             */
            if (lastName.Contains("test"))
                return p.Name;
            if ((p.Name.Length + lastName).Length > 255)
            {
                (p.Name + " " + lastName).Substring(0, 255);
            }

            return p.Name + " " + lastName;
        }
    }
}