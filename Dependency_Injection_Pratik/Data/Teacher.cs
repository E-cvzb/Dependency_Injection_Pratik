using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Dependency_Injection_Pratik.Data
{
    public class Teacher : ITeacher
    {
        public string FirstName { get ; set; }
        public string LastName { get ; set; }


        public Teacher(string firstname, string lastname) 
        {
            FirstName = firstname;

            LastName = lastname;


        }
        public void GetInfo()
        {
            Console.WriteLine( $"Öğretmen adı {FirstName} {LastName}");
        }



        
    }
}
