public class StopWatch
{
    private bool _running;
    public void Start()
    {
        var start = DateTime.Now;

        if (_running == false)
        {
            _running = true;
            Console.WriteLine("timer started");
        }
        else
        {
            throw new InvalidOperationException();
        }
    }



    public void Stop(DateTime start)
    {
        var stop = DateTime.Now;
        var timespan = stop - start;
        _running = false;
        Console.WriteLine("Elapsed time: " + timespan.TotalSeconds);
        Console.WriteLine("timer stopped");
    }
}
