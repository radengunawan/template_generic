using System;

namespace template_generic
{

    class Gajah
    {
        public int xxxx;
        public string yyyy;

        public void WhoAmI()
        {
            
        }


    } // end of class



    // BEGIN of Main Class
    class Program
    {
        static void Main(string[] args)
        {    //---------START AFTER THIS LINE-------------START AFTER THIS LINE------------START AFTER THIS LINE--------------------


            char sender = Console.ReadKey(true).KeyChar;
            int sender_index = (int)sender - 48;

            Console.Write("\nReceiver index: ");
            char receiver = Console.ReadKey(true).KeyChar;
            int receiver_index = (int)receiver - 48;

            // ---- DON'T WRITE BEYOND THIS LINE------------
        }// END of Main program

    } //END of Main class
} //END of namespace
