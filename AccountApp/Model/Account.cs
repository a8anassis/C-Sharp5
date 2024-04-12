
using AccountApp.Exceptions;

namespace AccountApp.Model
{
    internal class Account
    {
        public long Id { get; set; }
        public string? Iban { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Ssn { get; set; }
        public decimal Balance { get; set; }

        public Account()
        {
                
        }

        public Account(long id, string? iban, string? firstname, string? lastname, 
            string? ssn, decimal balance)
        {
            Id = id;
            Iban = iban;
            Firstname = firstname;
            Lastname = lastname;
            Ssn = ssn;
            Balance = balance;
        }

        public override string? ToString() =>
            $"{{ {Id}\t{Iban}\t{Firstname}\t{Lastname}\t{Ssn}\t{Balance} }}";

        // Public API

        /// <summary>
        /// Deposits an amount of money to the <see cref="Account" />
        /// </summary>
        /// <param name="amount">A certain amount of money.</param>
        public void Deposit(decimal amount)
        {
            try
            {
                if (amount < 0) throw new NegativeAmountException("Error Amount cannot be negative");
                Balance += amount;
            } catch (NegativeAmountException e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Withdraws an amount of money from the <see cref="Account" />
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="ssn"></param>
        public void Withdraw(decimal amount, string ssn)
        {
            try
            {
                if (string.IsNullOrEmpty(ssn)) throw new InvalidSsnException(ssn);
                if (Ssn != ssn) throw new InvalidSsnException(ssn);
                if (amount < 0) throw new NegativeAmountException("Error Negative");
                if (amount > Balance) throw new InsufficientAmountException("");
                Balance -= amount;
            } catch (NegativeAmountException e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            } catch (InsufficientAmountException e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            } catch (InvalidSsnException e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Returns the balance of the  <see cref="Account" />
        /// </summary>
        /// <returns>The amount of money the account balance holds.</returns>
        public decimal GetBalance()
        {
            return Balance;
        }
       
    }
}
