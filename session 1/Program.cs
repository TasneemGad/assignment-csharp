using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace session_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ASSIGNMENT 1
            // Task 1
            BankAccount account = new BankAccount(5000000000);

            account.Deposit(3000);
            account.Withdraw(300);
            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"Balance: {account.Balance}");

            // Task 2
            Product product = new Product();

            product.Price = -20;
            product.Price = 20;

            product.StockQuantity = -20;
            product.StockQuantity = 20;
            Console.WriteLine($"IsAvailable StockQuantity : {product.IsAvailable}");

            // Task 3
            Car car = new Car();
            car.Mileage = 303;
            car.Drive(5000);
            Console.WriteLine($"Mileage  : {car.Mileage}");
            car.Year = 1997;
            Console.WriteLine($"Car age: {car.Age}");



        }
    }
}
