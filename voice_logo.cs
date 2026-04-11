using System;
using System.Drawing;
using System.Media;

namespace CybersecurityAwarenessBot
{//start of the namespace

    public class voice_logo
    {//start of the class

        //auto gets the path dictionary

        private string full_path = AppDomain.CurrentDomain.BaseDirectory;

        public voice_logo() //Constructor
        {//start of the constructor

            //calling the sound method
            greetings();

            //call the logo method
            asci();

        }//end of the constructor

        //method to play the sound

        private void greetings()
        { //start of greeting method

            //check if the file path is auto colected

            Console.WriteLine(full_path);

            //then replace the \bin\Debug

            String correct_path = full_path.Replace(@"\bin\Debug\", @"\greet.wav");

            //check if the audio is found
            Console.WriteLine(correct_path);

            //use the SoundPlayer class to play the audio
            //creating the instance for the SoundPlayer class
            //with an object name greet

            SoundPlayer greet = new SoundPlayer(correct_path);

            //then play the sound using the play method
            greet.Play();//playSync plays the audio till the end and it shows the program after

        }//end of greetings methods


        //method to turn logo into ASCII
        private void asci()
        {

            //path of the logo [ where the logo is ]
            string path = full_path.Replace(@"\bin\Debug\", @"\ascii_logo.jpg");


            Bitmap image = new Bitmap(path);

            // Resize for better console fit
            int width = 190;
            int height = 70; //(image.Height * width) / image.Width;
            Bitmap resized = new Bitmap(image, new Size(width, height));

            // Default color , you can set yours before this line
            Console.ForegroundColor = ConsoleColor.Green;
            string asciiChars = "@#S%?*+;:,. ";

            //start by the height
            for (int y = 0; y < resized.Height; y++)
            {
                //then width
                for (int x = 0; x < resized.Width; x++)
                {
                    //color the pixel on x and y
                    Color pixel = resized.GetPixel(x, y);

                    // Convert to grayscale
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;

                    // Map grayscale to ASCII
                    int index = (gray * (asciiChars.Length - 1)) / 255;

                    Console.Write(asciiChars[index]);
                }
                Console.WriteLine();
            }
        }

    }//end of the class
}//end of namespace