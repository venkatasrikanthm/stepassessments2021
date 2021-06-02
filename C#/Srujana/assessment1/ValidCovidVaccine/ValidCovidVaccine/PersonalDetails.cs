using System;

namespace ValidCovidVaccine
{
    class PersonalDetails
    {
        string _name;
        string _aadharnum;
        int _age;
        string _gender;


        public PersonalDetails(string Name, string Aadharnum, int Age, string Gender)
        {
            this._name = Name;
            this._aadharnum = Aadharnum;
            this._age = Age;
            this._gender = Gender;

        }

        public void Eligible(string Name, string Aadharnum, int Age, string Gender, string pregnant)
        {

            if (Age < 18)
            {
                Console.WriteLine("{0} is not eligible for vaccine", Name);
            }
            else if (Age >= 18 && Age <= 45)
            {
                if (Gender.ToLower() == "female")
                {

                    if (pregnant.ToLower() == "yes")
                    {
                        if (Age >= 30 && Age <= 40)
                        {
                            Console.WriteLine("{0} is eligible for Covaxin", Name);
                        }
                        else
                        {
                            Console.WriteLine("{0} is not eligible for vaccine", Name);
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0} is eligible for CoviShield", Name);
                    }
                }
                else
                {
                    Console.WriteLine("{0} is eligible for CoviShield", Name);
                }
            }
            else if (Age > 45 && Gender.ToLower() == "female" && pregnant.ToLower() == "yes")
            {
                Console.WriteLine("{0} is not eligible for vaccine", Name);
            }
            else
            {
                Console.WriteLine("{0} is eligible for Covaxin", Name);
            }


        }
    }
}