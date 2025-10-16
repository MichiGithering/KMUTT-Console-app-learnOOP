using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class SavingsAccount : BankAccount
    {
        // public: อัตราดอกเบี้ย
        public decimal InterestRate { get; set; }

        // Constructor ของ SavingsAccount
        public SavingsAccount(string accountNumber, string passwordHash, decimal initialBalance, string branchId, decimal interestRate)
            : base(accountNumber, passwordHash, initialBalance, branchId)
        {
            InterestRate = interestRate;
            Console.WriteLine($"Savings account {AccountNumber} created with interest rate {InterestRate:P}.");
        }

        // public: เมธอดสำหรับถอนเงินที่ถูกควบคุม
        public void WithdrawFunds(decimal amount, string password)
        {
            if (CheckPassword(password))
            {
                // เรียกใช้ protected method ของ Base Class ได้
                Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Incorrect password. Withdrawal failed.");
            }
        }

        // public: เมธอดเฉพาะของ SavingsAccount
        public void AddMonthlyInterest()
        {
            decimal interest = _balance * InterestRate;
            _balance += interest; // สามารถเข้าถึง protected field ได้
            Console.WriteLine($"Added monthly interest of {interest:C}. New balance: {_balance:C}");
        }
    }
}
