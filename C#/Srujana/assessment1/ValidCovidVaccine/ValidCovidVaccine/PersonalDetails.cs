using System;

namespace ValidCovidVaccine
{
    class PersonalDetails
    {
        string _name;
        string _aadharnum;
        int _age;
        string _gender;

        public PersonalDetails(string Name,string Aadharnum,int Age, string Gender)
        {
            this._name=Name;
            this._aadharnum=Aadharnum;
            this._age=Age;
            this._gender = Gender;
        }

        public void Eligible(string Name, string Aadharnum, int Age, string Gender)
        {
            if (Gender == "female")
            {
                Console.WriteLine("Are You Pregnant yes or no?");
                string pregnant = Console.ReadLine();
                if (pregnant == "yes")
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
                    goto ageCheck;
                }
            }
            else
            {
                goto ageCheck;
            }
            ageCheck:

                if (Age < 18)
                {
                    Console.WriteLine("{0} is not eligible for vaccine", Name);
                }
                else if (Age >= 18 && Age <= 45)
                {
                    Console.WriteLine("{0} is eligible for Covi Shield", Name);
                }
                else
                {
                    Console.WriteLine("{0} is eligible for Covaxin ", Name);
                }
        }
    }
}