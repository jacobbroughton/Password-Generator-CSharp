using System;
using System.Collections;
using System.Collections.Generic;

// Add ability to continually get new passwords, rather than having to close out.
// Add ability to choose length of password
// Add ability to add or remove numbers, letters, or symbols


namespace PasswordGenerator
{
    class Program
    {

        public void Prompt()
        {
            Console.WriteLine("--------------------");
            Console.Write("Alphabet characters? (y/n) ");
            string pAlph = Console.ReadLine();
            Console.WriteLine("--------------------");
            Console.Write("Integers? (y/n) ");
            string pNum = Console.ReadLine();
            Console.WriteLine("--------------------");
            Console.Write("Symbols? (y/n) ");
            string pSym = Console.ReadLine();
            Console.WriteLine("--------------------");
            Console.WriteLine("--------------------");
            Console.WriteLine("--------------------");

            Program p = new Program();
            p.Randomize(pAlph, pNum, pSym);
        }

        public void Randomize(string alphSig, string numSig, string symSig)
        {
            Random random = new Random(); // Creates random object
            List<char[]> charList = new List<char[]>();

            int randomNumInt = random.Next(); // 10 digit randomized int
            string randomNumStr = randomNumInt.ToString(); 
            string alph = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string symbols = "{}_-!?[]";
            char[] alphArr = alph.ToCharArray();
            char[] numArr = randomNumStr.ToCharArray();
            char[] symbolArr = symbols.ToCharArray();

            charList.Add(alphArr);
            charList.Add(numArr);
            charList.Add(symbolArr);

           for(int i = 0; i < charList.Count; i++)
            {
                Console.WriteLine(charList[i]);
            }

           Console.WriteLine(alphSig);
            Console.WriteLine(numSig);
            Console.WriteLine(symSig);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Prompt();
            //p.Randomize();
        }
    }
}