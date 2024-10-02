
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bai9_OOP
{
    internal class Program
    {
        public static void SerializeData(List<Player> players, string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                try
                {
                    binaryFormatter.Serialize(fs, players);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed to serialize. Reason: " + ex.Message);
                    throw;
                }
            }
        }
        public static List<Player> DeserializeData(string filePath)
        {
            List<Player> players = null;
            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    try
                    {
                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        players = (List<Player>)binaryFormatter.Deserialize(fs);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Failed to deserialize. Reason: " + ex.Message);
                        throw;
                    }
                }
            }
            return players ?? new List<Player>();
        }      
        public static List<string> selectProductSeed = new List<string>();
        public static List<Product> product = new List<Product>();
        public static void Menu(Player player, List<Player> players, string filePath)
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
                            SerializeData(players, filePath);
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
                if (choice == (product.Count + 1).ToString())
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
                            if (product[i] is Tomato tomato)
                            {
                                selectProductSeed[i] = $"Đã thu hoạch Tomato. Lợi nhuận {profit}";
                            }
                            else if (product[i] is Sunflower sunflower)
                            {
                                selectProductSeed[i] = $"Đã thu hoạch Sunflower. Lợi nhuận {profit}";
                            }
                            else if (product[i] is Wheat wheat)
                            {
                                selectProductSeed[i] = $"Đã thu hoạch Wheat. Lợi nhuận {profit}";
                            }
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
            string filePath = "playersData.dat";
            List<Player> players = DeserializeData(filePath);
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();
            if (players.Count == 0)
            {
                players = new List<Player>()
                {
                    new Player("A"),
                    new Player("B"),
                    new Player("C")
                };
            }
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
                    Menu(currentPlayer, players, filePath);
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
