using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Bai8_OOP
{
    internal class Program
    {
        public static List<string> selectProductSeed = new List<string>();
        public static List<Product> product = new List<Product>();
        public static void Menu(Player player)
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine($"User Name: {player.Username}");
                    Console.WriteLine($"Reward: {player.Reward}");
                    foreach (string prd in selectProductSeed)
                    {
                        if (prd != null)
                            Console.WriteLine(prd);
                    }
                    Console.WriteLine("1. Seed \n2. Harvest \n3. Feed \n4. Prov_Water \n0. Exit");
                    Console.Write("Nhập lựa chọn: ");
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            SeedMenu(player);
                            break;
                        case "2":
                            HarvestMenu(player);
                            break;
                        case "3":
                            FeedMenu();
                            break;
                        case "4":
                            ProvWaterMenu();
                            break;
                        case "0":
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Lựa chọn không hợp lệ.");
                            Thread.Sleep(1000);
                            Console.Clear();
                            break;
                    }
                }
                catch (Exception ex) 
                {
                    Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
                    Thread.Sleep(2000);
                }
            }
        }
        public static void SeedMenu(Player player)
        {           
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Chọn cây trồng: ");
                Console.WriteLine("1. Tomato\n2. Sunflower\n3. Wheat\n4. Back");
                foreach (string prd in selectProductSeed)
                {
                    if (prd != null)
                        Console.WriteLine(prd);
                }
                Product productSeed = null;
                string choice = Console.ReadLine();
                if (choice == "4")
                {
                    break;
                }
                switch (choice)
                {
                    case "1":
                        productSeed = new Tomato();
                        break;
                    case "2":
                        productSeed = new Sunflower();
                        break;
                    case "3":
                        productSeed = new Wheat();
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                }
                if (productSeed != null) 
                { 
                    if (player.Reward >= productSeed.Cost)
                    {
                        productSeed.seed();
                        selectProductSeed.Add(productSeed.seed());
                        product.Add(productSeed);
                        Console.WriteLine($"{productSeed.seed()}");
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine("Không đủ điểm thưởng để mua sản phẩm này.");
                        Thread.Sleep(1000);
                    }
                }
            }
        }
        public static void HarvestMenu(Player player)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Chọn cây thu hoạch: ");
                if (product.Count > 0)
                {
                    for (int i = 0; i < product.Count; i++)
                    {
                        if (product[i] is Tomato tomato)
                        {
                            Console.WriteLine($"{i + 1}. Tomato {tomato.Start}");
                        }
                        else if (product[i] is Sunflower sunflower)
                        {
                            Console.WriteLine($"{i + 1}. Sunflower {sunflower.Start}");
                        }
                        else if (product[i] is Wheat wheat)
                        {
                            Console.WriteLine($"{i + 1}. Wheat {wheat.Start}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Chưa trồng cây nào!!");
                }
                Console.WriteLine($"{product.Count + 1}. Back");
                string choice = Console.ReadLine();
                if (choice == (product.Count+1).ToString())
                {
                    break;
                }
                for (int i = 0; i < product.Count; i++) 
                {
                    if (choice == (i + 1).ToString()) 
                    {
                        int profit = product[i].harvest();
                        if (profit > 0)
                        {                            
                            selectProductSeed[i] = $"Đã thu hoạch. Lợi nhuận {profit}";
                            product.Remove(product[i]);
                            player.Reward += profit;
                        }
                        Thread.Sleep(2000);
                    }
                }
            }
        }
        public static void FeedMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Chọn cây bón phân: ");
                if (product.Count > 0)
                {
                    for (int i = 0; i < product.Count; i++)
                    {
                        if (product[i] is Tomato tomato)
                        {
                            Console.WriteLine($"{i + 1}. Tomato {tomato.Start}");
                        }
                        else if (product[i] is Sunflower sunflower)
                        {
                            Console.WriteLine($"{i + 1}. Sunflower {sunflower.Start}");
                        }
                        else if (product[i] is Wheat wheat)
                        {
                            Console.WriteLine($"{i + 1}. Wheat {wheat.Start}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Chưa trồng cây nào!!");
                }
                Console.WriteLine($"{product.Count + 1}. Back");
                string choice = Console.ReadLine();
                if (choice == (product.Count + 1).ToString())
                {
                    break;
                }
                for (int i = 0; i < product.Count; i++)
                {
                    if (choice == (i + 1).ToString())
                    {
                        if (product[i] is Tomato tomato)
                        {
                            tomato.feed();
                        }
                        else if (product[i] is Sunflower sunflower)
                        {
                            sunflower.feed();
                        }
                        else if (product[i] is Wheat wheat)
                        {
                            wheat.feed();
                        }
                        Thread.Sleep(1500);
                    }
                }
            }
        }
        public static void ProvWaterMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Chọn cây bón phân: ");
                if (product.Count > 0)
                {
                    for (int i = 0; i < product.Count; i++)
                    {
                        if (product[i] is Tomato tomato)
                        {
                            Console.WriteLine($"{i + 1}. Tomato {tomato.Start}");
                        }
                        else if (product[i] is Sunflower sunflower)
                        {
                            Console.WriteLine($"{i + 1}. Sunflower {sunflower.Start}");
                        }
                        else if (product[i] is Wheat wheat)
                        {
                            Console.WriteLine($"{i + 1}. Wheat {wheat.Start}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Chưa trồng cây nào!!");
                }
                Console.WriteLine($"{product.Count + 1}. Back");
                string choice = Console.ReadLine();
                if (choice == (product.Count + 1).ToString())
                {
                    break;
                }
                for (int i = 0; i < product.Count; i++)
                {
                    if (choice == (i + 1).ToString())
                    {
                        if (product[i] is Tomato tomato)
                        {
                            tomato.prov_water();
                        }
                        else if (product[i] is Sunflower sunflower)
                        {
                            sunflower.prov_water();
                        }
                        else if (product[i] is Wheat wheat)
                        {
                            wheat.prov_water();
                        }
                        Thread.Sleep(1500);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();
            List<Player> players = new List<Player>()
            {
                new Player("A"),
                new Player("B"),
                new Player("C")
            };
            bool login = false;
            while (login == false)
            {
                Console.Write("User Name: ");
                string inputUsername = Console.ReadLine();
                Player currentPlayer = null;
                foreach (Player player in players)
                {
                    if (player.Login(inputUsername))
                    {
                        login = true;
                        currentPlayer = player;
                        break;
                    }
                }
                if (login == true)
                {
                    Console.WriteLine("Đang vào chơi...");
                    Thread.Sleep(500);
                    Menu(currentPlayer);
                }
                else
                {
                    Console.WriteLine("Sai User Name, vui lòng nhập lại !!");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
            Console.ReadKey();
        }
    }
}