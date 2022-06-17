using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject
{

    class bank
    {
        int acc_no, bal;
        String type, name;
        public void accept()
        {
            Console.WriteLine("Enter the Account number");
            acc_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Holders Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account type: ");
            type = Console.ReadLine();
            Console.WriteLine("Enter Balance: ");
            bal = int.Parse(Console.ReadLine());
        }
        public void display()
        {
            this.accept();
            Console.WriteLine("Account Number:"+acc_no+"\nName:"+name+"\nAccount Type: "+type+"\nBalance: "+bal);
        }

        public void withdraw()
        {
            Console.WriteLine("Ente The amount you want to withdraw: ");
            int amt = int.Parse(Console.ReadLine());
            Console.WriteLine("Updated Balance: "+(bal-amt));
        }
        public void deposit()
        {
            Console.WriteLine("Enter the amount you want to deposit: ");
            int amt = int.Parse(Console.ReadLine());
            Console.WriteLine("Updated Balance: "+(bal+amt));
        }
    }
    class bankconstr
    {
        static void Main(string[] args)
        {
            bank b = new bank();
            b.display();

            Console.WriteLine("\n\nYou want to deposit or Withdraw(d/w):");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'd' || ch == 'D')
                b.deposit();
            else if (ch == 'w' || ch == 'W')
                b.withdraw();

        }
    }
}
