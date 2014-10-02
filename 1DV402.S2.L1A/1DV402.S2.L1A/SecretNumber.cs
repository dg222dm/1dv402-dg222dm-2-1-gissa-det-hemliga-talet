using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    class SecretNumber
    {
        private int _count, _number;
        public const int MaxNumberOfGuesses = 7;

        public void Initialize()
        {
            _count = 0;
            Random randomNumber = new Random();
           _number = randomNumber.Next(1, 101); // tilldelar objektet number ett värde mellan 1-100. Tar fram till det näst sista.
        }

        public bool MakeGuess(int number)
        {
            if (number < 1 || number > 100) // kollar om användarens numme är mindre än 1 eller högre än 100.
            {
                throw new ArgumentOutOfRangeException(); 
            }
            
            if (_count >= MaxNumberOfGuesses)
            {
                throw new ApplicationException();
            }
            
            ++_count;
            
            if (number < _number) // Om gissningen är mindre än det hemliga talet skrivs ett lämpligt meddelande ut.
            {
                Console.WriteLine("{0} är för lågt. Du har {1} gissningar kvar. ", number, (MaxNumberOfGuesses - _count));
                
            }

            else if (number > _number) // Om gissningen är större än det hemliga talet skrivs ett lämpligt meddelande ut.
            {
                Console.WriteLine("{0} är för högt. Du har {1} gissningar kvar.", number, (MaxNumberOfGuesses - _count));
                
            }

            if (number == _number)
            {
                Console.WriteLine("RÄTT GISSAT. Du klarade det på {0} försök.", _count); // Skriver ut lämpligt meddelande om användaren gissar rätt. 
                return true;
            }
            
            if (_count == MaxNumberOfGuesses) // Skriver ut det hemliga talet efter 7 försök.
            {
                Console.WriteLine("Det hemliga talet är {0}", _number);
    
            }
            return false;
        }
        public SecretNumber()
        {
            Initialize();
        }
        
    }
}