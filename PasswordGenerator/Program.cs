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

        public void Randomize()
        {
            Random random = new Random(); // Creates random object
            ArrayList alphList = new ArrayList();
            ArrayList numList = new ArrayList();

            int randomNumInt = random.Next(); // 10 digit randomized int
            string randomNumStr = randomNumInt.ToString(); 
            string alph = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string alphNumCombo = randomNumStr + alph;
            Console.WriteLine(alphNumCombo);
            char[] alphArr = alph.ToCharArray();

            alphList.Add(alph);
            numList.Add(randomNumStr);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Randomize();
        }
    }
}