using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchPad.WebGen
{
    public class UI_WG
    {
        private bool doesUserWantJSFolder;
        private bool doesUserWantCSSFolder;

        // Getters/Setters
        public bool Get_DoesUserWantJSFolder()
        {
            return doesUserWantJSFolder;
        }

        public void Set_DoesUserWantJSFolder(bool doesUserWantJSFolder)
        {
            this.doesUserWantJSFolder = doesUserWantJSFolder;
        }

        public bool Get_DoesUserWantCSSFolder()
        {
            return doesUserWantCSSFolder;
        }

        public void Set_DoesUserWantCSSFolder(bool doesUserWantCSSFolder)
        {
            this.doesUserWantCSSFolder = doesUserWantCSSFolder;
        }


        // Main methods... 
        public void Run()
        {
            SiteNamePrompt();
            AuthorNamePrompt();
            FolderJSPrompt();
            FolderCSSPrompt();
        }

        public string SiteNamePrompt()
        {
            Console.Write("What is the name of the site?: ");

            return Console.ReadLine();

        }

        public string AuthorNamePrompt()
        {
            Console.Write("Who is the author?: ");

            return Console.ReadLine();

        }

        public void FolderJSPrompt()
        {
            Console.Write("Would you like to create a folder for JSFiles? (y/n): ");
            string userInput = Console.ReadLine().ToLower();  

            if (userInput == "y")
            {
                Set_DoesUserWantJSFolder(true);
            }
            else if (userInput == "n")
            {
                Set_DoesUserWantJSFolder(false);
            }
        }


        public void FolderCSSPrompt()
        {
            Console.Write("Would you like to create a folder for CSSFiles? (y/n): ");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "y")
            {
                Set_DoesUserWantCSSFolder(true);
            }
            else if (userInput == "n")
            {
                Set_DoesUserWantCSSFolder(false);
            }
        }








    }
}
