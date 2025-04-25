using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaKolokvijum1Recap
{
    internal class Program
    {
        public interface IAccount
        {
            void WithhdrawFromTheAccount(double amount);
            void DepositIntoTheAccount(double amount);
            string GetAccountData();
            double GetAccountAmount();
        }

        public abstract class CommonAccount: IAccount
        {
            private double amount;
            private string accountNumber;

            public CommonAccount(string accountNumber, double amount)
            {
                this.accountNumber = accountNumber;
                this.amount = amount;
            }
            public CommonAccount(string accountNumber): this(accountNumber, 0)
            {

            }
            public void WithhdrawFromTheAccount(double amount)
            {
                this.amount -= amount + ApplyCommissionOnWithdraw(amount);
            }

            public void DepositIntoTheAccount(double amount)
            {
                this.amount += amount - ApplyCommissionOnDeposit(amount);
            }

            public virtual string GetAccountData()
            {
                string data = $"Account number: {this.accountNumber} has value of ${this.amount}";
                return data;
            }

            public double GetAccountAmount()
            {
                return this.amount;
            }

            protected abstract double ApplyCommissionOnWithdraw(double amount);
            protected abstract double ApplyCommissionOnDeposit(double amount);
        }

        public class CurrentAccount: CommonAccount
        {
            public CurrentAccount(string accountNumber): base(accountNumber)
            {

            }

            public CurrentAccount(string accountNumber, double amount): base(accountNumber, amount)
            {

            }

            protected override double ApplyCommissionOnWithdraw(double amount)
            {
                return amount * 0.015;
            }

            protected override double ApplyCommissionOnDeposit(double amount)
            {
                return 0;
            }

            public override string GetAccountData()
            {
                return base.GetAccountData() + $"Account Type: CURRENT ACCOUNT";
            }
        }

        public class ForeignAccount: CommonAccount
        {
            public ForeignAccount(string accountNumber): base(accountNumber)
            {

            }

            public ForeignAccount(string accountNumber, double amount): base(accountNumber, amount)
            {

            }

            protected override double ApplyCommissionOnWithdraw(double amount)
            {
                return amount * 0.010;
            }

            protected override double ApplyCommissionOnDeposit(double amount)
            {
                return 0;
            }

            public override string GetAccountData()
            {
                return base.GetAccountData() + $"Account Type: FOREIGN ACCOUNT";
            }
        }

        static void Main(string[] args)
        {
            CommonAccount[] accounts = new CommonAccount[4];
            accounts[0] = new CurrentAccount("205-001");
            accounts[1] = new CurrentAccount("205-002");
            accounts[2] = new ForeignAccount("180-001");
            accounts[3] = new ForeignAccount("180-002");

            for (int i = 0; i < accounts.Length; i++)
            {
                Console.WriteLine($"This is all about account number: {i + 1}");
                accounts[i].DepositIntoTheAccount(1000);
                accounts[i].WithhdrawFromTheAccount(500);
                Console.WriteLine(accounts[i].GetAccountAmount());
                Console.WriteLine(accounts[i].GetAccountData());
                Console.WriteLine();
            }
        }
    }
}
