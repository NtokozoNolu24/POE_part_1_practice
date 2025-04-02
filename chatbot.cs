using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace POE_part_1_practice
{
    public class chatbot
    {
        //first arraylist stores the answer of the user
        ArrayList responses = new ArrayList();
        //second arrayist filters the answer( by picking out keywords)
        ArrayList ignore = new ArrayList();
        //this arraylist id for keywords that the bot will pick up when the user asks their question
        ArrayList keyWords = new ArrayList();

      
        public chatbot()
        {
            //Call all methods in here
            stored_responses();
            ignore_words();
            ai_chat();
            
           
       
           }//end of constructor

        //method for the AI chatbot
        public void ai_chat()
        {
            //Welcome user
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("==============================================================================================");
            Console.WriteLine("WELCOME TO THE CYBERSECURITY AWARENESS BOT. I AM HERE TO HELP YOU STAY SAFE ONLINE");
            Console.WriteLine("==============================================================================================\n");

            //Use AI bot to prompt user to enter name
            //AI bot is blue in color
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("AIChat:-> Please enter your name");

            //User response is magenta(pink) in color
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("User:-> ");
            //reading user input
            string name = Console.ReadLine();

            //AI response
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("AIChat:-> Hi " + name + "!" +" How are you?");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("AIChat:-> If there isn't anything you need, Type 'leave' to exit the chat");

            //use while loop to allow user to continue to interact with chatbot
            //while loop will end when "leave" is typed
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(name + ":-> ");
                string input = Console.ReadLine().ToLower();

                //if "leave" is typed, then display message and end program
                if (input == "leave")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("AIChat:-> Thank you "+name+" for chatting! Stay safe online.");
                    break; 
                }
                //to get response
                string response = Response(input);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(response);
            }

        }
            //then store responses using a method 
            //keywords are also added to quickly identify the response and give it yo the user
            private void stored_responses() {
            keyWords.Add("you?");
            responses.Add("AIChat:-> I am great thanks!\n"+"How can I assist you today?");

            keyWords.Add("purpose");
            responses.Add("AIChat:-> I am designed to enhance cybersecurity awareness,\n" +
                         " generate responses to security incidents and provide guidance on cybersecurity best practices\n" +
                         " such as recognizing phishing attempts, securing passwords and avoiding social engineering attacks!");

            //in case the user asks a question
            keyWords.Add("purpose?");
            responses.Add("AIChat:-> I am designed to enhance cybersecurity awareness,\n" +
                         " generate responses to security incidents and provide guidance on cybersecurity best practices\n" +
                         " such as recognizing phishing attempts, securing passwords and avoiding social engineering attacks!");

            keyWords.Add("protect");
            responses.Add("AIChat:-> Use strong passwords, keep software up-to-date, and be cautious with emails.");

            keyWords.Add("ask");
            responses.Add("AIChat:-> You can ask me about anything related to cybersecurity.");

            keyWords.Add("browsing?");
            responses.Add("AIChat:-> Safe browsing refers to the practice of using the internet securely\n" +
                          " while protecting yourself from online threats such as malware, phishing attacks, and data theft.\n" +
                          " It involves adopting habits and using tools that help minimize risks while surfing the web.");

            keyWords.Add("browsing");
            responses.Add("AIChat:-> Safe browsing refers to the practice of using the internet securely\n" +
                          " while protecting yourself from online threats such as malware, phishing attacks, and data theft.\n" +
                          " It involves adopting habits and using tools that help minimize risks while surfing the web.");


            keyWords.Add("safe");
            responses.Add("AIChat:-> There are many ways to stay safe online.\n " +
                          " Here are some key cybersecurity tips:\n" +
                          "~ Always use strong, unique passwords for each account.\n" +
                          "~ Be cautious about what you share online\n" +
                          " (avoid posting sensitive details like your address or phone number).\n" +
                          "~ Adjust privacy settings on social media to control who can see your information.\n" +
                          "~ Never click on suspicious links in emails or messages.");

            keyWords.Add("phishing");
            responses.Add("AIChat:-> Phishing is a type of cyberattack where scammers try to trick you into providing personal information,\n" +
                          " such as passwords, credit card numbers, or other sensitive data. These attacks often come in the form of emails,\n" +
                          " text messages,or fake websites that appear to be from legitimate companies or individuals");

            //in case the user asks a question
            keyWords.Add("phishing?");
            responses.Add("AIChat:-> Phishing is a type of cyberattack where scammers try to trick you into providing personal information,\n" +
                          " such as passwords, credit card numbers, or other sensitive data. These attacks often come in the form of emails,\n" +
                          " text messages,or fake websites that appear to be from legitimate companies or individuals");

            keyWords.Add("cybersecurity");
            responses.Add("AIChat:-> Cybersecurity is the practice of protecting computer systems, networks, and data from digital threats,\n" +
                          " such as hacking, malware, phishing, and other cyberattacks. It involves using technologies, processes,\n" +
                          " and best practices to prevent unauthorized access, data breaches, and damage to sensitive information.");
            //in case the user asks a question
            keyWords.Add("cybersecurity?");
            responses.Add("AIChat:-> Cybersecurity is the practice of protecting computer systems, networks, and data from digital threats,\n" +
                          " such as hacking, malware, phishing, and other cyberattacks. It involves using technologies, processes,\n" +
                          " and best practices to prevent unauthorized access, data breaches, and damage to sensitive information.");

            keyWords.Add("thank");
            responses.Add("AIChat:-> Always glad to help! Let me know if you need anything :)");

            keyWords.Add("thanks");
            responses.Add("AIChat:-> Always glad to help! Let me know if you need anything :)");

        }

        //method for ignore words
        private void ignore_words()
        {
            ignore.Add("tell");
            ignore.Add("Tell");
            ignore.Add("online");
            ignore.Add("online?");
            ignore.Add("can");
            ignore.Add("i");
            ignore.Add("I");
            ignore.Add("stay");
            ignore.Add("me");
            ignore.Add("about");
            ignore.Add("what");
            ignore.Add("is");
            ignore.Add("how");
            ignore.Add("your");
            
        }//end of ignore_words method
    
            private string Response(string input)
        {
            string[] words = input.Split(' ');
            ArrayList filteredWords = new ArrayList();

            // Filter out ignored words
            foreach (string word in words)
            {
                if (!ignore.Contains(word))
                {
                    filteredWords.Add(word);
                }
            }//end of foreach 

            // Check if the keyword matches in responses
            for (int i = 0; i < keyWords.Count; i++)
            {
                if (filteredWords.Contains(keyWords[i]))
                {
                    return responses[i].ToString();
                }
            }

            return "I don't quite understand that. Please ask me something related to cybersecurity.";
        }//end of response method
    }//end of class
}//end of namespace

