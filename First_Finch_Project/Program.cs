﻿using System;
using System.Collections.Generic;
using System.IO;
using FinchAPI;

namespace Project_FinchControl
{

    // ***************************************************
    //
    // Title: First Finch Program
    // Description: 
    // Application Type: Console
    // Author: Tanner McLean
    // Dated Created: 2/1/2020
    // Last Modified: 3/21/2021
    //
    // **************************************************

    //
    //Enum for user programming
    //
    public enum Command
    {
        none,
        moveforward,
        movebackward,
        stopmotors,
        wait,
        turnright,
        turnleft,
        ledon,
        ledoff,
        gettemperature,
        buzzeron,
        buzzeroff,
        done

    }



    class Program
    {

        ///  
        /// first method run when the app starts up
        ///  
        static void Main(string[] args)
        {
            
            SetTheme();

            DisplayWelcomeScreen();
            menuScreen();
            DisplayClosingScreen();
        }

        #region METHODS
        ///  
        /// setup the console theme
        ///  
        static void SetTheme()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
        }

        ///  
        /// *****************************************************************
        /// *                     Main Menu                                 *
        /// *****************************************************************
        ///  
        static void menuScreen()
        {
            Console.CursorVisible = true;

            bool quitApplication = false;
            string menuChoice;

            Finch doofus = new Finch();

            do
            {
                DisplayScreenHeader("Main Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Connect Finch Robot");
                Console.WriteLine("\tb) Talent Show");
                Console.WriteLine("\tc) Data Recorder");
                Console.WriteLine("\td) Alarm System");
                Console.WriteLine("\te) User Programming");
                Console.WriteLine("\tf) File Use Demo");
                Console.WriteLine("\tg) Disconnect Finch Robot");
                Console.WriteLine("\tq) Quit");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        connectdoofus(doofus);
                        break;

                    case "b":
                        TalentShowmenuScreen(doofus);
                        break;

                    case "c":
                        dataRecorderMenu(doofus);
                        break;

                    case "d":

                        break;

                    case "e":
                        userProgrammingMenuScreen(doofus);
                        break;

                    case "f":
                        fileIOProgram();
                        break;

                    case "g":
                        DisplayDisconnectdoofus(doofus);
                        break;

                    case "q":
                        DisplayDisconnectdoofus(doofus);
                        quitApplication = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        continueScreen();
                        break;
                }

            } while (!quitApplication);
        }

        #region FileIO
        //
        //File IO main
        //
        private static void fileIOProgram()
        {
            string dataPath = @"Data\Data.txt";
            string userInput = "";
            string userInput2 = "";
            string userInputP = "";
            string userInput2P = "";
            bool validResponse = true;
            //
            //show valid background colors
            //
            DisplayScreenHeader("Theme Change");
            Console.WriteLine();
            Console.WriteLine("\tHere are the valid background color choices:");
            Console.WriteLine();
            Console.WriteLine("\tBlack, Blue, Cyan, Green, Yellow, White, Red, Magenta, Gray,");
            Console.WriteLine();
            Console.WriteLine("\tDarkBlue, DarkCyan, DarkGray, DarkGreen, DarkRed, DarkYellow, and DarkMagenta");
            Console.WriteLine();
            Console.WriteLine();

            //
            //user enters and it validates
            //
            do
            {
                validResponse = true;
                Console.WriteLine();
                Console.Write("\tYour Choice of Background color: ");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "Red":
                        Console.WriteLine();
                        Console.WriteLine("You entered: Red for a Background Color");
                        validResponse = true;
                        break;

                    case "Black":
                        Console.WriteLine();
                        Console.WriteLine("You entered: Black for a Background Color");
                        validResponse = true;
                        break;

                    case "Blue":
                        Console.WriteLine();
                        Console.WriteLine("You entered: Blue for a Background Color");
                        validResponse = true;
                        break;

                    case "Cyan":
                        Console.WriteLine();
                        Console.WriteLine("You entered: Cyan for a Background Color");
                        validResponse = true;
                        break;

                    case "Green":
                        Console.WriteLine();
                        Console.WriteLine("You entered: Green for a Background Color");
                        validResponse = true;
                        break;

                    case "Yellow":
                        Console.WriteLine();
                        Console.WriteLine("You entered: Yellow for a Background Color");
                        validResponse = true;
                        break;

                    case "White":
                        Console.WriteLine();
                        Console.WriteLine("You entered: White for a Background Color");
                        validResponse = true;
                        break;

                    case "Magenta":
                        Console.WriteLine();
                        Console.WriteLine("You entered: Magenta for a Background Color");
                        validResponse = true;
                        break;

                    case "Gray":
                        Console.WriteLine();
                        Console.WriteLine("You entered: Gray for a Background Color");
                        validResponse = true;
                        break;

                    case "DarkBlue":
                        Console.WriteLine();
                        Console.WriteLine("You entered: Dark Blue for a Background Color");
                        validResponse = true;
                        break;

                    case "DarkCyan":
                        Console.WriteLine();
                        Console.WriteLine("You entered: Dark Cyan for a Background Color");
                        validResponse = true;
                        break;

                    case "DarkGray":
                        Console.WriteLine();
                        Console.WriteLine("You entered: Dark Gray for a Background Color");
                        validResponse = true;
                        break;

                    case "DarkGreen":
                        Console.WriteLine();
                        Console.WriteLine("You entered: Dark Green for a Background Color");
                        validResponse = true;
                        break;

                    case "DarkRed":
                        Console.WriteLine();
                        Console.WriteLine("You entered: Dark Red for a Background Color");
                        validResponse = true;
                        break;

                    case "DarkYellow":
                        Console.WriteLine();
                        Console.WriteLine("You entered: Dark Yellow for a Background Color");
                        validResponse = true;
                        break;

                    case "DarkMagenta":
                        Console.WriteLine();
                        Console.WriteLine("You entered: Dark Magenta for a Background Color");
                        validResponse = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a Valid Background Color");
                        validResponse = false;
                        break;
                }

            } while (!validResponse);
            continueScreen();

            //
            //user enters foreground color
            //
            Console.WriteLine();
            Console.WriteLine("\tHere are the valid foreground color choices:");
            Console.WriteLine();
            Console.WriteLine("\tBlack, Blue, Cyan, Green, Yellow, White, Red, Magenta, Gray,");
            Console.WriteLine();
            Console.WriteLine("\tDarkBlue, DarkCyan, DarkGray, DarkGreen, DarkRed, DarkYellow, and DarkMagenta");
            Console.WriteLine();
            Console.WriteLine();
            do
            {
                validResponse = true;
                Console.WriteLine();
                Console.WriteLine("\tNow for a Foreground Color");
                Console.WriteLine();
                Console.WriteLine("\t\tWarning: Entering the same color as the background will make it impossible to see anything");
                Console.WriteLine();
                Console.Write("\tYour Choice of Foreground color: ");
                userInput2 = Console.ReadLine();
                switch (userInput2)
                {
                    case "Red":
                        Console.WriteLine();
                        Console.WriteLine("\tYou entered: Red for a Foreground Color");
                        validResponse = true;
                        break;

                    case "Black":
                        Console.WriteLine();
                        Console.WriteLine("\tYou entered: Black for a Foreground Color");
                        validResponse = true;
                        break;

                    case "Blue":
                        Console.WriteLine();
                        Console.WriteLine("\tYou entered: Blue for a Foreground Color");
                        validResponse = true;
                        break;

                    case "Cyan":
                        Console.WriteLine();
                        Console.WriteLine("\tYou entered: Cyan for a Foreground Color");
                        validResponse = true;
                        break;

                    case "Green":
                        Console.WriteLine();
                        Console.WriteLine("\tYou entered: Green for a Foreground Color");
                        validResponse = true;
                        break;

                    case "Yellow":
                        Console.WriteLine();
                        Console.WriteLine("\tYou entered: Yellow for a Foreground Color");
                        validResponse = true;
                        break;

                    case "White":
                        Console.WriteLine();
                        Console.WriteLine("\tYou entered: White for a Foreground Color");
                        validResponse = true;
                        break;

                    case "Magenta":
                        Console.WriteLine();
                        Console.WriteLine("\tYou entered: Magenta for a Foreground Color");
                        validResponse = true;
                        break;

                    case "Gray":
                        Console.WriteLine();
                        Console.WriteLine("\tYou entered: Gray for a Foreground Color");
                        validResponse = true;
                        break;

                    case "DarkBlue":
                        Console.WriteLine();
                        Console.WriteLine("\tYou entered: Dark Blue for a Foreground Color");
                        validResponse = true;
                        break;

                    case "DarkCyan":
                        Console.WriteLine();
                        Console.WriteLine("\tYou entered: Dark Cyan for a Foreground Color");
                        validResponse = true;
                        break;

                    case "DarkGray":
                        Console.WriteLine();
                        Console.WriteLine("\tYou entered: Dark Gray for a Foreground Color");
                        validResponse = true;
                        break;

                    case "DarkGreen":
                        Console.WriteLine(  );
                        Console.WriteLine("\tYou entered: Dark Green for a Foreground Color");
                        validResponse = true;
                        break;

                    case "DarkRed":
                        Console.WriteLine();
                        Console.WriteLine("\tYou entered: Dark Red for a Foreground Color");
                        validResponse = true;
                        break;

                    case "DarkYellow":
                        Console.WriteLine();
                        Console.WriteLine("\tYou entered: Dark Yellow for a Foreground Color");
                        validResponse = true;
                        break;

                    case "DarkMagenta":
                        Console.WriteLine();
                        Console.WriteLine("\tYou entered: Dark Magenta for a Foreground Color");
                        validResponse = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a Valid Foreground Color");
                        validResponse = false;
                        break;
                }

            } while (!validResponse);

            if (userInput == userInput2)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Alright, you set the foreground AND background colors the same, have fun seeing anything!");
                Console.WriteLine();
                Console.WriteLine("\tPress any button to continue and not see :)");
            }
            else
            {
                Console.WriteLine($"\tYou entered: {userInput} for Background and {userInput2} for Foreground");
                Console.WriteLine();
                Console.WriteLine("\tPress any button to continue and see the changes");
                Console.ReadKey();
            }

            userInputP = userInput + "\n";
            userInput2P = userInput2 + "\n";

            //
            //enter in to data file
            //
            File.WriteAllText(dataPath, userInputP);
            File.AppendAllText(dataPath, userInput2P);
            //
            //Read data
            //
            //string[] userInputs = File.ReadAllLines(dataPath);

            //
            //Try catch
            //
            string errorMessage = "";
            string[] userInputs = null;
            try
            {
                userInputs = File.ReadAllLines(dataPath);
            }
            catch (DirectoryNotFoundException ex)
            {

                Console.WriteLine("Error: Folder not found");
                errorMessage = ex.Message;
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: File not found");
                errorMessage = ex.Message;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: File I/O error");
                errorMessage = ex.Message;
            }
            finally
            {
                if (errorMessage != "")
                {
                    Console.WriteLine(errorMessage);
                }

            }


            //
            //set the colorss
            //
            
            if (Enum.TryParse(userInputs[0], out ConsoleColor background))
            {
                Console.BackgroundColor = background;
            }
            if (Enum.TryParse(userInputs[1], out ConsoleColor text))
            {
                Console.ForegroundColor = text;
            }

            Console.Clear();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("\t Ta Da!");
            continueScreen();

        }


        #endregion

        #region TALENT SHOW

        ///  
        /// *****************************************************************
        /// *                     Talent Show Menu                          *
        /// *****************************************************************
        ///  
        static void TalentShowmenuScreen(Finch doofus)
        {
            Console.CursorVisible = true;

            bool quitTalentShowMenu = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("Talent Show Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Light and Sound");
                Console.WriteLine("\tb) Movement Talent basic");
                Console.WriteLine("\tc) Play a song");
                Console.WriteLine("\td) Color calculator");
                Console.WriteLine("\te) Alarm System");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        TalentShowDisplayLightAndSound(doofus);
                        break;

                    case "b":
                        talentShowMovement(doofus);
                        break;

                    case "c":
                        talentShowSong(doofus);
                        break;

                    case "d":
                        colorCalc(doofus);
                        break;

                    case "e":
                        alarmSystem(doofus);
                        break;


                    case "q":
                        quitTalentShowMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        continueScreen();
                        break;
                }

            } while (!quitTalentShowMenu);
        }

        static int colorCalc(Finch doofus)
        {


            bool validResponse;
            string user1;
            string user2;
            string user3;
            int RedVal;
            int GreenVal;
            int BlueVal;


            DisplayScreenHeader("Color Maker");
            Console.WriteLine("\t You will now be able to control the finch's light!");
            continueScreen();
            Console.WriteLine();
            Console.WriteLine("\t Now please enter 3 valid values for Red, Green, and Blue values");
            Console.WriteLine();
            Console.WriteLine("\t Valid values are from 0 to 255");
            //user enters value 1
            continueScreen();
            Console.WriteLine();
            Console.WriteLine("\t Please enter value 1 (Red), 0-255");
            #region Red
            do
            {
                validResponse = true;

                //
                //insert first number
                //
                Console.WriteLine();
                Console.Write($"\t Value 1: ");
                user1 = Console.ReadLine();
                Console.WriteLine();

                if (!int.TryParse(user1, out RedVal))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits from 0-255");
                    validResponse = false;
                }
                else if ((RedVal >= 256))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits from 0-255");
                    validResponse = false;
                }
                else
                {
                    Console.WriteLine($"\tYou entered: R value of: {RedVal}");

                    continueScreen();
                }

            } while (!validResponse);
            #endregion
            //
            // Value 2 for green
            //
            #region Green
            Console.WriteLine();
            Console.WriteLine("\t Please enter value 2 (Green), 0-255");
            do
            {
                validResponse = true;

                //
                //insert second number
                //
                Console.WriteLine();
                Console.Write($"\t Value 2: ");
                user2 = Console.ReadLine();
                Console.WriteLine();

                if (!int.TryParse(user2, out GreenVal))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits from 0-255");
                    validResponse = false;
                }
                else if ((GreenVal >= 256))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits from 0-255");
                    validResponse = false;
                }
                else
                {
                    Console.WriteLine($"\tYou entered: G value of: {GreenVal}");
                    Console.WriteLine();

                    continueScreen();
                }

            } while (!validResponse);
            #endregion
            //
            // Value 3 for blue
            //
            #region Blue/table
            Console.WriteLine();
            Console.WriteLine("\t Please enter value 3 (Blue), 0-255");
            do
            {
                validResponse = true;

                //
                //insert third number
                //
                Console.WriteLine();
                Console.Write($"\t Value 3: ");
                user3 = Console.ReadLine();
                Console.WriteLine();

                if (!int.TryParse(user3, out BlueVal))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits from 0-255");
                    validResponse = false;
                }
                else if ((BlueVal >= 256))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits from 0-255");
                    validResponse = false;
                }
                else
                {
                    Console.WriteLine($"\tYou entered: B value of: {GreenVal}");
                    Console.WriteLine();

                    continueScreen();
                }



                //
                //display values entered
                //

                //
                //Make the table
                //
                Console.WriteLine();
                Console.WriteLine("\tYour Values Entered:");
                Console.WriteLine(
                    "R".PadLeft(10) +
                    "G".PadLeft(10) +
                    "B".PadLeft(10)
                    );
                Console.WriteLine(
                   "---".PadLeft(10) +
                   "---".PadLeft(10) +
                   "---".PadLeft(10)
               ); ;
                //Line of user values
                Console.WriteLine(
                    RedVal.ToString().PadLeft(10) +
                    GreenVal.ToString().PadLeft(10) +
                    BlueVal.ToString().PadLeft(10)
                    );

            } while (!validResponse);
            continueScreen();
            #endregion

            //
            //Put it on the robot
            //
            Console.WriteLine();
            Console.WriteLine("\t Now I will put the colors to the robot!");
            continueScreen();
            doofus.setLED(RedVal, GreenVal, BlueVal);
            Console.WriteLine();
            Console.WriteLine("\t\t Ta-da!");
            continueScreen();
            calculateColor(RedVal, GreenVal, BlueVal);

            return RedVal + GreenVal + BlueVal;


        }


        static string calculateColor(int RedVal, int GreenVal, int BlueVal)
        {
            string color;
            //
            //Red value
            //
            if ((RedVal > GreenVal) || (RedVal > BlueVal))
            {
                Console.WriteLine();
                Console.WriteLine("\t From the colors you entered the color is mostly Red");
                continueScreen();
            }

            //
            //Green value 
            //
            else if ((GreenVal > RedVal) || (GreenVal > BlueVal))
            {
                Console.WriteLine();
                Console.WriteLine("\t From the colors you entered the color is mostly Green");
                continueScreen();
            }

            //
            //Blue Value
            //
            else if ((BlueVal > GreenVal) && (BlueVal > RedVal))
            {
                Console.WriteLine();
                Console.WriteLine("\t From the colors you entered the color is mostly Blue");
                continueScreen();
            }


            //****************
            //Combo Colors
            //****************

            //
            //Red and blue
            //
            if ((RedVal > GreenVal) && (BlueVal > GreenVal))
            {
                Console.WriteLine();
                Console.WriteLine("\t Your color should be close to a Purple hue or color");
                continueScreen();
            }
            //
            //Red and Green
            //
            if ((RedVal > BlueVal) && (GreenVal > BlueVal))
            {
                Console.WriteLine();
                Console.WriteLine("\t Your Color should be close to a Yellow hue or color");
                continueScreen();
            }
            //
            //Green and Blue
            //
            if ((GreenVal > RedVal) && (BlueVal > RedVal))
            {
                Console.WriteLine();
                Console.WriteLine("\t Your Color should be close to a Cyan hue or color");
                continueScreen();
            }
            //
            //Color is just white
            //
            if (!((RedVal != GreenVal) || GreenVal != BlueVal))
            {
                Console.WriteLine();
                Console.WriteLine("\t Your Color should be a White color");
                continueScreen();
            }

            color = "blank";
            return color;






        }



        #region SONG
        //
        //talent show song
        //
        static void talentShowSong(Finch doofus)
        {
            DisplayScreenHeader("Song");
            Console.WriteLine();
            Console.WriteLine($"\t The Finch will now demonstrate a song!");
            continueScreen();
            Console.WriteLine();
            Console.WriteLine("\t The Song Of Storms from Legend of Zelda");
            doofus.setLED(0, 255, 0);
            //
            //song start
            //m1
            doofus.noteOn(523);
            doofus.wait(250);
            doofus.noteOn(880);
            doofus.wait(250);
            doofus.noteOn(1150);
            doofus.wait(1000);
            //m2
            doofus.noteOn(523);
            doofus.wait(250);
            doofus.noteOn(880);
            doofus.wait(250);
            doofus.noteOn(1150);
            doofus.wait(1000);
            //m3
            doofus.noteOn(1300);
            doofus.wait(750);
            doofus.noteOn(1380);
            doofus.wait(250);
            doofus.noteOn(1300);
            doofus.wait(250);
            doofus.noteOn(1380);
            doofus.wait(250);
            //m4
            doofus.noteOn(1300);
            doofus.wait(250);
            doofus.noteOn(1047);
            doofus.wait(250);
            doofus.noteOn(880);
            doofus.wait(1000);
            doofus.noteOff();
            doofus.wait(100);
            //m5
            doofus.noteOn(880);
            doofus.wait(500);
            doofus.noteOn(587);
            doofus.wait(500);
            doofus.noteOn(698);
            doofus.wait(250);
            doofus.noteOn(784);
            doofus.wait(250);
            //m6
            doofus.noteOn(880);
            doofus.wait(1500);
            doofus.noteOff();
            doofus.wait(100);
            //m7
            doofus.noteOn(880);
            doofus.wait(500);
            doofus.noteOn(587);
            doofus.wait(500);
            doofus.noteOn(698);
            doofus.wait(250);
            doofus.noteOn(784);
            doofus.wait(250);
            //m8
            doofus.noteOn(659);
            doofus.wait(1500);
            doofus.noteOff();
            doofus.wait(100);
            //m9
            doofus.noteOn(587);
            doofus.wait(250);
            doofus.noteOn(880);
            doofus.wait(250);
            doofus.noteOn(1150);
            doofus.wait(1000);
            //m10
            doofus.noteOn(523);
            doofus.wait(250);
            doofus.noteOn(880);
            doofus.wait(250);
            doofus.noteOn(1150);
            doofus.wait(1000);
            //m11
            doofus.noteOn(1300);
            doofus.wait(750);
            doofus.noteOn(1380);
            doofus.wait(250);
            doofus.noteOn(1300);
            doofus.wait(250);
            doofus.noteOn(1380);
            doofus.wait(250);
            //m12
            doofus.noteOn(1300);
            doofus.wait(250);
            doofus.noteOn(1047);
            doofus.wait(250);
            doofus.noteOn(880);
            doofus.wait(1000);
            doofus.noteOff();
            doofus.wait(100);
            //13
            doofus.noteOn(880);
            doofus.wait(500);
            doofus.noteOn(587);
            doofus.wait(500);
            doofus.noteOn(698);
            doofus.wait(250);
            doofus.noteOn(784);
            doofus.wait(250);
            //14
            doofus.noteOn(880);
            doofus.wait(1000);
            doofus.noteOff();
            doofus.wait(100);
            doofus.noteOn(880);
            doofus.wait(500);
            //m15
            doofus.noteOn(587);
            doofus.wait(3000);
            doofus.noteOff();
            doofus.setLED(0, 0, 0);

        }
        #endregion


        //
        // Talent show movement
        //
        static void talentShowMovement(Finch doofus)
        {
            DisplayScreenHeader("Movement");
            Console.WriteLine("\tThe Finch robot will not show its movement talent!");
            continueScreen();

            leftTurn(doofus);
            rightTurn(doofus);
            forwardMove(doofus);
            backwardMove(doofus);
            doofus.setMotors(0, 0);
            doofus.setLED(0, 0, 0);

        }
        #region Moves
        //
        //left turn
        //
        static void leftTurn(Finch doofus)
        {
            doofus.setLED(250, 0, 250);
            doofus.noteOn(880);
            doofus.setMotors(-100, 100);
            doofus.wait(650);
            doofus.setMotors(0, 0);
            doofus.noteOff();

        }

        //
        //right turn
        //
        static void rightTurn(Finch doofus)
        {
            doofus.setLED(0, 0, 255);
            doofus.noteOn(1000);
            doofus.setMotors(100, -100);
            doofus.wait(650);
            doofus.setMotors(0, 0);
            doofus.noteOff();
        }

        //
        //forward
        //
        static void forwardMove(Finch doofus)
        {
            doofus.setLED(0, 250, 0);
            doofus.setMotors(100, 100);
            doofus.wait(650);
            doofus.setLED(0, 0, 0);
        }

        //
        //backward
        //
        static void backwardMove(Finch doofus)
        {
            doofus.setLED(250, 0, 0);
            doofus.setMotors(-100, -100);
            doofus.wait(650);
            doofus.setMotors(0, 0);

        }
        #endregion

        #region TLightAndSound
        ///  
        /// *****************************************************************
        /// *               Talent Show > Light and Sound                   *
        /// *****************************************************************
        ///  
        /// 
        static void TalentShowDisplayLightAndSound(Finch doofus)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Light and Sound");

            Console.WriteLine("\tThe Finch robot will now show its buzzer by playing a scale!!");
            continueScreen();
            for (int i = 0; i < 2; i++)
            {
                doofus.noteOn(523);
                doofus.wait(250);
                doofus.noteOn(587);
                doofus.wait(250);
                doofus.noteOn(659);
                doofus.wait(250);
                doofus.noteOn(698);
                doofus.wait(250);
                doofus.noteOn(784);
                doofus.wait(250);
                doofus.noteOn(880);
                doofus.wait(250);
                doofus.noteOn(988);
                doofus.wait(250);
                doofus.noteOn(1047);
                doofus.wait(500);
                doofus.noteOn(988);
                doofus.wait(250);
                doofus.noteOn(880);
                doofus.wait(250);
                doofus.noteOn(784);
                doofus.wait(250);
                doofus.noteOn(698);
                doofus.wait(250);
                doofus.noteOn(659);
                doofus.wait(250);
                doofus.noteOn(587);
                doofus.wait(250);
                doofus.noteOn(523);
                doofus.wait(250);
                doofus.noteOff();


            }



            DisplayMenuPrompt("Talent Show Menu");
        }
        #endregion

        #endregion

        #region FINCH ROBOT MANAGEMENT

        ///  
        /// *****************************************************************
        /// *               Disconnect the Finch Robot                      *
        /// *****************************************************************
        ///  
        /// 
        static void DisplayDisconnectdoofus(Finch doofus)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Disconnect Finch Robot");

            Console.WriteLine("\tAbout to disconnect from the Finch robot.");
            continueScreen();

            doofus.disConnect();

            Console.WriteLine("\tThe Finch robot is now disconnect.");

            DisplayMenuPrompt("Main Menu");
        }

        ///  
        /// *****************************************************************
        /// *                  Connect the Finch Robot                      *
        /// *****************************************************************
        ///  
        ///
        static bool connectdoofus(Finch doofus)
        {
            Console.CursorVisible = false;

            bool robotConnected;

            DisplayScreenHeader("Connect Finch Robot");

            Console.WriteLine("\tAbout to connect to Finch robot. Please be sure the USB cable is connected to the robot and computer now.");
            continueScreen();

            robotConnected = doofus.connect();

            // TODO test connection and provide user feedback - text, lights, sounds

            DisplayMenuPrompt("Main Menu");

            //
            // reset finch robot
            //
            doofus.setLED(0, 0, 0);
            doofus.noteOff();

            return robotConnected;
        }

        #region DATA RECORDER

        //************************
        //
        // DATA RECORDER
        //
        //*************************
        static void dataRecorderMenu(Finch doofus)
        {
            Console.CursorVisible = true;

            bool quitMenu = false;
            string menuChoice;

            int numberOfDataPoints = 0;
            double dataPointFreq = 0;
            double[] temperatures = null;

            do
            {
                DisplayScreenHeader("Data Recorder Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Number of Data Points");
                Console.WriteLine("\tb) Frequency of Data Points");
                Console.WriteLine("\tc) Get Data");
                Console.WriteLine("\td) Show Data");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        numberOfDataPoints = DataRecorderDisplayNumOfDataPoints();
                        break;

                    case "b":
                        dataPointFreq = DataRecorderDiplayGetDataPointFreq();
                        break;

                    case "c":
                        temperatures = dataRecorderDisplayGetData(numberOfDataPoints, dataPointFreq, doofus);
                        break;

                    case "d":
                        DataRecorderDisplayData(temperatures, numberOfDataPoints);
                        break;

                    case "q":
                        quitMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        continueScreen();
                        break;
                }

            } while (!quitMenu);
        }
        #region TEMPS


        //
        //Display Temp Table
        //
        static void displayTempTable(double[] temperatures)
        {
            //
            //display table of temperatures
            //
            Console.WriteLine(
                "Reading #".PadLeft(10) +
                "Temperature".PadLeft(15)
                );
            Console.WriteLine(
                "---------".PadLeft(10) +
                "-----------".PadLeft(15)
                );

            for (int index = 0; index < temperatures.Length; index++)
            {
                Console.WriteLine(
                      (index + 1).ToString().PadLeft(20) +
                      (temperatures[index]).ToString("n1").PadLeft(15)
               );
            }

        }

        //
        //Convert To Farenheit
        //
        static void convertToF(double[] temperatures, int numberOfDataPoints)
        {
            double[] fTemps = new double[numberOfDataPoints];
            Console.WriteLine();
            Console.WriteLine("\t Now it will show the Temps in Farenheit");
            Console.WriteLine();

            for (int index = 0; index < temperatures.Length; index++)
            {

                Console.WriteLine(
                      (index + 1).ToString().PadLeft(20) +
                      ((((temperatures[index]) * 9) / 5) + 32).ToString("n1").PadLeft(15)
               );



            }


        }

        //
        //Display Data Table
        //
        static void DataRecorderDisplayData(double[] temperatures, int numberOfDataPoints)
        {


            DisplayScreenHeader("Temperatures");

            //table of temps
            displayTempTable(temperatures);


            continueScreen();

            convertToF(temperatures, numberOfDataPoints);

            continueScreen();
        }

        //
        // Get Temperature Data from robot
        //
        static double[] dataRecorderDisplayGetData(int numberOfDataPoints, double dataPointFreq, Finch doofus)
        {
            double[] temperatures = new double[numberOfDataPoints];
            int dataPointFreqMs;


            //
            //Convert data point freq from seconds to milliseconds
            //
            dataPointFreqMs = (int)(dataPointFreq * 1000);


            DisplayScreenHeader("Temperatures");

            //
            //Echo Values
            //
            Console.WriteLine($"\tThe Finch robot will now record {numberOfDataPoints} temperatures, {dataPointFreq} seconds apart.");
            Console.WriteLine("\t Press any button to begin");
            Console.ReadKey();


            for (int index = 0; index < numberOfDataPoints; index++)
            {
                temperatures[index] = doofus.getTemperature();

                //
                //echo new temp
                //
                Console.WriteLine($"\t Temperature: {index + 1}: {temperatures[index]:n1} ");
                doofus.wait(dataPointFreqMs);





            }
            continueScreen();

            //
            //display table of temperatures
            //
            displayTempTable(temperatures);




            DisplayMenuPrompt("Data Recorder");

            return temperatures;
        }

        //
        //Get Data Point Frequency From user
        //
        static double DataRecorderDiplayGetDataPointFreq()
        {
            string dataPointFreqP;
            double dataPointFreq;
            bool validResponse;

            DisplayScreenHeader("Frequency of data points");

            //
            // TO DO VALIDATE THE ENTRY
            //


            do
            {
                validResponse = true;

                //
                //insert temps
                //

                dataPointFreqP = Console.ReadLine();
                Console.WriteLine();

                if (!double.TryParse(dataPointFreqP, out dataPointFreq))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits. (10, 35.6, etc...)");
                    validResponse = false;
                }
                else
                {
                    Console.WriteLine($"\tYou entered: {dataPointFreqP} for frequency in seconds");
                    Console.WriteLine();
                    Console.WriteLine("\tPress any button to continue");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (!validResponse);





            Console.WriteLine();
            Console.WriteLine($"\tYou Chose {dataPointFreq} as the number of data points.");

            DisplayMenuPrompt("Data Recorder");

            return dataPointFreq;
        }

        //
        //Number of Data Points
        //
        static int DataRecorderDisplayNumOfDataPoints()
        {
            string numberOfDataPoints;
            int numberOfDataPointsP;
            bool validResponse;

            DisplayScreenHeader("number of data points");



            do
            {
                validResponse = true;

                //
                //insert data
                //

                numberOfDataPoints = Console.ReadLine();
                Console.WriteLine();

                if (!int.TryParse(numberOfDataPoints, out numberOfDataPointsP))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using Integers. (10, 35, etc...)");
                    validResponse = false;
                }
                else
                {
                    Console.WriteLine($"\tYou entered: {numberOfDataPointsP} data points");
                    Console.WriteLine();
                    Console.WriteLine("\tPress any button to continue");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (!validResponse);





            Console.WriteLine();
            Console.WriteLine($"\tYou Chose {numberOfDataPoints} as the number of data points.");

            DisplayMenuPrompt("Data Recorder");

            return numberOfDataPointsP;
        }

        #endregion

        #region Alarm System

        //
        //alarm system menu
        //
        static void alarmSystem(Finch doofus)
        {
            Console.CursorVisible = true;

            bool quitMenu = false;
            string menuChoice;

            string sensorsToMonitor = "";
            string rangeType = "";
            int minMaxThresholdVal = 0;
            int timeToMonitor = 0;


            do
            {
                DisplayScreenHeader("Data Recorder Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Set Sensors To Monitor Light");
                Console.WriteLine("\tb) Set range type for Light");
                Console.WriteLine("\tc) Set min/max values for Light");
                Console.WriteLine("\td) set time to monitor for Light");
                Console.WriteLine("\te) set alarm for Light");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\tf) Temperature Alarm Time to Monitor");
                Console.WriteLine("\tg) Temperature Threshold");
                Console.WriteLine("\th) Temperature Range Type");
                Console.WriteLine("\ti) Temperature alarm");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\tj) set alarm for both temp and light");
                Console.WriteLine("\tq) quit");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        sensorsToMonitor = alarmSysDisplaySetSensors();
                        break;

                    case "b":
                        rangeType = AlarmSysDisplayRangeType();
                        break;

                    case "c":
                        minMaxThresholdVal = AlarmSysDisplayThresholdVal(sensorsToMonitor, doofus);
                        break;

                    case "d":
                        timeToMonitor = AlarmSysDisplayTimeToMonitor();
                        break;

                    case "e":
                        AlarmSysDiplaySetAlarm(doofus, sensorsToMonitor, rangeType, minMaxThresholdVal, timeToMonitor);
                        break;






                    case "f":
                        tempAlarmGetTimeToMonitor();
                        break;

                    case "g":
                        AlarmSysDisplayThresholdValTemps(doofus);
                        break;

                    case "h":
                        AlarmSysDisplayRangeTypeTemps();
                        break;

                    case "i":
                        AlarmSysTempSetAlarm(doofus, rangeType);
                        break;

                    case "j":
                        AlarmSysTempAndLightSetTL(doofus, sensorsToMonitor, rangeType, minMaxThresholdVal, timeToMonitor);
                        break;

                    case "q":
                        quitMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        continueScreen();
                        break;
                }


            } while (!quitMenu);
        }

        // DONE
        //Get Range Type for Temps
        //
        static string AlarmSysDisplayRangeTypeTemps()
        {
            string rangeTypeT = "";
            bool validResponse;
            DisplayScreenHeader("range type");



            do
            {
                validResponse = true;
                rangeTypeT = "";
                //
                //insert rangetype
                //
                Console.WriteLine();
                Console.Write("\tEnter Range Type [minimum, maximum]:");
                rangeTypeT = Console.ReadLine();
                Console.WriteLine();

                if (rangeTypeT == "minimum")
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tYou have entered (minimum)");
                    validResponse = true;
                }
                else if (rangeTypeT == "maximum")
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tYou have entered (maximum)");
                    validResponse = true;

                }
                else
                {
                    validResponse = false;
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter either minimum or maximum ( CASE SENSITIVE )");

                    continueScreen();
                }


            } while (!validResponse);

            DisplayMenuPrompt("Alarm System");
            return rangeTypeT;
        }

        //
        //Get Threshold for Temps
        //
        static double AlarmSysDisplayThresholdValTemps(Finch doofus)
        {
            double tempMinMaxThresholdVal = 0;
            double tempSensVal;
            string tempThreshPlace = "";

            DisplayScreenHeader("Threshold Value");

            //
            //display ambient values
            //
            tempSensVal = doofus.getTemperature();
            Console.WriteLine($"\t Current ambient Temp: {tempSensVal:n1}");




            bool validResponse = true;


            //
            //validate threshold
            //
            do
            {
                //
                //get threshold from user and echo
                //
                Console.WriteLine();
                Console.Write("\t Please enter the threshold number you want the alarm to be triggered at:");
                tempThreshPlace = Console.ReadLine();
                validResponse = true;

                if (!double.TryParse(tempThreshPlace, out tempMinMaxThresholdVal))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits, ex: 1, 3, 25, etc...");
                    validResponse = false;
                }
                else
                {
                    Console.WriteLine($"\tYou entered: {tempMinMaxThresholdVal}");

                    continueScreen();
                }

            } while (!validResponse);


            DisplayMenuPrompt("Alarm System");
            return tempMinMaxThresholdVal;

        }

        // DONE
        //Get Time to monitor temps
        //
        static int tempAlarmGetTimeToMonitor()
        {

            string user1;
            string user2;
            bool validResponse;
            int timeToMonitorTemp = 0;


            DisplayScreenHeader("Time To Monitor");
            //
            //TO DO USE LOOP TO VALIDATE
            //
            do
            {
                validResponse = true;

                //
                //insert first number
                //
                Console.WriteLine();
                Console.Write($"\tTime to monitor in seconds: ");
                user1 = Console.ReadLine();
                Console.WriteLine();

                if (!int.TryParse(user1, out timeToMonitorTemp))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits, ex: 1, 3, 25, etc...");
                    validResponse = false;
                }
                else
                {
                    Console.WriteLine($"\tYou entered: {timeToMonitorTemp} seconds");

                    continueScreen();
                }

            } while (!validResponse);



            continueScreen();
            return timeToMonitorTemp;


        }


        //
        //
        //
        //ALARM FOR LIGHT AND TEMPS
        //
        //
        //
        static void AlarmSysTempAndLightSetTL(Finch doofus, string sensorsToMonitor, string rangeType, int minMaxThresholdVal, int timeToMonitor)
        {
            DisplayScreenHeader("alarm for light and temp at the same time");
            continueScreen();
            //
            //ask for same things as the light sensor
            //
            //ask for set sensors
            //
            #region light set sensors
            sensorsToMonitor = "";

            DisplayScreenHeader("sensors to monitor");

            Console.Write("\tEnter Sensors to Monitor: [left, right, both]");

            //
            // TO DO VALIDATE THIS
            //
            sensorsToMonitor = Console.ReadLine();
            continueScreen();
            #endregion

            //
            //Light range type
            //
            #region range type light
            rangeType = "";
            bool validResponse;
            DisplayScreenHeader("range type");



            do
            {
                validResponse = true;
                rangeType = "";
                //
                //insert rangetype
                //
                Console.WriteLine();
                Console.Write("\tEnter Range Type [minimum, maximum]:");
                rangeType = Console.ReadLine();
                Console.WriteLine();

                if (rangeType == "minimum")
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tYou have entered (minimum)");
                    validResponse = true;
                }
                else if (rangeType == "maximum")
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tYou have entered (maximum)");
                    validResponse = true;

                }
                else
                {
                    validResponse = false;
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter either minimum or maximum ( CASE SENSITIVE )");

                    continueScreen();
                }


            } while (!validResponse);

            continueScreen();
            #endregion

            //
            //get threshold value for Light
            //
            #region threshold value for light
            int thresholdVal = 0;

            int currentLeftSensVal = doofus.getLeftLightSensor();

            int currentRightSensVal = doofus.getRightLightSensor();

            DisplayScreenHeader("Threshold Value");

            //
            //display ambient values
            //
            switch (sensorsToMonitor)
            {
                case "left":
                    Console.WriteLine($"Current {sensorsToMonitor} sensor value: {currentLeftSensVal}");
                    break;

                case "right":
                    Console.WriteLine($"Current {sensorsToMonitor} sensor value: {currentRightSensVal}");
                    break;

                case "both":
                    Console.WriteLine($"Current {sensorsToMonitor} sensor value: {currentLeftSensVal}");
                    Console.WriteLine($"Current {sensorsToMonitor} sensor value: {currentRightSensVal}");
                    break;

                default:
                    Console.WriteLine("\tERROR: Unknown Sensor Reference");
                    break;
            }

            //
            //Get Threshold from user
            //

            validResponse = true;
            string user1;

            //
            //validate threshold
            //
            do
            {
                validResponse = true;



                //
                //insert first number
                //
                Console.WriteLine();
                Console.Write($"\tThreshold Value: ");
                user1 = Console.ReadLine();
                Console.WriteLine();

                if (!int.TryParse(user1, out thresholdVal))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits, ex: 1, 3, 25, etc...");
                    validResponse = false;
                }
                else
                {
                    Console.WriteLine($"\tYou entered: {thresholdVal}");

                    continueScreen();
                }

            } while (!validResponse);


            continueScreen();

            #endregion

            //
            //get time to monitor
            //
            #region time to monitor light

            validResponse = true;
            timeToMonitor = 0;


            DisplayScreenHeader("Time To Monitor");
            //
            //TO DO USE LOOP TO VALIDATE
            //
            do
            {
                validResponse = true;

                //
                //insert first number
                //
                Console.WriteLine();
                Console.Write($"\tTime to monitor in seconds: ");
                user1 = Console.ReadLine();
                Console.WriteLine();

                if (!int.TryParse(user1, out timeToMonitor))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits, ex: 1, 3, 25, etc...");
                    validResponse = false;
                }
                else
                {
                    Console.WriteLine($"\tYou entered: {timeToMonitor} seconds");

                    continueScreen();
                }

            } while (!validResponse);
            continueScreen();
            #endregion


            Console.WriteLine("\tNow enter the data for the temperature");
            continueScreen();
            //
            //Temperature data 
            //

            //
            //get temp range type
            //
            #region temp range
            string rangeTypeT = "";
            validResponse = true;
            DisplayScreenHeader("Temperature range type");



            do
            {
                validResponse = true;
                rangeTypeT = "";
                //
                //insert rangetype
                //
                Console.WriteLine();
                Console.Write("\tEnter Range Type [minimum, maximum]:");
                rangeTypeT = Console.ReadLine();
                Console.WriteLine();

                if (rangeTypeT == "minimum")
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tYou have entered (minimum)");
                    validResponse = true;
                }
                else if (rangeTypeT == "maximum")
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tYou have entered (maximum)");
                    validResponse = true;

                }
                else
                {
                    validResponse = false;
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter either minimum or maximum ( CASE SENSITIVE )");

                    continueScreen();
                }


            } while (!validResponse);

            #endregion


            //
            //temp threhold
            //
            #region temp thresh
            double tempMinMaxThresholdVal = 0;
            double tempSensVal;
            string tempThreshPlace = "";

            DisplayScreenHeader("Threshold Value");

            //
            //display ambient values
            //
            tempSensVal = doofus.getTemperature();
            Console.WriteLine($"\t Current ambient Temp: {tempSensVal:n1}");




            validResponse = true;


            //
            //validate threshold
            //
            do
            {
                //
                //get threshold from user and echo
                //
                Console.WriteLine();
                Console.Write("\t Please enter the threshold number you want the alarm to be triggered at:");
                tempThreshPlace = Console.ReadLine();
                validResponse = true;

                if (!double.TryParse(tempThreshPlace, out tempMinMaxThresholdVal))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits, ex: 1, 3, 25, etc...");
                    validResponse = false;
                }
                else
                {
                    Console.WriteLine($"\tYou entered: {tempMinMaxThresholdVal}");

                    continueScreen();
                }

            } while (!validResponse);
            #endregion

            //
            //TEST FOR EVERYTHING
            //
            #region light and temp test
            int secondsElapsed = 1;
            bool thresholdExceededL = false;
            bool tempThresholdExceeded = false;
            do
            {
                //
                //get  current light levels
                //
                double leftLightSensVal = doofus.getLeftLightSensor();
                double rightLightSensVal = doofus.getRightLightSensor();


                //
                //display current light levels
                //
                switch (sensorsToMonitor)
                {
                    case "left":
                        Console.WriteLine($"\tCurrent left light sensor: {leftLightSensVal}");
                        break;

                    case "right":
                        Console.WriteLine($"\tCurrent right light sensor: {rightLightSensVal}");
                        break;

                    case "both":
                        Console.WriteLine($"\tCurrent left light sensor: {leftLightSensVal}");
                        Console.WriteLine($"\tCurrent right light sensor: {rightLightSensVal}");
                        break;

                    default:
                        Console.WriteLine("\tERROR: Unknown Sensor Reference");
                        break;
                }

                //
                //wait 1 second and increment
                //
                doofus.wait(1000);
                secondsElapsed++;

                //
                //test for threshold exceeded
                //
                tempSensVal = doofus.getTemperature();
                Console.WriteLine($"\tCurrent temp value: {tempSensVal:n1}");

                //
                //test to see if it went over limit
                //
                if (rangeTypeT == "minimum")
                {
                    if (tempSensVal < tempMinMaxThresholdVal)
                    {
                        tempThresholdExceeded = true;
                    }
                }
                else//max
                {
                    if (tempSensVal > tempMinMaxThresholdVal)
                    {
                        tempThresholdExceeded = true;
                    }
                }
                switch (sensorsToMonitor)
                {
                    case "left":
                        if (rangeType == "minimum")
                        {
                            if (leftLightSensVal < minMaxThresholdVal)
                            {
                                thresholdExceededL = true;
                            }
                        }
                        else//max
                        {
                            if (leftLightSensVal > minMaxThresholdVal)
                            {
                                thresholdExceededL = true;
                            }
                        }
                        break;

                    case "right":
                        if (rangeType == "minimum")
                        {
                            if (rightLightSensVal < minMaxThresholdVal)
                            {
                                thresholdExceededL = true;
                            }
                        }
                        else//max
                        {
                            if (rightLightSensVal > minMaxThresholdVal)
                            {
                                thresholdExceededL = true;
                            }
                        }
                        break;

                    case "both":
                        if (rangeType == "minimum")
                        {
                            if ((leftLightSensVal < minMaxThresholdVal) || (rightLightSensVal < minMaxThresholdVal))
                            {
                                thresholdExceededL = true;
                            }

                        }
                        else//max
                        {
                            if ((leftLightSensVal < minMaxThresholdVal) || (rightLightSensVal < minMaxThresholdVal))
                            {
                                thresholdExceededL = true;
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Unknown Refernce");
                        break;


                }


            } while (!thresholdExceededL && (secondsElapsed < timeToMonitor) && !tempThresholdExceeded);
            #endregion

            //
            //display result
            //
            if (thresholdExceededL)
            {
                Console.WriteLine("\tLight Threshold exceeded");
            }
            else if (tempThresholdExceeded)
            {
                Console.WriteLine("\tTemperature Threshold exceeded");
            }
            else
            {
                Console.WriteLine("\tthreshold not exceeded---Time limit met");

            }

            continueScreen();
        }

        //
        //Sensors to monitor
        //
        static string alarmSysDisplaySetSensorsTL()
        {
            string sensorsToMonitorTL = "";

            DisplayScreenHeader("sensors to monitor");

            Console.Write("\tEnter Sensors to Monitor: [left, right, both]");

            //
            // TO DO VALIDATE THIS
            //
            sensorsToMonitorTL = Console.ReadLine();

            Console.WriteLine($"You entered: {sensorsToMonitorTL}");

            return sensorsToMonitorTL;
        }




        //
        //alarm for temps
        //
        static void AlarmSysTempSetAlarm(Finch doofus, string rangeTypeT)
        {
            Console.Clear();
            int secondsElapsed = 1;

            string tempThreshPlace = "";
            double tempSensVal;
            bool tempThresholdExceeded = false;
            //
            //display current temp value
            //
            tempSensVal = doofus.getTemperature();
            Console.WriteLine($"\t Current ambient Temp: {tempSensVal:n1}");

            //
            //GET TIME TO TEST FOR
            //
            #region TIMETEST
            int timeToMonitorTemp = 0;
            string user1;
            string user2;
            bool validResponse;

            DisplayScreenHeader("Time To Monitor");
            //
            //TO DO USE LOOP TO VALIDATE
            //
            do
            {
                validResponse = true;

                //
                //insert first number
                //
                Console.WriteLine();
                Console.Write($"\tTime to monitor in seconds: ");
                user1 = Console.ReadLine();
                Console.WriteLine();

                if (!int.TryParse(user1, out timeToMonitorTemp))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits, ex: 1, 3, 25, etc...");
                    validResponse = false;
                }
                else
                {
                    Console.WriteLine($"\tYou entered: {timeToMonitorTemp} seconds");

                    continueScreen();
                }

            } while (!validResponse);

            #endregion



            //
            //get threshold from user and echo
            //
            #region threholdTemp
            double tempMinMaxThresholdVal = 0;



            DisplayScreenHeader("Threshold Value");

            //
            //display ambient values
            //
            tempSensVal = doofus.getTemperature();
            Console.WriteLine($"\t Current ambient Temp: {tempSensVal:n1}");

            validResponse = true;

            //
            //validate threshold
            //
            do
            {
                //
                //get threshold from user and echo
                //
                Console.WriteLine();
                Console.Write("\t Please enter the threshold number you want the alarm to be triggered at:");
                tempThreshPlace = Console.ReadLine();
                validResponse = true;

                if (!double.TryParse(tempThreshPlace, out tempMinMaxThresholdVal))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits, ex: 1, 3, 25, etc...");
                    validResponse = false;
                }
                else
                {
                    Console.WriteLine($"\tYou entered: {tempMinMaxThresholdVal}");

                    continueScreen();
                }

            } while (!validResponse);

            #endregion
            //
            //start test
            //
            Console.WriteLine("\tPress any button to start the test");
            Console.ReadKey();


            do
            {

                tempSensVal = doofus.getTemperature();
                Console.WriteLine($"\tCurrent temp value: {tempSensVal:n1}");
                //
                //wait 1 second and increment
                //
                doofus.wait(1000);
                secondsElapsed++;
                //
                //test to see if it went over limit
                //
                if (rangeTypeT == "minimum")
                {
                    if (tempSensVal < tempMinMaxThresholdVal)
                    {
                        tempThresholdExceeded = true;
                    }
                }
                else//max
                {
                    if (tempSensVal > tempMinMaxThresholdVal)
                    {
                        tempThresholdExceeded = true;
                    }
                }

            } while (!tempThresholdExceeded && (secondsElapsed < timeToMonitorTemp));


            Console.WriteLine($"\tCurrent temp value: {tempSensVal:n1}");
            //
            //display result
            //
            if (tempThresholdExceeded)
            {
                Console.WriteLine("Threshold exceeded");
            }
            else
            {
                Console.WriteLine("threshold not exceeded---Time limit met");

            }
            Console.ReadKey();
        }



        //
        //
        //
        //Set The alarm FOR LIGHT
        //
        //
        //
        static void AlarmSysDiplaySetAlarm(Finch doofus, string sensorsToMonitor, string rangeType, int minMaxThresholdVal, int timeToMonitor)
        {

            bool thresholdExceeded = false;
            int secondsElapsed = 1;
            int leftLightSensVal;
            int rightLightSensVal;


            DisplayScreenHeader("Set Alarm");
            //
            //echo values
            //
            Console.WriteLine("\tStart");

            //
            //Prompt Usre to start
            //
            continueScreen();




            do
            {
                //
                //get  current light levels
                //
                leftLightSensVal = doofus.getLeftLightSensor();
                rightLightSensVal = doofus.getRightLightSensor();


                //
                //display current light levels
                //
                switch (sensorsToMonitor)
                {
                    case "left":
                        Console.WriteLine($"\tCurrent left light sensor: {leftLightSensVal}");
                        break;

                    case "right":
                        Console.WriteLine($"\tCurrent right light sensor: {rightLightSensVal}");
                        break;

                    case "both":
                        Console.WriteLine($"\tCurrent left light sensor: {leftLightSensVal}");
                        Console.WriteLine($"\tCurrent right light sensor: {rightLightSensVal}");
                        break;

                    default:
                        Console.WriteLine("\tERROR: Unknown Sensor Reference");
                        break;
                }

                //
                //wait 1 second and increment
                //
                doofus.wait(1000);
                secondsElapsed++;

                //
                //test for threshold exceeded
                //
                switch (sensorsToMonitor)
                {
                    case "left":
                        if (rangeType == "minimum")
                        {
                            thresholdExceeded = (leftLightSensVal < minMaxThresholdVal);
                        }
                        else//max
                        {
                            thresholdExceeded = (leftLightSensVal > minMaxThresholdVal);
                        }
                        break;

                    case "right":
                        if (rangeType == "minimum")
                        {
                            if (rightLightSensVal < minMaxThresholdVal)
                            {
                                thresholdExceeded = true;
                            }
                        }
                        else//max
                        {
                            if (rightLightSensVal > minMaxThresholdVal)
                            {
                                thresholdExceeded = true;
                            }
                        }
                        break;

                    case "both":
                        if (rangeType == "minimum")
                        {
                            if ((leftLightSensVal < minMaxThresholdVal) || (rightLightSensVal < minMaxThresholdVal))
                            {
                                thresholdExceeded = true;
                            }

                        }
                        else//max
                        {
                            if ((leftLightSensVal < minMaxThresholdVal) || (rightLightSensVal < minMaxThresholdVal))
                            {
                                thresholdExceeded = true;
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Unknown Refernce");
                        break;
                }


            } while (!thresholdExceeded && (secondsElapsed < timeToMonitor));

            //
            //display result
            //
            if (thresholdExceeded)
            {
                Console.WriteLine("Threshold exceeded");
            }
            else
            {
                Console.WriteLine("threhold not exceeded---Time limit met");

            }







            DisplayMenuPrompt("Alarm System");
        }

        //
        //Get Time t monitor
        //
        static int AlarmSysDisplayTimeToMonitor()
        {

            string user1;
            string user2;
            bool validResponse;
            int timeToMonitor = 0;


            DisplayScreenHeader("Time To Monitor");
            //
            //TO DO USE LOOP TO VALIDATE
            //
            do
            {
                validResponse = true;

                //
                //insert first number
                //
                Console.WriteLine();
                Console.Write($"\tTime to monitor in seconds: ");
                user1 = Console.ReadLine();
                Console.WriteLine();

                if (!int.TryParse(user1, out timeToMonitor))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits, ex: 1, 3, 25, etc...");
                    validResponse = false;
                }
                else
                {
                    Console.WriteLine($"\tYou entered: {timeToMonitor} seconds");

                    continueScreen();
                }

            } while (!validResponse);



            DisplayMenuPrompt("Alarm System");
            return timeToMonitor;
        }

        //
        //Get Threshold
        //
        static int AlarmSysDisplayThresholdVal(string sensorsToMonitor, Finch doofus)
        {
            int thresholdVal = 0;

            int currentLeftSensVal = doofus.getLeftLightSensor();

            int currentRightSensVal = doofus.getRightLightSensor();

            DisplayScreenHeader("Threshold Value");

            //
            //display ambient values
            //
            switch (sensorsToMonitor)
            {
                case "left":
                    Console.WriteLine($"Current {sensorsToMonitor} sensor value: {currentLeftSensVal}");
                    break;

                case "right":
                    Console.WriteLine($"Current {sensorsToMonitor} sensor value: {currentRightSensVal}");
                    break;

                case "both":
                    Console.WriteLine($"Current {sensorsToMonitor} sensor value: {currentLeftSensVal}");
                    Console.WriteLine($"Current {sensorsToMonitor} sensor value: {currentRightSensVal}");
                    break;

                default:
                    Console.WriteLine("\tERROR: Unknown Sensor Reference");
                    break;
            }

            //
            //Get Threshold from user
            //

            bool validResponse = true;
            string user1;

            //
            //validate threshold
            //
            do
            {
                validResponse = true;



                //
                //insert first number
                //
                Console.WriteLine();
                Console.Write($"\tThreshold Value: ");
                user1 = Console.ReadLine();
                Console.WriteLine();

                if (!int.TryParse(user1, out thresholdVal))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits, ex: 1, 3, 25, etc...");
                    validResponse = false;
                }
                else
                {
                    Console.WriteLine($"\tYou entered: {thresholdVal}");

                    continueScreen();
                }

            } while (!validResponse);

            DisplayMenuPrompt("Alarm System");

            return thresholdVal;
        }

        //
        //Get Range Type
        //
        static string AlarmSysDisplayRangeType()
        {
            string rangeType = "";
            bool validResponse;
            DisplayScreenHeader("range type");



            do
            {
                validResponse = true;
                rangeType = "";
                //
                //insert rangetype
                //
                Console.WriteLine();
                Console.Write("\tEnter Range Type [minimum, maximum]:");
                rangeType = Console.ReadLine();
                Console.WriteLine();

                if (rangeType == "minimum")
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tYou have entered (minimum)");
                    validResponse = true;
                }
                else if (rangeType == "maximum")
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tYou have entered (maximum)");
                    validResponse = true;

                }
                else
                {
                    validResponse = false;
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter either minimum or maximum ( CASE SENSITIVE )");

                    continueScreen();
                }


            } while (!validResponse);

            DisplayMenuPrompt("Alarm System");
            return rangeType;
        }

        //
        //Sensors to monitor
        //
        static string alarmSysDisplaySetSensors()
        {
            string sensorsToMonitor = "";

            DisplayScreenHeader("sensors to monitor");

            Console.Write("\tEnter Sensors to Monitor: [left, right, both]");

            //
            // TO DO VALIDATE THIS
            //
            sensorsToMonitor = Console.ReadLine();

            DisplayMenuPrompt("Alarm System");

            return sensorsToMonitor;
        }









        #endregion






        #endregion


        #endregion

        #region USER INTERFACE

        ///  
        /// *****************************************************************
        /// *                     Welcome Screen                            *
        /// *****************************************************************
        ///  
        static void DisplayWelcomeScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tFinch Control");
            Console.WriteLine();

            continueScreen();
        }

        ///  
        /// *****************************************************************
        /// *                     Closing Screen                            *
        /// *****************************************************************
        ///  
        static void DisplayClosingScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tThank you for using Finch Control!");
            Console.WriteLine();

            continueScreen();
        }

        ///
        /// continue prompt
        ///
        static void continueScreen()
        {
            Console.WriteLine();
            Console.WriteLine("\tPress any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }

        /// 
        /// menu prompt
        /// 
        static void DisplayMenuPrompt(string menuName)
        {
            Console.WriteLine();
            Console.WriteLine($"\tPress any key to return to the {menuName} Menu.");
            Console.ReadKey();
        }

        /// 
        /// display screen header
        ///
        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }

        #endregion
        #endregion


        #region USER PROGRAMMING

        //
        //
        //



        //
        //user programming menu
        //
        static void userProgrammingMenuScreen(Finch doofus)
        {
            Console.CursorVisible = true;

            bool quitMenu = false;
            string menuChoice;

            (int motorSpeed, int ledBrightness, double waitSeconds, int soundFreq) commandParameters;
            commandParameters.motorSpeed = 0;
            commandParameters.ledBrightness = 0;
            commandParameters.waitSeconds = 0;
            commandParameters.soundFreq = 0;
            List<Command> commands = null;



            do
            {
                DisplayScreenHeader("Data Recorder Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Get Command Parameters");
                Console.WriteLine("\tb) Get Commands");
                Console.WriteLine("\tc) View Commands");
                Console.WriteLine("\td) Execute Commands");
                Console.WriteLine();
                Console.WriteLine("\tq) quit");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        commandParameters = UserProgrammingDisplayGetCommandParam();
                        break;

                    case "b":
                        commands = UserProgrammingDisplayGetFinchCommands();
                        break;

                    case "c":
                        UserProgrammingDisplayViewCommands(commands);
                        break;

                    case "d":
                        UserProgrammingDisplayExecuteCommands (doofus, commands, commandParameters);
                        break;

                    case "q":
                        quitMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        continueScreen();
                        break;
                }


            } while (!quitMenu);
        }

        //
        //Execute commands
        //
        static void UserProgrammingDisplayExecuteCommands(Finch doofus, List<Command> commands, (int motorSpeed, int ledBrightness, double waitSeconds, int soundFreq) commandParameters)
        {
            DisplayScreenHeader("Execute commands");

            Console.WriteLine("\tThe Finch will now execute all commands");
            continueScreen();

            foreach (Command command in commands)
            {
                Console.WriteLine($"\tCommand: {command}");
                Console.WriteLine();
                switch (command)
                {
                    case Command.none:
                        Console.WriteLine();
                        Console.WriteLine("\tDefault Value Error");
                        Console.WriteLine();
                        break;

                    case Command.moveforward:
                        doofus.setMotors(commandParameters.motorSpeed, commandParameters.motorSpeed);
                        doofus.wait(1000);
                        break;

                    case Command.movebackward:
                        doofus.setMotors(-commandParameters.motorSpeed, -commandParameters.motorSpeed);
                        doofus.wait(1000);
                        break;

                    case Command.stopmotors:
                        doofus.setMotors(0, 0);
                        break;

                    case Command.wait:
                        int waitMilliseconds = (((int)commandParameters.waitSeconds)*1000);
                        doofus.wait(waitMilliseconds);
                        break;

                    case Command.turnright:
                        doofus.setMotors(100, -100);
                        doofus.wait(650);
                        doofus.setMotors(0, 0);
                        break;

                    case Command.turnleft:
                        doofus.setMotors(-100, 100);
                        doofus.wait(650);
                        doofus.setMotors(0, 0);
                        break;

                    case Command.ledon:
                        doofus.setLED(commandParameters.ledBrightness, commandParameters.ledBrightness, commandParameters.ledBrightness);
                        break;

                    case Command.ledoff:
                        doofus.setLED(0,0,0);
                        break;

                    case Command.buzzeron:
                        doofus.noteOn(commandParameters.soundFreq);
                        break;

                    case Command.buzzeroff:
                        doofus.noteOff();
                        break;

                    case Command.gettemperature:
                        Console.Write("\tThe Current temp is: "+ doofus.getTemperature());
                        break;

                    case Command.done:
                        break;

                    default:
                        break;
                }
            }

            continueScreen();
        }

        //
        //View commands
        //
        static void UserProgrammingDisplayViewCommands(List<Command> commands)
        {
            DisplayScreenHeader("View Commands");

            Console.WriteLine("\tCommand List");
            Console.WriteLine("\t------------");
            foreach (Command command in commands)
            {
                Console.WriteLine("\t" + command);
            }


            continueScreen();
        }

        //
        //get commands from suer
        //
        static List<Command> UserProgrammingDisplayGetFinchCommands()
        {
            List<Command> commands = new List<Command>();
            bool isDone = false;
            string userResponse;
            Command command;

            DisplayScreenHeader("User Commands");
            Console.WriteLine();
            Console.WriteLine("\tAvailable Commands: ");
            Console.WriteLine("\tmoveforward, movebackward, stopmotors, wait, turnright, turnleft, ledon, ledoff, gettemperature, ");
            Console.WriteLine("\tbuzzeron, buzzeroff");
            Console.WriteLine();
            Console.WriteLine("\tEnter (done) to finish the list of commands");


            do
            {
                Console.Write("Command: ");
                userResponse = Console.ReadLine();

                if (userResponse != "done")
                {
                    if (Enum.TryParse(userResponse.ToLower(), out command))
                    {
                        commands.Add(command);
                    }
                    else
                    {
                        Console.WriteLine("\tPlease enter a valid command:");
                    }
                }
                else
                {
                    isDone = true;
                }

            } while (!isDone);
           


            continueScreen();
            return commands;
        }

        //
        //Get command parameters from user
        //
        static (int motorSpeed, int ledBrightness, double waitSeconds, int soundFreq) UserProgrammingDisplayGetCommandParam()
        {
            (int motorSpeed, int ledBrightness, double waitSeconds, int soundFreq) commandParameters;

            DisplayScreenHeader("Command Parameters");
            commandParameters.soundFreq = 0;
            int soundFreqPara = 0;
            string soundFreqParaP = "";

            commandParameters.motorSpeed = 0;
            int motorSpeedPara = 0;
            string motorSpeedParaP = "";

            commandParameters.ledBrightness = 0;
            int ledBrightnessPara = 0;
            string ledBrightnessParaP = "";

            commandParameters.waitSeconds = 0;
            double waitSecondsPara = 0;
            string waitSecondsParaP = "";

            bool validResponse = true;


            //Console.Write("Motor Speed (from 1-255): ");
            //commandParameters.motorSpeed = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //
            //validate sound frequency
            //
            DisplayScreenHeader("Finch Buzzer Frequency");
            do
            {
                validResponse = true;

                //
                //insert first number
                //
                Console.WriteLine();
                Console.Write($"\tValue of Sound Frequency (0 for off): ");
                soundFreqParaP = Console.ReadLine();
                Console.WriteLine();

                if (!int.TryParse(soundFreqParaP, out soundFreqPara))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits from 0-255");
                    validResponse = false;
                }
                else if ((soundFreqPara >= 1000) || (soundFreqPara < 0))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits from 0-1000");
                    validResponse = false;
                }
                else
                {
                    Console.WriteLine($"\tYou entered: {soundFreqPara}");
                    commandParameters.soundFreq = soundFreqPara;
                    continueScreen();
                }

            } while (!validResponse);

            //
            //validate motor speed
            //
            DisplayScreenHeader("Finch Motor Speed");
            do
            {
                validResponse = true;

                //
                //insert first number
                //
                Console.WriteLine();
                Console.Write($"\tValue of motor speed: ");
                motorSpeedParaP = Console.ReadLine();
                Console.WriteLine();

                if (!int.TryParse(motorSpeedParaP, out motorSpeedPara))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits from 0-255");
                    validResponse = false;
                }
                else if ((motorSpeedPara >= 256) || (motorSpeedPara <0))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits from 0-255");
                    validResponse = false;
                }
                else
                {
                    Console.WriteLine($"\tYou entered: {motorSpeedPara}");
                    commandParameters.motorSpeed = motorSpeedPara;
                    continueScreen();
                }

            } while (!validResponse);

            //
            //insert led brightness
            //
            //Console.Write("LED Brightness (from 1-255): ");
            //commandParameters.ledBrightness = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            DisplayScreenHeader("Led Brightness Parameter");
            do
            {
                validResponse = true;

                //
                //insert first number
                //
                Console.WriteLine();
                Console.Write($"\tValue of led brightness: ");
                ledBrightnessParaP = Console.ReadLine();
                Console.WriteLine();

                if (!int.TryParse(ledBrightnessParaP, out ledBrightnessPara))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits from 0-255");
                    validResponse = false;
                }
                else if ((ledBrightnessPara >= 256) || (ledBrightnessPara < 0))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits from 0-255");
                    validResponse = false;
                }
                else
                {
                    Console.WriteLine($"\tYou entered: {ledBrightnessPara}");
                    commandParameters.ledBrightness = ledBrightnessPara;
                    continueScreen();
                }

            } while (!validResponse);

            //
            //enter wait time
            //
            //Console.Write("Wait Time (Seconds): ");
            //commandParameters.waitSeconds = double.Parse(Console.ReadLine());
            //Console.WriteLine();
            DisplayScreenHeader("Seconds to wait Parameter");
            do
            {
                validResponse = true;

                //
                //insert first number
                //
                Console.WriteLine();
                Console.Write($"\tValue of wait time in seconds: ");
                waitSecondsParaP = Console.ReadLine();
                Console.WriteLine();

                if (!double.TryParse(waitSecondsParaP, out waitSecondsPara))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a valid number (0 and up)");
                    validResponse = false;
                }
                else if ((waitSecondsPara < 0))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a valid number (0 and up)");
                    validResponse = false;
                }
                else
                {
                    Console.WriteLine($"\tYou entered: {waitSecondsPara}");
                    commandParameters.waitSeconds = waitSecondsPara;
                    continueScreen();
                }

            } while (!validResponse);


            continueScreen();
            return commandParameters;
        }




        #endregion
    }
}

