using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace LindenCafe_BalsecenAda_KasperJamie
{
    class CafeGame
    {
        private int money { get; set; }
        private int cafeLevel { get; set; }
        private List<Customer> customers = new List<Customer>();
        private List<Table> tables = new List<Table>();

        private CafeGame()
        {
            money = 100;
            cafeLevel = 1;
        }

        private CafeGame(int money, int cafeLevel)
        {
            this.money = money;
            this.cafeLevel = cafeLevel;
        }

        public void StartGame()
        {
            Table table1 = new Table();
            tables.Add(table1);
            Table table2 = new Table();
            tables.Add(table2);
            Table table3 = new Table();
            tables.Add(table3);
        }
        public void SpawnCustomer()
        {
            Customer customer = new Customer();
            customers.Add(customer);

        }

        public void AddMoney(int amount)
        {
            money += amount;

        }
        public void UpgradeCafe()
        {
            if (money > 200)
            {
                money -= 200;
                cafeLevel = cafeLevel + 1;

            }
            else
            {
                Console.WriteLine("Du hast nicht genügend Geld für ein Upgrade!");
            }

        }
        public void Output()
        {
            Console.WriteLine($"Cafe level: {cafeLevel}");
            Console.WriteLine($"Money amount: {money}");
        }




    }


}
