public class StopWatch
{
    public DateTime start;
    public DateTime stop;
    public bool running;

    public void Start()
    {
        start = DateTime.Now;

        if (running == false)
        {
            running = true;
            Console.WriteLine("timer started");
        }
        else
        {
            throw new InvalidOperationException();
        }
    }



    public void Stop()
    {
        stop = DateTime.Now;
        var timespan = stop - start; //debugg to see how Start variable works
        running = false;
        Console.WriteLine("Elapsed time: " + timespan.TotalSeconds);
        Console.WriteLine("timer stopped");
    }
}
