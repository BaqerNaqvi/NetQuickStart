using Serilog;

namespace AONetQuickStart.Models
{
    public class Human
    {
      

        private readonly ILogger<Human> _logger;

        public Human() {

            
        }

        public void Print()
        {
            Log.Error("whats up");
        }
    }
}
