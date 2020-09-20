using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_the_User
{
    class Program
    {
        public static void Main(string[] args)
        {
            int yob;
            int mob;
            int dob;
            //read the date[year,month and day from the user]
            //read each of them seperately
            Console.WriteLine("Enter your Date of Birth : -(DD/MM/YYYY) ");
            Console.WriteLine("Enter your Year of Birth ");
            yob = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your month of Birth ");
            mob = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Day  of Birth ");
            dob = Convert.ToInt32(Console.ReadLine());

            int rcode = BirthDate(yob, mob, dob);
            switch (rcode)
            {
                case 0:
                    Console.WriteLine("Hey you are born today");
                    break;
                case 1: Console.WriteLine("You have entered a Future Date");
                    break;
                case 2: Console.WriteLine("You are lucky to have born today");
                    break;
                default: Console.WriteLine("Your date of birth" + rcode);
                    if ((TodayBirthday(mob, dob)))
                        Console.WriteLine("Happy Birthday");
                    break;
                   
            }
            Console.ReadLine();

        }
        private static string DisplaySign(int mob,int dob, int yob)
        {
            switch (mob)
            {
                case 1:
                    if(dob <= 20)
                    {
                        return "Capricorn";
                    }
                    else
                    {
                        return "Aquarius";
                    }
                case 2:
                    if (dob <= 18)
                    {
                        return "Aquarius";
                    }
                    else
                    {
                        return "Piseces";
                    }
                case 3:
                    if (dob <= 20)
                    {
                        return "Piseces";
                    }
                    else
                    {
                        return "Aries";
                    }
                default: return "Null";
                    
            }
        }
        private static bool TodayBirthday(int mob,int dob)
        {
            DateTime tdy = DateTime.Today;
            if (mob == tdy.Month && dob == tdy.Day)
            {
                return true;
            }
            else
                return false;
        }

        private static int BirthDate(int yob, int mob, int dob)
        {

            DateTime bDate = new DateTime(yob, mob, dob);
            DateTime tDate = DateTime.Today;
            int rvalue = DateTime.Compare(bDate, DateTime.Now);
            if (rvalue < 0)
            {
                if ((tDate.Year - bDate.Year) >= 135)
                    return 2;
                else if ((tDate.Year - bDate.Year) == 0)
                    return -1;
                else
                    return (tDate.Year - bDate.Year);
            }
            else if(rvalue > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            throw new NotImplementedException();
            }
        }
    }

    
    
    

          
     

