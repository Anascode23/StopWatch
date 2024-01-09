Console.WriteLine("Start the timer type start and type stop to end timer: ");

var stopwatch = new StopWatch();
while (true)
{
    
    var userinput = Console.ReadLine();
    if(userinput == "exit")
        break;


    if (userinput == "start")
        stopwatch.Start();


    if (userinput == "stop")
        stopwatch.Stop(DateTime.Now);

}


