using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    public class ValidationException : Exception
    {
        public ValidationException(string message):base(message) 
        {
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the User Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Password");
                string passWord = Console.ReadLine();
                Console.WriteLine("Enter the Email Id");
                string email = Console.ReadLine();
                if(name.Length>6 && passWord.Length > 8)
                {
                    Console.WriteLine("User Registration is Successfull");
                    Console.WriteLine(name);
                    Console.WriteLine(email);
                    Console.WriteLine(passWord);
                }
                else
                {
                    throw new ValidationException("The given input doesn't have required properties to validate");
                }
            }
            catch(ValidationException ve)
            {
                Console.WriteLine(ve.Message);
            }
            catch (Exception ve)
            {
                Console.WriteLine(ve.Message);
            }
            finally
            {
                Console.WriteLine("End of the user registration process");
            }
        }
    }
}
