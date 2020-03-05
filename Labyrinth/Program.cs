using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Labyrinth
{
    class Program
    {
        static void Main(string[] args) //Test
        {
            Console.WriteLine("You walked into my labyrinth, were no one has yet to get out alive.");
            Thread.Sleep(2000);

            Console.WriteLine("Do you have what it takes to be the first one make it?");
            Thread.Sleep(1500);

            Console.WriteLine("It wont be easy" + "\n[*`w´*]");
            Thread.Sleep(3500);

            WaitClear();

            string start = " an empty room with one door";
            string r1 = " basement";
            string r2 = " corridor";
            string r3 = " observation room";
            string r4 = " labratory";
            string r5 = " stobe cupboard";
            string r6 = " locker room";
            string r7 = " outside";
            string r8 = " gym";
            string s2 = " elevator";
            string s1 = " stairs";
            // "\nA []" + "\nB []" +"\nC []"
            string[] answ = { "1", "2", "3", "4", "5", "6", "7"};
            bool goal = false;
            bool GotKeys = false;
            bool LockersChecked1 = false;
            bool LockersChecked2 = false;
            bool LockUnlocked = false;
            Random generator = new Random();
            int Lockt;
            Lockt = generator.Next(1, 8);
            string UnLockt = Lockt.ToString();

            string currentRoom = "start";

            while (goal == false)
            {

                if (currentRoom == "start")
                {
                    Console.WriteLine("You find yourself in" + start);
                    Thread.Sleep(1050);
                    Console.WriteLine("what do you do?" +
                        "\nA [Open the door]" +
                        "\nB [Walk around in circles]" +
                        "\nC [Start a stare contest with the door]");

                    string input = CheckAnswer();

                    if (input == "C" || input == "c")
                    {
                        Clear();
                        Console.WriteLine("You stare at eachother for a while.");
                        Thread.Sleep(3000);
                        Console.WriteLine("You blinked and lost!");
                    }

                    if (input == "B" || input == "b")
                    {
                        Clear();
                        Console.WriteLine("You walked around in a circle.");
                    }

                    if (input == "A" || input == "a")
                    {
                        Clear();
                        Console.WriteLine("You opened the door and got into an" + r1 + ".");
                        Thread.Sleep(500);
                        Console.WriteLine("\nThe door you went thru closed.");
                        currentRoom = "basement";
                    }
                }


                else if (currentRoom == "basement")
                {
                    Console.WriteLine("In the" + r1 + " you see two doors, one on the left and one on the right." +
                        "\nA [Go thru the left door]" +
                        "\nB [Go thru the right door]" +
                        "\nC [Turn around and open the door behind you]");

                    string input = CheckAnswer();

                    if (input == "A" || input == "a")
                    {
                        Clear();
                        Console.WriteLine("You opened the left door and got into an " + r5 + ".");
                        Thread.Sleep(1000);
                        currentRoom = "stobe cupboard";
                    }

                    if (input == "B" || input == "b")
                    {
                        Clear();
                        Console.WriteLine("You opened the right door and got into an " + r2 + ".");
                        Thread.Sleep(1000);
                        currentRoom = "corridor";
                    }

                    if (input == "C" || input == "c")
                    {
                        Clear();
                        Console.WriteLine("You try to open the door but fails and fall on you butt.");
                    }

                    if (input == "Note" || input == "note" || input == "NOTE")
                    {
                        ShowMap();
                    }
                }

                else if (currentRoom == "stobe cupboard")
                {
                    Console.WriteLine("There are a lot of cleaning stuff in here.");
                    Thread.Sleep(1000);
                    Console.WriteLine("What do yo do? \nA [Search the" + r5 + " for something usefull]" +
                        "\nB [Scream for help]" +
                        "\nC [Go back thru the same door]");

                    string input = CheckAnswer();

                    if (input == "A" || input == "a")
                    {
                        int Chance = generator.Next(1, 101);

                        if (Chance <= 79)
                        {
                            Clear();
                            Console.WriteLine("You look around and find nothing but cleaning stuff, which are useless.");
                            Thread.Sleep(1500);
                        }

                        else if (Chance >= 80)
                        {
                            Clear();
                            Console.WriteLine("You see a note behind a bucket and desides to take it with you");
                            Thread.Sleep(1500);
                            Console.WriteLine("You can read the note by writing [note] at any time.");
                            Thread.Sleep(1500);
                            //karta om vänster/häger/raktfram i labyrinten. "hur man klarar den".
                            //haveMap = true;
                        }
                    }

                    if (input == "B" || input == "b")
                    {
                        Clear();

                        Console.WriteLine("You hear your scream for `HELP!´ ecoing in the ventelationsystem above you.");
                        Thread.Sleep(1500);
                    }

                    if (input == "C" || input == "c")
                    {
                        Console.WriteLine("You turn around and open the door and walk through it.");
                        Thread.Sleep(1500);

                        currentRoom = "basement";

                        WaitClear();
                    }

                    if (input == "Note" || input == "note" || input == "NOTE")
                    {
                        ShowMap();
                    }
                }

                else if (currentRoom == "corridor")
                {
                    Console.WriteLine("This" + r2 + " is wierdly scarry, with 3 doors." +
                    "\nOne door at the end of the" + r2 +
                    ", and an elevator on the left side in the middle of the" + r2 +
                    " and the last door was the one you got thru.");
                    Thread.Sleep(2000);
                    Console.WriteLine("What do yo do? \nA [Go thru the door at the end of this corridor]" +
                        "\nB [Use the elevator in middle of the corridor]" +
                        "\nC [Go back thru the door you came from]");

                    string input = CheckAnswer();

                    if (input == "A" || input == "a")
                    {
                        Console.WriteLine("You walk up to the door at the end of the corridor and it opens up automaticaly.");
                        Thread.Sleep(1000);

                        Console.WriteLine("You find yourself in an abandond" + r6 + ".");
                        Thread.Sleep(1000);

                        currentRoom = "lockerroom";

                        WaitClear();
                    }

                    if (input == "B" || input == "b")
                    {
                        Console.WriteLine("You walk up to the" + s2 + " and presses the button.");
                        Thread.Sleep(750);
                        Console.WriteLine("The" + s2 + " doors opens up and you go in.");
                        currentRoom = "elevator";

                        WaitClear();
                    }

                    if (input == "C" || input == "c")
                    {
                        Console.WriteLine("You go back thru the door and get into" + r2 + ".");
                        Thread.Sleep(1000);

                        currentRoom = "basement";
                    }

                    if (input == "Note" || input == "note" || input == "NOTE")
                    {
                        ShowMap();
                    }
                }

                else if (currentRoom == "lockerroom")
                {
                    Console.WriteLine("You can smell the warm sweaty and old scent as you walk into the lockerroom.");
                    Console.WriteLine("You see 15 lockers and 7 of them are locked." +
                        "\nAnd to your left you see some old pair of training shorts.");

                    Console.WriteLine("\nA [Go back thru the door you came from]" +
                        "\nB [Smell the training shorts]" +
                        "\nC [Look thru som of the lockers]");

                    string input = CheckAnswer();

                    if (input == "A" || input == "a")
                    {
                        Clear();

                        Console.WriteLine("You go back thru the door and get into" + r2 + ".");
                        Thread.Sleep(1000);

                        currentRoom = "corridor";
                    }

                    if (input == "B" || input == "b")
                    {
                        Clear();

                        Console.WriteLine("you pick up the shorts.");

                        int Keys = generator.Next(1, 101);

                        if (Keys <= 59 && GotKeys == false)
                        {
                            GotKeys = true;

                            Console.WriteLine("As you pick up the shorts you realise that some thing drops out from them.");
                            Thread.Sleep(1700);

                            Console.WriteLine("You look closer at the droped object as you put back the shorts " +
                                "and identify it as a key.");
                            Thread.Sleep(2500);

                            Console.WriteLine("Its probably for one of the locks in this lockerroom, but which one?");
                            Thread.Sleep(1700);
                        }

                        else if (Keys >= 60)
                        {
                            Console.WriteLine("When you look closer at the object, you see that it´s only some dirt.");
                            Thread.Sleep(1500);

                            Console.WriteLine("You put back the shorts.");
                            Thread.Sleep(1000);
                        }
                    }

                    if (input == "C" || input == "c")
                    {
                        Clear();

                        if (GotKeys == false && LockersChecked1 == false)
                        {
                            LockersChecked1 = true;

                            Console.WriteLine("You look thru the lockers with no locks since you cant open them.");
                            Thread.Sleep(1000);

                            Console.WriteLine("You cant find anything except some moldy fruits.");
                            Thread.Sleep(1750);
                        }

                        else if (GotKeys == true && LockersChecked2 == false)
                        {
                            Console.WriteLine("You look at the locks for a hint on wich lock matches the key.");
                            Thread.Sleep(1000);

                            Console.WriteLine("You cant really see any direct hint of which lock the key matches." +
                                "So you basically have to guess.");
                            Thread.Sleep(1000);

                            Console.WriteLine("The lockers are on the numbers [1-7]" +
                                "which do you think it is?");

                            string guess = Console.ReadLine();

                            while (!answ.Contains(guess))
                            {
                                Console.WriteLine("Not a valid choice, try again");
                                Console.WriteLine("Only accepting [1-7] as an answer.");

                                guess = Console.ReadLine();
                            }

                            if (guess == UnLockt)
                            {
                                Console.WriteLine("You tried number " + guess + " and the key did fit perfectly.");
                                Thread.Sleep(2000);

                                Console.WriteLine("You open up the locker and a bright yellow~orange light streams out from it." +
                                    "\n Its so bright that you have to close your eyes and cover them with one of your arms.");
                                Thread.Sleep(4000);

                                Console.WriteLine("When the shiny light has dampened, you see a super fancy and fresh flashlight and decides to take it.");
                                Thread.Sleep(3000);

                                LockersChecked2 = true;
                            }

                            else if (guess != UnLockt)
                            {
                                Console.WriteLine("You tried number " + guess + " and the key did´nt fit at all.");
                                Thread.Sleep(1500);

                                Console.WriteLine("Try again");
                                Thread.Sleep(1000);
                            }

                            else if (LockersChecked2 == true && LockersChecked1 == true)
                            {
                                Console.WriteLine("Searching...");
                                Thread.Sleep(2000);

                                Console.WriteLine("You cant find anything new.");
                                Thread.Sleep(1000);
                            }

                            else if (LockersChecked2 == true && LockersChecked1 == false)
                            {
                                Console.WriteLine("Searching...");
                                Thread.Sleep(45000);

                                Console.WriteLine("You cant find anything new in the lockers with locks." +
                                    "But you search the unlocked lockers.");
                                Thread.Sleep(2000);

                                Console.WriteLine("You cant find anything except some moldy fruits.");
                                Thread.Sleep(1000);

                                LockersChecked1 = true;
                            }

                            else if (GotKeys == false && LockersChecked1 == true)
                            {
                                Console.WriteLine("You try to open some of the locked lockers but it just hurts your hands.");
                                Thread.Sleep(1500);

                                Console.WriteLine("There must be some kind of tool or maybe even a key around here somewhere.");
                                Thread.Sleep(1500);
                            }

                        }

                        if (input == "Note" || input == "note" || input == "NOTE")
                        {
                            ShowMap();
                        }
                    }
                }

                else if (currentRoom == "elevator")
                {
                    Console.WriteLine("The doors slamshut and the" + s2 + " starts to go upwards.");

                    Console.WriteLine("\nA [Go back thru the door you came from]" +
                        "\nB [Smell the training shorts]" +
                        "\nC [Look thru som of the lockers]");

                    string input = CheckAnswer();

                        if (input == "Note" || input == "note" || input == "NOTE")
                        {
                            ShowMap();
                        }
                }

            }

        }

        static string CheckAnswer()
        {
            string[] ans = { "A", "B", "C", "a", "b", "c", "NOTE", "note", "Note" };

            string input = Console.ReadLine();

            while (!ans.Contains(input))
            {
                Console.WriteLine("Not a valid choice, try again");
                Console.WriteLine("Only accepting a, b, c or note as an answer.");

                input = Console.ReadLine();
            }

            return input;
        }

        static void Clear()
        {
            Console.Clear();
        }

        static void WaitClear()
        {
            Thread.Sleep(2000);

            Console.Clear();
        }

        static string ShowMap()
        {
            string itemMap = "1A 2B 3 4 5";

            Console.WriteLine("You open up the note and read it.");
            Console.WriteLine(itemMap);

            return itemMap;
        }
    }

}
