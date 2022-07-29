using System;

namespace WelcomeMessage
{
    class DispatchServices
    {
 //Welcome Message
        string Message = "We look forward to working with you!";

        private static void Main(string[] args)
        {
            DispatchServices myObj = new DispatchServices();
            Console.WriteLine(myObj.Message);

            {
                //Just type in the numbers
                //Need to figure a way to return error if more than 6 numbers are entered
                Console.WriteLine("What is your MC Number?");
                int mcNumber = int.Parse(Console.ReadLine());
               
                {
                    Console.WriteLine("How many years has your authority been active for?");

                    //Authority needs to be over 2 yo if not return error
                    int authorityAge = Convert.ToInt32(Console.ReadLine());

                    if (authorityAge < 2)
                    {
                        Console.WriteLine(" Unfortunately your authority is not old enough.");

                        Console.WriteLine("If you feel this was a mistake, please type in below any additional information we can use for your reconsideration.");
                        string additionalInfo = Console.ReadLine();
                        int count = additionalInfo.Split(' ').Length;
                    }
                    else if (authorityAge > 2)
                    {
                        Console.WriteLine("Great!");

                        {
 //Get contact details
                            Console.WriteLine("What is your preferred method of contact? Email or Phone?");
                            // Type as is : case sensetive
                            string contactMethod = Console.ReadLine();


                            if (contactMethod == "Email")
                            {
                                Console.WriteLine("Please enter your email address below");
                                string email = Console.ReadLine();
                                Console.WriteLine("We will get back to you at " + email);
                            }
                           // Area code is needed 
                            if (contactMethod == "Phone")
                            {
                                Console.WriteLine("Please enter your phone  number below");
                                   long phoneNumber = long.Parse(Console.ReadLine());
                                Console.WriteLine("We will call you at " + phoneNumber);

 // Ask for insurance information, needs to be able to upload 
 // Credit checks with factoring company
                            }

                        }

                    }

                }

            }
        }
    }
}
