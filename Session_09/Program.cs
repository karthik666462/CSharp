using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable
            //string fName = "Fees";
            //string lName = "Worth";

            //Console.WriteLine(fName);
            //Console.WriteLine(lName);

            #region 1-D Array

            // Creating an Array

            //String[] insName = { "Karthik", "Ravi", "Harsha" };

            //for (int index = 0; index < insName.Length; index++)
            //{
            //    Console.WriteLine(insName[index]);
            //}

            //5 Students


            string[] studentsname = new string[5];

            studentsname[0] = "A";
            studentsname[1] = "B";
            studentsname[2] = "C";
            studentsname[3] = "D";
            studentsname[4] = "E";

            for (int index = 0; index < studentsname.Length; index++)
            {
                studentsname[index] = studentsname[index];
            }


            #endregion
           
            Console.ReadKey();


        }
    }
}
