

/*
The Twelfth short, really bad console game by Yand
Personal Deadline: 3/10/2022
Deadline Achieved: N/A
*/






using System;
using static System.Console;
using static System.Threading.Thread;

namespace workspace
{   


class AsciiVariables
    {

protected const string title = @"
(  OO) )   ( OO )  /  _(  OO)        (  OO) )      `.( OO ),' _(  OO)                         (  OO) )   ( OO )  / 
/     '._  ,--. ,--. (,------.       /     '._  ,--./  .--.  (,------.  ,--.         ,------. /     '._  ,--. ,--. 
|'--...__) |  | |  |  |  .---'       |'--...__) |      |  |   |  .---'  |  |.-')  ('-| _.---' |'--...__) |  | |  | 
'--.  .--' |   .|  |  |  |           '--.  .--' |  |   |  |,  |  |      |  | OO ) (OO|(_\     '--.  .--' |   .|  | 
   |  |    |       | (|  '--.           |  |    |  |.'.|  |_)(|  '--.   |  |`-' | /  |  '--.     |  |    |       | 
   |  |    |  .-.  |  |  .--'           |  |    |         |   |  .--'  (|  '---.' \_)|  .--'     |  |    |  .-.  | 
   |  |    |  | |  |  |  `---.          |  |    |   ,'.   |   |  `---.  |      |    \|  |_)      |  |    |  | |  | 
   `--'    `--' `--'  `------'          `--'    '--'   '--'   `------'  `------'     `--'        `--'    `--' `--' ";
        
        
protected const string abt = @"     
  ( OO ).-. \  ( OO )                            (  OO) )   
  / . --. /  ;-----.\   .-'),-----.  ,--. ,--.   /     '._  
  | \-.  \   | .-.  |  ( OO'  .-.  ' |  | |  |   |'--...__) 
.-'-'  |  |  | '-' /_) /   |  | |  | |  | | .-') '--.  .--' 
 \| |_.'  |  | .-. `.  \_) |  |\|  | |  |_|( OO )   |  |    
  |  .-.  |  | |  \  |   \ |  | |  | |  | | `-' /   |  |    
  |  | |  |  | '--'  /    `'  '-'  '('  '-'(_.-'    |  |    
  `--' `--'  `------'       `-----'   `-----'       `--' ";
protected const string StarrySky = @"
    .         _  .          .          .    +     .          .          .      .
        .(_)          .            .            .            .       :
        .   .      .    .     .     .    .      .   .      . .  .  -+-        .
          .           .   .        .           .          /         :  .
    . .        .  .      /.   .      .    .     .     .  / .      . ' .
        .  +       .    /     .          .          .   /      .
       .            .  /         .            .        *   .         .     .
      .   .      .    *     .     .    .      .   .       .  .
          .           .           .           .           .         +  .
  . .        .  .       .   .      .    .     .     .    .      .   .

 .   +      .          ___/\_._/~~\_...__/\__.._._/~\        .         .   .
       .          _.--'                              `--./\          .   .
           /~~\/~\      `    |||      ~                    `-/~\_            .
 .      .-'                                     .                `-/\_
  _/\.-'       ;               ,                  ///            __/~\/\-.__
.'                                                                           `.
";

    }




    class Menu
    {

        private int selectedIndex;
        private string[] Options;
        private string Prompt;

        public Menu(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            selectedIndex = 0;
        }

        private void DisplayOptions()
        {
            WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++)
            {
                string CurrentOption = Options[i];
                string prefix;

                if (i == selectedIndex)
                {
                    prefix  = "^";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = " ";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }

                WriteLine($"{prefix} << {CurrentOption} >>");
            }
            ResetColor();
        }
        public int Run()
        {
            ConsoleKey KeyPressed;
            do 
            {
                Clear();
                DisplayOptions();

                ConsoleKeyInfo KeyInfo = ReadKey(true);
                KeyPressed = KeyInfo.Key;
                // Update selectedIndex
                if (KeyPressed == ConsoleKey.DownArrow)
                {
                    selectedIndex++;
                    if (selectedIndex == Options.Length)
                    {
                        selectedIndex = 0;
                    }
                }
                else if (KeyPressed == ConsoleKey.UpArrow)
                {
                    selectedIndex--;
                    if (selectedIndex == -1)
                    {
                        selectedIndex = Options.Length - 1;
                    }
                }
                
               
            } while (KeyPressed != ConsoleKey.Enter);

            return selectedIndex;
        }
    }


    class game : AsciiVariables
{


private const string ActionPrompt = "What will you do?";
private int killCount = 0;
private int mercyCount = 0;

        
        public void Start()
        {
            Title = "The Twelfth";    
            RunMainMenu();

        }

        private void RunMainMenu() 
        {
            string prompt = title;
            string[] options = { "Play", "About", "Exit" };
            Menu MainMenu = new Menu(prompt, options);
            int selectedIndex = MainMenu.Run();
        

        switch (selectedIndex)
        {
            
            case 0:
                RunGame();
                break;

            case 1:
                AboutBTN();
                break;

            case 2:
                ExitGame();
                break;
        
    }

        }
    


    private void RunGame()
    {   

        Clear();
        string prompt = ActionPrompt;
        string[] options = {"Pack your stuff and head for home", "Wait until dusk", "Explore the nearby forest"};
        Menu FirstPromptMenu = new Menu(prompt, options);
        WriteLine($"{StarrySky}\nThe depth of the starry sky tonight fills you with hope.\n\nYou wonder about how big the universe actually is..");
        Thread.Sleep(2000);
        int selectedIndex = FirstPromptMenu.Run();

        switch (selectedIndex)
        {
            
            case 0:
            HeadHome();
            break;
            
            case 1:
            WriteLine("Current Time: ");
            break;

            case 2:
            WriteLine("Placeholder");
            break;
            
        }
    }   

    private void AboutBTN()
    {
        Clear();
        WriteLine($"{abt}\nThe Twelfth is a 'choose your own adventure' rpg game by Yand made for the Binary Box community project ");
    WriteLine("Press any key to return to the main menu");
    ReadKey(true);
    RunMainMenu();

    } 

    private void ExitGame()
    {   
        WriteLine("Press any key to exit");
        ReadKey(true);
        Environment.Exit(0);
    }

    private void HeadHome()
    {
        
                WriteLine("You head for your bag.");
                Thread.Sleep(3000);
                WriteLine("It's empty?\n the things must've been stolen!");
                Thread.Sleep(3000);
                WriteLine("You run around the woods looking for your things.\n\n\nYou run so quick that you bump into a tree and..");
                Thread.Sleep(3000);
                Clear();
                ForegroundColor = ConsoleColor.Yellow;
                // WriteLine("Warning");
                // Thread.Sleep(2000);
                // Clear();
                // Thread.Sleep(2000);
                // WriteLine("Warning");
                // Thread.Sleep(2000);
                // Clear();
                // Thread.Sleep(2000);
                // WriteLine("Warning");
                // Thread.Sleep(2000);
                // Clear();
                // Thread.Sleep(5000);
                // Clear();
                // ForegroundColor = ConsoleColor.Red;
                // WriteLine("You have no-clipped outside of REALITY 12. Transporting to THE INBETWEEN");
                // Thread.Sleep(1000);
                // Clear();
                // Thread.Sleep(1500);
                // WriteLine("You have no-clipped outside of REALITY 12. Transporting to THE INBETWEEN");
                // Thread.Sleep(1000);
                // Clear();
                // Thread.Sleep(1500);
                // WriteLine("You have no-clipped outside of REALITY 12. Transporting to THE INBETWEEN");
                // Thread.Sleep(1000);
                // Clear();
                // Thread.Sleep(1500);
                // WriteLine("You have no-clipped outside of REALITY 12. Transporting to THE INBETWEEN");
                // Thread.Sleep(1000);
                // Clear();
                // Thread.Sleep(1500);
                // WriteLine("You have no-clipped outside of REALITY 12. Transporting to THE INBETWEEN");
                // Thread.Sleep(1000);
                // Clear();
                // Thread.Sleep(1500);
                // WriteLine("You have no-clipped outside of REALITY 12. Transporting to THE INBETWEEN");
                // Thread.Sleep(1000);
                // Clear();
                // Thread.Sleep(1500);
                // WriteLine("You have no-clipped outside of REALITY 12. Transporting to THE INBETWEEN");
                // Thread.Sleep(1000);
                // Clear();
                // Thread.Sleep(1500);
                // WriteLine("You have no-clipped outside of REALITY 12. Transporting to THE INBETWEEN");
                // Thread.Sleep(1000);
                // Clear();
                // Thread.Sleep(1500);
                // WriteLine("You have no-clipped outside of REALITY 12. Transporting to THE INBETWEEN");
                // Thread.Sleep(1000);
                // Clear();
                // Thread.Sleep(5000);
                ResetColor();

                WriteLine("Successfully transported to THE INBETWEEN.");
                Thread.Sleep(5000);
                Clear();
                Thread.Sleep(2000);
                
                string prompt = "There is some sort of bulletin board..";
                string[] options = {"Read the paper","Walk on..."};
                Menu Inbetween1 = new Menu(prompt, options);
                int selectedIndex = Inbetween1.Run();

                switch (selectedIndex)
                {
                    case 0:
                    WriteLine("You read the first paper\n\n\n");
                    WriteLine("Welcome to THE INBETWEEN where all mistakes a cheaters can share one place..");
                    WriteLine("What are cheaters, you ask? well, probably you. a cheater is one who cheats their way out of reality and, as a punishment, ends up in THE INBETWEEN..\n\nForever.");
                    WriteLine("Have 'fun'\nYour's Truly,\nThe Universe");
                    ReadKey();
                    Clear();
                    Thread.Sleep(2000);
                    WalkOn();

                    break;  

                    case 1:
                    WalkOn();
                    break;
                }

    }

    private void WalkOn()
    {
        WriteLine("* You walk on from the bulletin board...");
        WriteLine("* You encounter a mysterious (monster?) wearing a t-shirt that has the word 'GUIDE' on it.");
        WriteLine("Guy: Here for being a cheater or a mistake?");
        Thread.Sleep(10000);
        WriteLine("* What will you s-");
        Thread.Sleep(8000);
        WriteLine("Guy: I really don't care to be honest.");
        Thread.Sleep(8000);
        WriteLine("Guy: Anyway I'm Guy and if ya got any questions about THE INBETWEEN then don't feel free to ask because as i said i literally can't care less");
        Thread.Sleep(5000);
        WriteLine("Guy: Anyway just don't cause trouble. all you can really do around here is sit and think about what you have done.. Or if your feeling adventurous then you can visit the 12 GATES OF REALITY");
        Thread.Sleep(9000);
        WriteLine("Guy: Which reality did you come from anyway?");
        Thread.Sleep(5000);
        string prompt = "What will you say?";
        string[] options = {"I don't really know.. I don't even know how i entered this place..", "..."};
        Menu GuyMenu1 = new Menu(prompt, options);
        int selectedIndex = GuyMenu1.Run();
        switch (selectedIndex)
        {
            case 0:
            Clear();
            WriteLine("Guy: Ahh, then you're probably a MISTAKE. Mistakes are entities who no-clip out of their realities and as a last resort from the universe, they end up here, in-order not to break space-time");
            Thread.Sleep(3000);
            SameOutcome();
            break;

            case 1:
            WriteLine("Guy: ...");
            SameOutcome();
            break;
        }
        


        }  
        private void SameOutcome()
        {
            WriteLine("Guy: Well, goodluck on the road ahead.. some kids keep fighting everyone they encounter as a form of entertainment.. so.. just watch out..");
            Thread.Sleep(1000);
            WriteLine("* You nod and walk on.. nervously");
            Thread.Sleep(4000);
            WriteLine("* As you're walking you find a KNIFE");
            Thread.Sleep(1000);
            WriteLine("* Step..");
            Thread.Sleep(1000);
            WriteLine("* Step..");
            Thread.Sleep(1000);
            WriteLine("* Step..");
            Thread.Sleep(1000);
            WriteLine("* Step..");
            Thread.Sleep(2000);
            WriteLine("* You encounter GANG KIDS");
            string prompt = "What will you do";
            string[] options = {"Kill", "Mercy"};
            Menu GangKidsMenu = new Menu(prompt, options);
            int selectedIndex = GangKidsMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                KidsDieOutcome();
                break;

                case 1:
                KidsMercyOutcome();
                break;

            }




             
        }

        private void KidsDieOutcome()
        {
            WriteLine("* The kids.. died.. How cruel...");
            killCount += 1;
            coins += rand.Next(1,101);
            WriteLine("Press any key to continue..");
            ReadKey();
            GangKidsOutcome();
        }
        private void KidsMercyOutcome()
        {
            WriteLine("The kids felt happy that someone finally didnt yell at them or hit them.. The kids give you a hug and run away");
            mercyCount += 1;
            WriteLine("Press any key to continue..");
            ReadKey();
            GangKidsOutcome();

        }

        private void  GangKidsOutcome()
        {
            WriteLine("You continue walking...");
            Thread.Sleep(5000);
            WriteLine("* You have approached REALITY GATE 7");
            Thread.Sleep(7000);
            string prompt = ActionPrompt;
            string[] options = {"Enter", "Walk on.."};
            Menu Gate7Choice = new Menu(prompt, options);
            int selectedIndex = Gate7Choice.Run();

            switch (selectedIndex)
            {
                case 0:
                EnterGatePrompt(RealityGateNo, ending);
                break;

                case 1:
                EncounterBuB();
                break;



            }

        }

        private int RealityGateNo;

        private void EncounterBuB()
        {
            WriteLine("* You walk on..");
            Thread.Sleep(3000);
            WriteLine("*You encounter BuB");
            WriteLine("*Bub tries to attack? BuB is slow");
            string prompt = ActionPrompt;
            string[] options = {"Attack", "Mercy"};
            Menu BubChoice = new Menu(prompt, options);
            int selectedIndex = BubChoice.Run();

            switch (selectedIndex)
            {
                case 0:
                KillBuB();
                SameBubOutcome();
                break;

                case 1:
                SpareBuB();
                SameBubOutcome();
                break;
            }            
        }

        private void KillBuB()
        {
            killCount += 1;
            WriteLine("BuB died");
            coins += rand.Next(1,101);
        }

        private void SpareBuB()
        {
            mercyCount += 1;
            WriteLine("You spared BuB");
        }

        private void SameBubOutcome()
        {
            WriteLine("You continue walking on..");
        }

        private void EnterGatePrompt(int RealityGateNo, string ending)
        {
            RealityGateNo = 7;
            ending = "Freedom Ending";
            WriteLine("Warning! Entering any gate will mark the end of your journey. Are you sure you want to enter?\nYou will have to restart to discover other possible endings.");
            Thread.Sleep(3000);
            string prompt = "Are you sure?";
            string[] options = {"Enter", "Nevermind..."};
            Menu EnterGateSure = new Menu(prompt, options);
            int selectedIndex = EnterGateSure.Run();
            switch (selectedIndex)
            {
                case 0:
                BackgroundColor = ConsoleColor.White;
                ForegroundColor = ConsoleColor.Black;
                WriteLine($"* You have entered Reality Gate {RealityGateNo}");
                WriteLine("* Your journey has come to an end..");
                WriteLine($"You escaped THE INBETWEEN..\nYou now live in REALITY {RealityGateNo}.. REALITY OF LUCK");
                Thread.Sleep(10000);
                Clear();
                Thread.Sleep(5000);
                EndScreen3(ending, endingno);
                Thread.Sleep(8000);
                Credits();
                break;

                case 1:
                GangKidsOutcome();
                break;
            }
        }

        private string ending;
        private int endingno;

        private void EndScreen1(string ending, int endingno)
        {
            ending = "Good Ending";
            endingno = 1;
            WriteLine($"You have achieved {ending}\n\nEnding {endingno}");

        }

        private void EndScreen2(string ending, int endingno)
        {
            ending = "Bad Ending";
            endingno = 2;
            WriteLine($"You have achieved {ending}\n\nEnding {endingno}");

        }

        private void EndScreen3(string ending, int endingno)
        {
            ending = "Freedom Ending";
            endingno = 3;
            WriteLine($"You have achieved {ending}\n\nEnding {endingno}");

        }

        private void EndScreen4(string ending, int endingno)
        {
            ending = "Genocide Ending";
            endingno = 4;
            WriteLine($"You have achieved {ending}\n\nEnding {endingno}");

        }

        private void EndScreen5(string ending, int endingno)
        {
            ending = "Merciful Ending";
            endingno = 5;
            WriteLine($"You have achieved {ending}\n\nEnding {endingno}");

        }

        private void Credits()
        {
            Write("Programming - Yand, ");
            Thread.Sleep(2500);
            Write("'story?' - Yand");
            Thread.Sleep(2500);
            WriteLine("Guy - Guy");
        }


        private void DetermineEnding()
        {
            if (killCount == 10 & mercyCount == 0)
            {
                // Genocide Ending
                WriteLine($"You have killed {killCount} entities and spared {mercyCount}.. and you ended your journey with {coins} coins");
                Thread.Sleep(2500);
                WriteLine("You have achieved the GENOCIDE ENDING");
                Thread.Sleep(4000);
                WriteLine("The Inbetween is now devoid of life. The Universe thanks you. your services will not be forgotten");
                Thread.Sleep(25000);
                ForegroundColor = ConsoleColor.Red;
                WriteLine("You are the reincarnate of the devil");
                ResetColor();
            }
            else if (mercyCount == 10 & killCount == 0)
            {
                // Merciful Ending
                WriteLine($"You have spared {mercyCount} and killed {killCount}..");
                Thread.Sleep(2500);
                WriteLine("You have achieved the MERCIFUL ENDING");
                Thread.Sleep(3000);
                WriteLine("The Inbetween is much more lively and happy than it was before.");
                Thread.Sleep(5000);
                WriteLine("Your soul is pure. The Universe is proud");
            }
            else
            {
                // Good/Bad ending
                WriteLine("Placeholder");
            }
        }

        Random rand = new Random();
        int coins = 0;
        private void ItemShop()
        {
            //Item Shop
        }

    }



    class Program
    {

        static void Main(string[] args)
        {
            game myGame = new game();
            myGame.Start();
        }

    }
}
