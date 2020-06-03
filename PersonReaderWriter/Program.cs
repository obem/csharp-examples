using PersonReaderWriter.models;
using System;
using System.Collections.Generic;
using System.IO;

namespace PersonReaderWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();
            /*
             * read all person lines to a string Array
             * personLinesFromFile[0] ==> "Hans;43;Dornbirn"
             */
            string[] personLinesFromFile = File.ReadAllLines("C:\\CC\\persons.txt");
            
            /*
             * iterate each person - line
             */
            foreach(var personLine in personLinesFromFile)
            {
                /*
                 * split lines to columns
                 * personColumns[0] ==> "Hans"
                 * personColumns[1] ==> "43"
                 */
                string[] personColumns = personLine.Split(";");

                /*
                 * initializes a new field age with the value of tryParse from the input
                 */
                int.TryParse(personColumns[1], out var age);

                /*
                 * creates a person object and set the job
                 * property with an "if - clause"
                 */
                Person person = new Person()
                {
                    Name = personColumns[0],
                    Age = age,
                    City = personColumns[2],
                    Job = personColumns[0] == "Hans" || personColumns[0] == "Helga" ? "Coder" : "Officer"
                };

                personList.Add(person);
            }

            List<string> outputList = new List<string>();

            /*
             * iterates the modified person objects
             */
            foreach(var person in personList)
            {
                /*
                 * format the output string for the new file
                 */
                outputList.Add($"{person.Name};{person.Age};{person.City};{person.Job}");
                //outputList.Add(person.Name + ";" + person.Age + ";" + person.City + ";" + person.Job);
            }

            /*
             * write all output strings
             */
            File.WriteAllLines("C:\\CC\\persons1.txt", outputList);
        }
    }
}
