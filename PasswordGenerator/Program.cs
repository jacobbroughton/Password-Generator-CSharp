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

        // Prompt
        public void Prompt()
        {
            int charNum;
            string pAlph;
            string pNum;
            string pSym;
            bool alphComplete;
            bool numComplete;
            bool symComplete;

            (int, string, string, string) InnerPrompt ()
            {
                Console.Write("How many characters in the password? ");
                charNum = Convert.ToInt32((Console.ReadLine()));

                Console.Write("Alphabet characters? (y/n) ");
                pAlph = Console.ReadLine();

                Console.Write("Integers? (y/n) ");
                pNum = Console.ReadLine();

                Console.Write("Symbols? (y/n) ");
                pSym = Console.ReadLine();

                return (charNum, pAlph, pNum, pSym);
            }
            InnerPrompt();

            alphComplete = (pAlph == "y" || pAlph == "n") ? true : false;
            numComplete = (pNum == "y" || pNum == "n") ? true : false;
            symComplete = (pSym == "y" || pSym == "n") ? true : false;

            Program p = new Program();

            if(alphComplete && numComplete && symComplete)
            {
                p.Randomize(charNum, pAlph, pNum, pSym);
            } else
            {
                InnerPrompt();
            }
            
        }


        // Randomize
        public void Randomize(int charNum, string alphSig, string numSig, string symSig)
        {
            Random random = new Random(); // Creates random object

            int randomNumInt = random.Next(); // 10 digit randomized int
            string randomNumStr = randomNumInt.ToString(); 
            string alphStr = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string symbolsStr = "{}_-!?[]";
            string combinedStr = "";

            if ( alphSig == "y" ) { combinedStr += alphStr; };
            if ( numSig == "y" ) { combinedStr += randomNumStr; };
            if ( symSig == "y" ) { combinedStr += symbolsStr; };

            string randomStr = "";
            for(int i = 0; i < charNum; i++)
            {
                int matchingRand = random.Next(0, combinedStr.Length);
                randomStr += combinedStr[matchingRand];
            }
            Console.WriteLine("------------------");
            Console.WriteLine(" PASSWORD GENERATED");
            Console.WriteLine("------------------");
            Console.WriteLine(" " + randomStr);
            Console.WriteLine("------------------");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Prompt();
        }
    }
}