using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

class StockWatcherPro
{
    private static readonly Random random = new Random();
    private static readonly Dictionary<string, double> stocks = new Dictionary<string, double>()
    {
        { "AAPL", 150.00 },
        { "GOOGL", 2800.00 },
        { "MSFT", 320.00 },
        { "TSLA", 900.00 },
        { "AMZN", 3400.00 }
    };
    private static readonly object lockObject = new object();

    static void Main()
    {
        Console.Title = "StockWatcherPro - Real-Time Stock Monitor";
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n WELCOME TO STOCKWATCHERPRO");
        Console.WriteLine("Real-Time Stock Monitoring & Analysis\n");
        Console.ResetColor();

        string filePath = "StockPrices.txt";
        File.WriteAllText(filePath, "Stock Prices Log\n----------------\n");

        foreach (var stock in stocks.Keys)
        {
            Thread thread = new Thread(() => UpdateStockPrice(stock, filePath));
            thread.Start();
        }

        Thread.Sleep(10000); // Let stocks update for 10 seconds

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nSTOCK PRICE ANALYSIS\n");
        Console.ResetColor();
        AnalyzeStockPrices(filePath);
    }

    static void UpdateStockPrice(string stock, string filePath)
    {
        for (int i = 0; i < 10; i++)
        {
            lock (lockObject)
            {
                double change = Math.Round(random.NextDouble() * 10 - 5, 2); // Random change -5 to +5
                stocks[stock] += change;

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{DateTime.Now:T} - ");

                if (change > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{stock}: ${stocks[stock]:0.00} (+{change:0.00})\n");
                }
                else if (change < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{stock}: ${stocks[stock]:0.00} ({change:0.00})\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"{stock}: ${stocks[stock]:0.00} (No Change)\n");
                }
                Console.ResetColor();

                string log = $"{DateTime.Now:T} - {stock}: ${stocks[stock]:0.00} ({change:+0.00;-0.00;0.00})";
                File.AppendAllText(filePath, log + "\n");
            }
            Thread.Sleep(random.Next(500, 1500));
        }
    }

    static void AnalyzeStockPrices(string filePath)
    {
        var lines = File.ReadAllLines(filePath)
                        .Where(line => line.Contains("$"))
                        .Select(line => new
                        {
                            Symbol = line.Split('-')[1].Trim().Split(':')[0],
                            Price = double.Parse(line.Split('$')[1])
                        });

        var summary = lines.GroupBy(s => s.Symbol)
                           .Select(g => new { Symbol = g.Key, Max = g.Max(x => x.Price), Min = g.Min(x => x.Price) });

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Stock Summary ");
        Console.WriteLine("--------------------\n");

        foreach (var stock in summary)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{stock.Symbol} | ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"High: ${stock.Max:0.00} ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"| Low: ${stock.Min:0.00}\n");
        }

        Console.ResetColor();
    }
}
