using System;
using System.IO;
using System.Media;

namespace POE_part_1_practice
{
    public class voice_greeting
    {
        public voice_greeting()
        {
            //getting full project location for voice greeting
            string full_location = AppDomain.CurrentDomain.BaseDirectory;

            //replace the bin\Debug folder in the full_location 
            string new_path = full_location.Replace("bin\\Debug\\", "");

            //try and catch
            try
            {
                string full_path = Path.Combine(new_path, "voice_greeting.wav");

                //create an instance for the SoundPlay class
                using (SoundPlayer play = new SoundPlayer(full_path))
                {

                    //play audio
                    play.PlaySync();
                }//end of using
            }
            catch (Exception error){
                Console.WriteLine(error.Message);
            }//end of catch

        }//end of constructor
    }//end of class
}//end of namespace