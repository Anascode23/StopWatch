public class StopWatch
{
    public DateTime Start()
    {
        var start = DateTime.Now;

        Console.WriteLine("timer started");
        return start;
    }
    public void Stop(DateTime start)
    {
        var stop = DateTime.Now;
        var timespan = stop - start;
        Console.WriteLine("Elapsed time: " + timespan.TotalMilliseconds);
        Console.WriteLine("timer stopped");
    }
}
