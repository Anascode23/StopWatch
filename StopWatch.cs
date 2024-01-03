public class StopWatch
{
    public DateTime Start() { 
        var start = DateTime.Now;
       
        System.Console.WriteLine("timer started");
        return start;
    }
    public void Stop() {
         var stop =DateTime.Now;
         var timespan = Start() - stop; 
         System.Console.WriteLine(timespan.TotalNanoseconds);
        System.Console.WriteLine("timer stopped");
     }
} 
