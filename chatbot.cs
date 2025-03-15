using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace POE_part_1_practice
{
    public class chatbot
    {

        //first arraylist stores the answer of the user
        ArrayList responses = new ArrayList();
        //second arrayist filters the answer( by picking out keywords)
        ArrayList ignore = new ArrayList();

      
        public chatbot()
        {
            //Call method in here
            ai_chat();
            stored_responses();
            ignore_words();


            //prompt user for the question
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("AIChat:-> How can I assist you today?");

            string ask = Console.ReadLine();

            //split the question and store in 1D array
            ArrayList correct_filtered = new ArrayList();
            //the variable 'ask' will hold the question 
            string[] filtered_questions = ask.Split(' ');
            

            //then display the answer using the for loop
            //as it searches it should filter more

            Boolean found = false;
            for (int count = 0; count < filtered_questions.Length; count++)
            {
                Console.WriteLine(filtered_questions[count]);
                //final filter
                if (!ignore.Contains(filtered_questions[count]))
                {
                    //then assign to true
                    found = true;

                    //then add the value to correct filtered
                    correct_filtered.Add(filtered_questions[count]); //done with filtering
                }
            }
            //check if found
            if (found)
            {
                //Use for loop to show the answers
                for (int counting = 0; counting < correct_filtered.Count; counting++)
                {
                    //then display the answer (using nested for loop)
                    for (int count = 0; count < responses.Count; count++)
                    {
                        //finally display the found one
                        if (responses[count].ToString().Contains(correct_filtered[counting].ToString()))
                        {

                            //output 
                            Console.WriteLine(responses[count].ToString());
                        }
                    }
                }

            }
            else { Console.WriteLine("Please search something related to cyber!"); }
        }//end of constructor

        //method for the AI chatbot
        public void ai_chat()
        {
            //Welcome user
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to the Cyber Security Awareness Bot");
            Console.WriteLine("================================================================================\n");

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
            Console.WriteLine("AIChat:-> Hi " + name + "!");

            //User input
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("User " + name + ":-> ");
            //reading user input
            Console.ReadLine();
        }
            //Start filtering here
            //then store responses using a method 
            private void stored_responses() {
            responses.Add("I am great thanks! ");
            responses.Add("I am designed to enhance cybersecurity awareness, generate responses to security incidents\n" +
            " and provide guidance on cybersecurity best practices such as recognizing phishing attempts, securing passwords\n" +
            " and avoiding social engineering attacks!");
            responses.Add("You can ask me about anything related to cybersecurity.");
        }

        //method for ignore words
        private void ignore_words()
        {
            ignore.Add("tell");
            ignore.Add("me");
            ignore.Add("about");
            ignore.Add("what");
            ignore.Add("is");

        }//end of ignore_words method
  
    }//end of class
    }//end of namespace
