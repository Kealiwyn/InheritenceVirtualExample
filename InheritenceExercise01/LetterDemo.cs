using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceExercise01
{
    class LetterDemo
    {
        static void Main(string[] args)
        {
            Letter myLetter = new Letter("Bob", "2021-03-25");
            CertifiedLetter anotherTry = new CertifiedLetter(myLetter, 534534);



            Console.WriteLine(myLetter.ToString());
            Console.WriteLine(anotherTry.ToString());

            Console.ReadKey();
        }
    }

    class MyParentClass
    {
        public virtual string MyName { get; set; }

        private int number;
        public virtual int Number
        {
            get { return number; }
            set { number = value; }
        }
    }

    class MyChildClass : MyParentClass
    {
        private string myName;

        public override string MyName
        {
            get { return myName; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    myName = value;
                }
                else
                {
                    myName = "Patrick";
                }
            }
        }
    }
}
