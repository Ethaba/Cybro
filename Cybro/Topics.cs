using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Cybro
{
    class Topics
    {
        public void showTopics(string userName, string logo, Menu menu)
        {
            TypeEffect.Type("Loading Cybersecurity Topics...", 20);
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine(logo);
            header(); //display header

            bool running = true;

            while (running) //Keeps the chatbot running until the user chooses to exit and return to the main menu
            {
                Thread.Sleep(2000);
                MenuDisplay();

                while (true) //Handles user input for selecting a topic and ensures proper validation
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\nYou: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    string option = Console.ReadLine().ToLower();

                    //handles empty user input
                    if (string.IsNullOrWhiteSpace(option))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nOops! Looks like you didn’t enter anything. Please select a valid option.");
                        continue;
                    }

                    //A method corresponding with the option you choose is called
                    switch (option)
                    {
                        case "1":
                        case "password safety":
                            Thread.Sleep(1000);
                            passwordSafety();
                            break;

                        case "2":
                        case "two-factor authentication":
                            Thread.Sleep(1000);
                            TwoFactorAuth();
                            break;

                        case "3":
                        case "phishing":
                            Thread.Sleep(1000);
                            phishing();
                            break;

                        case "4":
                        case "safe browsing":
                            Thread.Sleep(1000);
                            safeBrowsing();
                            break;

                        case "5":
                        case "ransomware attacks":
                            Thread.Sleep(1000);
                            ransomwareAttacks();
                            break;

                        case "6":
                        case "public Wi-Fi risks":
                            Thread.Sleep(1000);
                            publicWiFiRisks();
                            break;

                        case "7":
                        case "social engineering attacks":
                            Thread.Sleep(1000);
                            socialEngineeringAttacks();
                            break;

                        case "8":
                        case "deepfake scams":
                            Thread.Sleep(1000);
                            Deepfakes();
                            break;

                        case "9":
                        case "internet of things (IoT) security":
                            Thread.Sleep(1000);
                            IoTSecurity();
                            break;

                        case "10":
                        case "email security":
                            Thread.Sleep(1000);
                            EmailSecurity();
                            break;

                        case "11":
                        case "why software updates matter for cybersecurity":
                            Thread.Sleep(1000);
                            SoftwareUpdates();
                            break;

                        case "12":
                        case "strong password policies":
                            Thread.Sleep(1000);
                            passwordPolicies();
                            break;

                        case "13":
                        case "exit":
                            Thread.Sleep(1000);
                            Console.WriteLine("Returning to the main menu...");
                            Thread.Sleep(2000);
                            running = false; // Exit the outer while loop to return to the main menu
                            Console.Clear();
                            Console.WriteLine(logo);
                            menu.showMenu(userName, logo); // Go back to main menu
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Thread.Sleep(1000);
                            Console.WriteLine("\nOops...I didn’t quite catch that. Try Again please.");
                            continue;
                    }
                    break; // Break the inner while loop after a valid option
                }

            }
        }

        private void header()
        {
            Console.ForegroundColor = ConsoleColor.White;
            TypeEffect.Type("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=", 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            TypeEffect.Type("\n                         Welcome to Cybersecurity Topics!                                \n", 1);
            TypeEffect.Type("              Here, you can learn about different ways to stay safe online.                  ", 1);
            TypeEffect.Type("\n    So, which topic are you interested in? Choose an option to learn more, or 'exit' to quit\n            ", 1);
            Console.ForegroundColor = ConsoleColor.White;
            TypeEffect.Type("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=", 1);
        }

        private void MenuDisplay()
        {

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.ResetColor();

            Console.WriteLine("CYBERSECURITY BASICS: PROTECTING YOURSELF ONLINE");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("1: Password Safety");
            Console.WriteLine("2: Two-Factor Authentication (2FA)");
            Console.WriteLine("3: Phishing");
            Console.WriteLine("4: Safe Browsing");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.ResetColor();

            Console.WriteLine("UNDERSTANDING COMMON CYBER THREATS");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("5: Ransomware Attacks");
            Console.WriteLine("6: Public Wi-Fi risks");
            Console.WriteLine("7: Social Engineering Attacks");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.ResetColor();

            Console.WriteLine("EMERGING CYBER THREATS TO LOOK OUT FOR");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("8: Deepfake Scams");
            Console.WriteLine("9: Internet of Things (IoT) Security");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.ResetColor();

            Console.WriteLine("BEST PRACTICES");
            Console.WriteLine("---------------");
            Console.WriteLine("10: Email Security");
            Console.WriteLine("11: Why Software Updates Matter for Cybersecurity");
            Console.WriteLine("12: Strong Password Policies");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.ResetColor();
        }


        //below is the information for each topic
        private void passwordSafety()
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Password Safety");
            Console.WriteLine("- - - - - - - - - - - - - - - -\n");

            Console.ForegroundColor = ConsoleColor.Green;
            TypeEffect.Type("Definition: Password safety means creating and managing strong passwords to protect your accounts from unauthorized access.\n", 20);

            Console.ForegroundColor = ConsoleColor.Yellow;
            TypeEffect.Type("Importance: A weak password is like leaving your front door unlocked—it makes hacking easy.\n", 20);

            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeEffect.Type("Example: Would you use 'password123'? Hackers can crack it in seconds! Instead, try 'R3kord!2023_SAfety'.\n", 20);

            Console.ForegroundColor = ConsoleColor.Magenta;
            TypeEffect.Type("Tips: Use unique passwords for every site, avoid personal details like 'Sipho1990', and use a password manager.\n", 20);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Final Thought: Would you give your house keys to a stranger? No? Then don’t use weak passwords online!");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPress Enter to return to view menu...");
            Console.ResetColor();
            Console.ReadLine();
        }

        private void phishing()
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Phishing");
            Console.WriteLine("- - - - - - - - -\n");

            Console.ForegroundColor = ConsoleColor.Green;
            TypeEffect.Type("Definition: Phishing is a cyberattack where scammers send fake messages to trick you into sharing personal information.\n", 20);

            Console.ForegroundColor = ConsoleColor.Yellow;
            TypeEffect.Type("Importance: Phishing is one of the most common cyber threats worldwide, including in South Africa.\n", 20);

            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeEffect.Type("Example: Imagine receiving an email from 'sars.support@taxrefund.com' saying 'Click here for your refund'—but SARS only uses 'info@sars.gov.za'.\n", 20);

            Console.ForegroundColor = ConsoleColor.Magenta;
            TypeEffect.Type("Tips: Always verify sender email addresses, hover over links before clicking, and report suspicious emails to your bank.\n", 20);

            Console.ForegroundColor = ConsoleColor.Red;
            TypeEffect.Type("Question: If your 'bank' emails you asking for your password, what should you do? (Hint: Real banks never ask for this!)\n", 20);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPress Enter to return to the topics menu...");
            Console.ResetColor();
            Console.ReadLine();
        }

        private void safeBrowsing()
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Safe Browsing");
            Console.WriteLine("- - - - - - - - - - - - - - - -");

            Console.ForegroundColor = ConsoleColor.Green;
            TypeEffect.Type("Definition: Safe browsing means using the internet securely to avoid threats like malware or data theft.\n", 20);

            Console.ForegroundColor = ConsoleColor.Yellow;
            TypeEffect.Type("Importance: Every time you browse online, hackers look for weak spots to exploit.\n", 20);

            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeEffect.Type("Example: 'https://www.absa.co.za' with a padlock symbol is secure, but 'http://cheapdeals.co.za' without encryption could steal your data.\n", 20);

            Console.ForegroundColor = ConsoleColor.Magenta;
            TypeEffect.Type("Tips: Only enter sensitive data on 'https://' sites, avoid downloads from unknown sources, and shop on trusted platforms like Takealot.\n", 20);

            Console.ForegroundColor = ConsoleColor.Red;
            TypeEffect.Type("Final Thought: If you wouldn’t give your credit card to a stranger, why enter it on an unsecure website?\n", 20);

            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeEffect.Type("\nPress Enter to return to the topics menu...", 20);
            Console.ResetColor();
            Console.ReadLine();
        }

        private void TwoFactorAuth()
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Two-Factor Authentication (2FA)");
            Console.WriteLine("- - - - - - - - - - - - - - - -\n");

            Console.ForegroundColor = ConsoleColor.Green;
            TypeEffect.Type("Definition: 2FA requires a second step—like a one-time code—to verify your identity.\n", 20);

            Console.ForegroundColor = ConsoleColor.Yellow;
            TypeEffect.Type("Importance: Even if hackers steal your password, they can’t access your account without the second factor.\n", 20);

            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeEffect.Type("Example: You log into Gmail, but before access is granted, you must enter '739281' from an SMS.\n", 20);

            Console.ForegroundColor = ConsoleColor.Magenta;
            TypeEffect.Type("Tips: Enable 2FA on important accounts like banking apps (e.g., FNB), and use authenticator apps instead of SMS for better security.\n", 20);

            Console.ForegroundColor = ConsoleColor.Red;
            TypeEffect.Type("Final Thought: If your house had two locks, wouldn't it be harder for burglars to enter? Apply the same logic to your online accounts!\n", 20);

            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeEffect.Type("\nPress Enter to return to the topics menu...", 20);
            Console.ResetColor();
            Console.ReadLine();
        }

        private void ransomwareAttacks()
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Ransomware Attacks");
            Console.WriteLine("- - - - - - - - - - - - - - - -\n");

            Console.ForegroundColor = ConsoleColor.Green;
            TypeEffect.Type("Definition: Ransomware is malware that locks or encrypts your files and demands payment for access.\n", 20);

            Console.ForegroundColor = ConsoleColor.Yellow;
            TypeEffect.Type("Importance: Paying the ransom does not guarantee file recovery—hackers may just demand more money!\n", 20);

            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeEffect.Type("Example: A fake 'Eskom bill.pdf' locks your PC with a message: 'Pay R8,000 in Bitcoin to unlock your files!'\n", 20);

            Console.ForegroundColor = ConsoleColor.Magenta;
            TypeEffect.Type("Tips: Back up important files weekly, avoid downloading attachments from unknown senders, and use strong antivirus protection.\n", 20);

            Console.ForegroundColor = ConsoleColor.Red;
            TypeEffect.Type("Final Thought: Would you rather back up your data for free or pay a hacker R8,000 to get it back?\n", 20);

            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeEffect.Type("\nPress Enter to return to the topics menu...", 20);
            Console.ResetColor();
            Console.ReadLine();
        }

        private void publicWiFiRisks()
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Public Wi-Fi Risks");
            Console.WriteLine("- - - - - - - - - - - - - - - -\n");

            Console.ForegroundColor = ConsoleColor.Green;
            TypeEffect.Type("Definition: Public Wi-Fi is convenient, but hackers can intercept data on unsecured networks.\n", 20);

            Console.ForegroundColor = ConsoleColor.Yellow;
            TypeEffect.Type("Importance: If you use public Wi-Fi without protection, you risk exposing sensitive information.\n", 20);

            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeEffect.Type("Example: You log into Standard Bank on 'Free_CT_WiFi' at an airport. A hacker nearby can steal your login credentials.\n", 20);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Tips: Use mobile data for banking, get a VPN to encrypt traffic, and disable auto-connect to public networks.\n");

            Console.ForegroundColor = ConsoleColor.Red;
            TypeEffect.Type("Question: If you wouldn’t share your bank PIN in public, why log in to your bank account on public Wi-Fi? \n", 20);

            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeEffect.Type("\nPress Enter to return to the topics menu...", 20);
            Console.ResetColor();
            Console.ReadLine();
        }

        private void socialEngineeringAttacks()
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Social Engineering Attacks");
            Console.WriteLine("- - - - - - - - - - - - - - - -\n");

            Console.ForegroundColor = ConsoleColor.Green;
            TypeEffect.Type("Definition: Social engineering is when attackers trick people into revealing confidential information.\n", 20);

            Console.ForegroundColor = ConsoleColor.Yellow;
            TypeEffect.Type("Importance: It’s based on manipulation, not technology—meaning **anyone** can fall for it.\n", 20);

            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeEffect.Type("Example: You get a call from 'Nedbank Fraud Team' asking for your OTP—real banks **never** do this!\n", 20);

            Console.ForegroundColor = ConsoleColor.Magenta;
            TypeEffect.Type("Tips: Always verify requests using official contact details, don’t share OTPs, and watch for urgent pleas.\n", 20);

            Console.ForegroundColor = ConsoleColor.Red;
            TypeEffect.Type("Final Thought: If someone asks for your house keys over the phone, would you give them? No? Then don’t share your OTP!\n", 20);

            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeEffect.Type("\nPress Enter to return to the topics menu...", 20);
            Console.ResetColor();
            Console.ReadLine();
        }

        private void Deepfakes()
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Deepfake Scams");
            Console.WriteLine("- - - - - - - - - - - - - - - -\n");

            Console.ForegroundColor = ConsoleColor.Green;
            TypeEffect.Type("Definition: Deepfakes are AI-generated fake videos or audio used for scams and misinformation.\n", 20);

            Console.ForegroundColor = ConsoleColor.Yellow;
            TypeEffect.Type("Importance: These can be used to impersonate public figures, CEOs, or even family members to steal money or spread fake news.\n", 20);

            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeEffect.Type("Example: You receive a deepfake video of your boss saying 'Transfer R15,000 now!'—always verify before acting.\n", 20);

            Console.ForegroundColor = ConsoleColor.Magenta;
            TypeEffect.Type("Tips: Be skeptical of unusual requests, check for unnatural speech patterns, and confirm urgent actions via a phone call.\n", 20);

            Console.ForegroundColor = ConsoleColor.Red;
            TypeEffect.Type("Final Thought: If you wouldn’t send money based on a text message alone, don’t trust a suspicious video either!\n", 20);

            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeEffect.Type("\nPress Enter to return to the topics menu...", 20);
            Console.ResetColor();
            Console.ReadLine();
        }

        private void IoTSecurity()
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Internet of Things (IoT) Security");
            Console.WriteLine("- - - - - - - - - - - - - - - -\n");

            Console.ForegroundColor = ConsoleColor.Green;
            TypeEffect.Type("Definition: IoT security protects smart devices (like cameras, TVs, and thermostats) from cyber threats.\n", 20);

            Console.ForegroundColor = ConsoleColor.Yellow;
            TypeEffect.Type("Importance: Hackers can take control of insecure IoT devices to spy on you or attack your network.\n", 20);

            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeEffect.Type("Example: A smart doorbell with a default password like '1234' could let a hacker spy on your home.\n", 20);

            Console.ForegroundColor = ConsoleColor.Magenta;
            TypeEffect.Type("Tips: Change default passwords, update firmware regularly, and disconnect unused devices from the internet.\n", 20);

            Console.ForegroundColor = ConsoleColor.Red;
            TypeEffect.Type("Final Thought: If you wouldn’t leave your front door unlocked, why leave your smart devices unprotected?\n", 20);

            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeEffect.Type("\nPress Enter to return to the topics menu...", 20);
            Console.ResetColor();
            Console.ReadLine();
        }

        private void EmailSecurity()
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            TypeEffect.Type("Email Security", 20);
            TypeEffect.Type("- - - - - - - - - - - - - - - -\n", 20);

            Console.ForegroundColor = ConsoleColor.Green;
            TypeEffect.Type("Definition: Email security protects your inbox from scams, malware, and unauthorized access.\n", 20);

            Console.ForegroundColor = ConsoleColor.Yellow;
            TypeEffect.Type("Importance: Hackers use compromised emails to steal data, spread malware, or reset your passwords.\n", 20);

            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeEffect.Type("Example: You receive a phishing email from 'info@fnb.co.za' asking you to verify your account details.\n", 20);

            Console.ForegroundColor = ConsoleColor.Magenta;
            TypeEffect.Type("Tips: Use strong passwords, enable two-factor authentication, and never open attachments from unknown senders.\n", 20);

            Console.ForegroundColor = ConsoleColor.Red;
            TypeEffect.Type("Final Thought: If you wouldn’t open a stranger’s letter, why open an unsolicited email?\n", 20);

            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeEffect.Type("\nPress Enter to return to the topics menu...", 20);
            Console.ResetColor();
            Console.ReadLine();
        }

        private void SoftwareUpdates()
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Software Updates");
            Console.WriteLine("- - - - - - - - - - - - - - - -\n");

            Console.ForegroundColor = ConsoleColor.Green;
            TypeEffect.Type("Definition: Software updates are releases from software vendors that address vulnerabilities and improve functionality.\n", 20);

            Console.ForegroundColor = ConsoleColor.Yellow;
            TypeEffect.Type("Importance: Keeping your software updated prevents attackers from exploiting known security flaws.\n", 20);

            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeEffect.Type("Example: If you don’t update your Android or iOS app, attackers might use vulnerabilities to steal your data.\n", 20);

            Console.ForegroundColor = ConsoleColor.Magenta;
            TypeEffect.Type("Tips: Enable automatic updates, check for updates regularly, and install security patches as soon as they are available.\n", 20);

            Console.ForegroundColor = ConsoleColor.Red;
            TypeEffect.Type("Final Thought: Neglecting software updates is like leaving your door unlocked—don't risk it!\n", 20);

            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeEffect.Type("\nPress Enter to return to the topics menu...", 20);
            Console.ResetColor();
            Console.ReadLine();
        }

        private void passwordPolicies()
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Password Policies");
            Console.WriteLine("- - - - - - - - - - - - - - - -\n");

            Console.ForegroundColor = ConsoleColor.Green;
            TypeEffect.Type("Definition: Password policies define the rules for creating strong, secure passwords to protect accounts.\n", 20);

            Console.ForegroundColor = ConsoleColor.Yellow;
            TypeEffect.Type("Importance: Weak passwords are a major cause of data breaches and account compromises.\n", 20);

            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeEffect.Type("Example: A good password policy might require passwords to be at least 12 characters and include upper and lowercase letters, numbers, and symbols.\n", 20);

            Console.ForegroundColor = ConsoleColor.Magenta;
            TypeEffect.Type("Tips: Use a combination of letters, numbers, and symbols, avoid using easily guessable details like birthdays, and use unique passwords for each account.\n", 20);

            Console.ForegroundColor = ConsoleColor.Red;
            TypeEffect.Type("Final Thought: A strong password is the first line of defense—treat it like a secret key to your castle!\n", 20);

            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeEffect.Type("\nPress Enter to return to the topics menu...", 20);
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}