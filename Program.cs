using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityAwarenessBot
{//start of namespace
    public class Program
    {//start of class
        static void Main(string[] args)
        {//start of main method

            //creating an instance for the class voice_logo
            //without an object name but a constructor
            new voice_logo() { };
            Text_based_greeting_and_user_interaction chat =      new Text_based_greeting_and_user_interaction();
            chat.ask_user();
            chat.welcome();
            chat.Basic_Response_System();
        }//end of main method
    }//end of class
}//end of namespace
