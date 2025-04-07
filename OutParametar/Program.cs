using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParametar
{

    internal class Program
    {
        static string ReturnMultipleParameters(string firstname, string lastname, out int experience, int company1, int company2)
        {
            string fullName = firstname + " " + lastname;
            experience = company1 + company2;

            return fullName;
        }

        static void Main(string[] args)
        {
            int experience;

            string multipleParametersResult = ReturnMultipleParameters("Darko", "Pokoracki", out experience, 4, 4);

            Console.WriteLine(experience);
        }
    }
}
