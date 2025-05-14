using System;
using System.Collections.Generic;
using System.Threading;

namespace Cybro
{
    class Chat
    {
        private Topics Cybertopics = new Topics();
        private Dictionary<string, string> memory = new Dictionary<string, string>();
        private Random rand = new Random();

        // Tip collections for each topic
        private readonly Dictionary<string, List<string>> topicTips = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase)
        {
            ["password"] = new List<string>
            {
                "Use at least 12 characters, mixing uppercase, lowercase letters, numbers, and symbols for maximum strength.",
                "Never reuse passwords across multiple accounts—each login deserves its own unique key.",
                "Try a memorable passphrase like “Blue Sky Horse 7!”—easy to remember, hard to crack."
            },
            ["phishing"] = new List<string>
            {
                "Hover over links before you click to see where they really lead.",
                "Check the sender’s address for typos or odd domains—those are red flags.",
                "If you’re unsure, don’t enter credentials; go to the site directly instead."
            },
            ["safe browsing"] = new List<string>
            {
                "Always look for “https://” and a padlock icon before entering any sensitive data.",
                "Download software only from reputable sites you trust.",
                "Keep your browser up to date—modern versions include built‑in security protection."
            },
            ["ransomware"] = new List<string>
            {
                "Back up important files regularly to an offline drive or secure cloud service.",
                "Don’t open unexpected attachments—even if the email looks official.",
                "Stay current with antivirus updates and system patches to block known threats."
            },
            ["public wi‑fi"] = new List<string>
            {
                "Use a VPN when connecting to public Wi‑Fi to encrypt your data.",
                "Turn off auto‑connect so you won’t jump on unknown networks by accident.",
                "Avoid banking or shopping when you’re on a public hotspot."
            },
            ["social engineering"] = new List<string>
            {
                "If you get an unexpected call claiming to be from your bank, hang up and call back on their official number.",
                "Never share one‑time codes or passwords, even if the caller sounds urgent.",
                "Question messages that pressure you to act immediately—legitimate requests don’t rush you."
            },
            ["deepfake"] = new List<string>
            {
                "Watch for odd lip movements or mismatched audio/video that feels “off.”",
                "Verify urgent requests by contacting the person through a separate channel.",
                "Be skeptical of any video or audio that pushes you to make quick decisions."
            },
            ["iot"] = new List<string>
            {
                "Change default passwords on all smart devices to something strong and unique.",
                "Install firmware updates as soon as they’re available to fix security holes.",
                "Keep your IoT gadgets on a separate network to limit potential cross‑device attacks."
            },
            ["email"] = new List<string>
            {
               "Enable spam filters and report phishing attempts to your email provider.",
               "Never click links or open attachments from senders you don’t recognize.",
               "Add two‑factor authentication to your email for an extra layer of protection."
            },
            ["software updates"] = new List<string>
            {
                "Turn on automatic updates for your operating system and key applications.",
                "Restart or apply updates as soon as you see a pending notification.",
                "Sign up for vendor security alerts so you know about critical patches immediately."
            },
            ["password policies"] = new List<string>
            {
               "Require passwords to be at least 12 characters long with mixed character types.",
               "Force password changes every 90 days and prevent reuse of old passwords.",
               "Consider using a password manager to generate and securely store credentials."
            }
        };

        public void Showchat(string userName, string logo, Menu menu)
        {
            Console.Clear();
            TypeEffect.Type("Loading chat mode...", 30);
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine(logo);
            TypeEffect.Type(new string('-', 93), 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            TypeEffect.Type("                                     Chatting with Cybro!                                     ", 1);
            Console.ForegroundColor = ConsoleColor.White;
            TypeEffect.Type(new string('-', 93), 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            TypeEffect.Type($"\nIs there anything you'd like to ask me {userName}? (Type 'exit' to return to the main menu)", 20);

            bool chat = true;
            while (chat)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nYou: ");
                Console.ForegroundColor = ConsoleColor.White;
                string input = Console.ReadLine().ToLower().Trim();

                if (string.IsNullOrEmpty(input))
                {
                    TypeEffect.Type("\nOops! Looks like you didn’t enter anything. Please type something.", 20);
                    continue;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nCybro: ");
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Yellow;

                // Sentiment detection for general mood
                if (input.Contains("worried") || input.Contains("anxious") || input.Contains("scared"))
                {

                    TypeEffect.Type("It's okay to feel that way. Let me share some tips to help you feel safer.", 20);
                    continue;
                }

                // Recognize "how are you" with or without question mark
                if (input.Contains("how are you"))
                {
          
                    TypeEffect.Type("I’m doing great, thanks for asking! How about you?", 20);


                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\nYou: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    string moodReply = Console.ReadLine().ToLower();

                    
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\nCybro: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    // Sentiment detection in reply
                    if (moodReply.Contains("good") || moodReply.Contains("great") || moodReply.Contains("fine") || moodReply.Contains("okay"))
                    {
                        TypeEffect.Type("Glad to hear you're doing well! Let's keep the conversation going.", 20);
                    }
                    else if (moodReply.Contains("not good") || moodReply.Contains("bad") || moodReply.Contains("sad") || moodReply.Contains("tired"))
                    {
                        TypeEffect.Type("I'm sorry to hear that. If you want to talk or need a tip, just let me know.", 20);
                    }
                    continue;
                }

                if (input.Contains("purpose"))
                {
                    TypeEffect.Type("My purpose is to help you stay cyber-safe! To answer questions, share security tips, & guide you through online threats.", 20);
                    continue;
                }

   
                // Track if we handled any valid input
                bool matched = false;

                if (input.Contains("interested in"))
                {
                    int start = input.IndexOf("interested in") + "interested in".Length;
                    string topic = input.Substring(start).Trim(new char[] { ' ', '.', '?' });

                    if (!string.IsNullOrWhiteSpace(topic))
                    {
                        memory["favoriteTopic"] = topic;
                        TypeEffect.Type($"Got it — I'll remember you're interested in {topic}.", 20);
                    }
                    else
                    {
                        TypeEffect.Type("Can you tell me which topic you're interested in?", 20);
                    }
                    continue;
                }

                foreach (var kv in topicTips)
                {
                    if (input.Contains(kv.Key) && input.Contains("tip"))
                    {
                        var tips = kv.Value;
                        string tip = tips[rand.Next(tips.Count)];
                        TypeEffect.Type(tip, 20);
                        matched = true;
                        break;
                    }
                    else if (input.Contains(kv.Key))
                    {
                        TypeEffect.Type($"Great topic! If you'd like a tip on {kv.Key}, just type '{kv.Key} tip'.", 20);
                        matched = true;
                        break;
                    }
                }

                if (matched) continue;


                // Specific exit handling
                if (input == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(1000);
                    TypeEffect.Type($"\nIt was great chatting with you, {userName}! Stay cyber-safe!", 20);
                    TypeEffect.Type("\nReturning to the main menu...", 20);
                    Thread.Sleep(2000);
                    chat = false;
                    Console.Clear();
                    Console.WriteLine(logo);
                    menu.showMenu(userName, logo);
                    break;
                }

                // Memory recall
                if (input.Contains("remind me") || input.Contains("what did i say"))
                {
                    if (memory.TryGetValue("favoriteTopic", out var fav))
                        TypeEffect.Type($"You told me you're interested in {fav}.", 20);
                    else
                        TypeEffect.Type("I don't have anything saved yet. Tell me what topic you like by saying 'I'm interested in ...'", 20);
                    continue;
                }

                // Memory-based fallback only if no match
                if (memory.TryGetValue("favoriteTopic", out var favorite))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    TypeEffect.Type($"As someone interested in {favorite}, you might find this tip helpful: type '{favorite} tip'.", 20);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    TypeEffect.Type("I'm not sure I understand. Could you try rephrasing or ask for a specific tip?", 20);
                }

            NextLoop:
                ; // continue while
            }
        }
    }
}
