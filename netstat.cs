using System;

namespace netstat
{
    class netstat
    {
        //this only works with no arg right now (and it's not finished)
        //TODO netstat -a | netstat -b | netstat -e | netstat -f | netstat -n | netstat -o | netstat -p <proto> | netstat -q 
        ////// netstat -r | netstat -s | netstat -t | netstat -x | netstat -y | netstat <interval>
        static void Main(string[] args)
        {
            string title = "C:\\Windows\\System32\\cmd.exe - netstat ";
            for(int i = 0; i < args.Length; i++){
                title = title + args[i] + " ";
            }
            Console.Title = title;
            Console.WriteLine("\nActive Connections\n");
            Console.WriteLine("  Proto  Local Address          Foreign Address        State");
            Console.WriteLine("  TCP    10.0.0.3:50000         euw-13-337-69-1:https  ESTABLISHED");
            Console.WriteLine("  TCP    [2001:8003:4201:f690:d0c3:695d:1337:8888]:58359  jp05s02-in-x32:https  TIME_WAIT");
            //Console.ReadKey(); //uncomment to require keypress to end
        }
    }
}
