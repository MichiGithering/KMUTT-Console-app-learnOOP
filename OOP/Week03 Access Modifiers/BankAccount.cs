using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class BankAccount
    {
        // public: เข้าถึงได้จากทุกที่ (เลขที่บัญชีสาธารณะ)
        public string AccountNumber { get; private set; }

        // protected: เข้าถึงได้ในคลาส BankAccount และคลาสที่สืบทอดไปเท่านั้น (ยอดเงินที่ละเอียดอ่อน)
        protected decimal _balance;

        // internal: เข้าถึงได้เฉพาะใน Assembly เดียวกัน (ธนาคารเดียวกัน) เช่น ข้อมูลสาขา
        internal string BranchId { get; set; }

        // private: เข้าถึงได้เฉพาะในคลาส BankAccount เท่านั้น (รหัสผ่านที่สำคัญ)
        private string _passwordHash;

        // Constructor ของ Base Class
        public BankAccount(string accountNumber, string passwordHash, decimal initialBalance, string branchId)
        {
            AccountNumber = accountNumber;
            _passwordHash = passwordHash;
            _balance = initialBalance;
            BranchId = branchId;
            Console.WriteLine($"Account {AccountNumber} has been created.");
        }

        // public: เมธอดสำหรับฝากเงิน (ทุกคนต้องทำได้)
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount; // สามารถเข้าถึง protected field ได้
                Console.WriteLine($"Deposited {amount:C}. New balance: {_balance:C}");
            }
        }

        // protected: เมธอดสำหรับถอนเงิน (มีไว้ให้คลาสลูกเรียกใช้)
        protected bool Withdraw(decimal amount)
        {
            if (amount > 0 && _balance >= amount)
            {
                _balance -= amount;
                Console.WriteLine($"Withdrew {amount:C}. New balance: {_balance:C}");
                return true;
            }
            Console.WriteLine("Insufficient funds or invalid amount.");
            return false;
        }

        // private: เมธอดสำหรับตรวจสอบรหัสผ่าน
        private bool VerifyPassword(string password)
        {
            // ในความเป็นจริงจะมีการ Hash password
            return password == _passwordHash;
        }

        // public: เมธอดที่ใช้เรียก private method จากภายนอก
        public bool CheckPassword(string password)
        {
            return VerifyPassword(password);
        }
    }
}
