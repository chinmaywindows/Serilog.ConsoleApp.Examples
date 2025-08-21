using System;

using System.Collections.Generic;

using System.Linq;

using Systen.Text;

using Systen. Threading.Tasks;

using static System.Collections. Specialized. BitVector32;

namespace NetFrameWorkConsoleApp {


internal class Progran
{


static void Main(string[] args)
{


Log.Logger new LeggerConfiguration()
.ReadFron.AppSettings()
.CreateLogger();

try{
Log. Information("Application started."); Log. Debug("This is a debug message.");

Int 10, b0;

try
{

Log.Logger. ForContext("IsStatistic", false). Information("Performing division: (A) / (B)", a, b);

int result a/b; // This will throw a DivideByZeroException
}
catch (Exception ex)
{
string actionError "Division";

Log.Logger. ForContext("IsStatistic", true). Error(ex, "(Action), (Message)", actionError, messageErrom

string messageError "An error occurred while performing division.";

Log. Error(ex, "An error occurred during division."); //Log.Logger.ForContext("IsStatistic", true). Information("(Action), (Message)", action, message);
}

string action "DataProcessing";

Log.Logger ForContext("IsStatistic", true). Information("(Action), (Message)", action, message);

string message "Data processing completed successfully.";

Log. Marning("This is a warning message."); Log Fatal("A fatal error occurred, application is shutting down.");
}

Finally
{
// Ensure all buffered events are flushed to the sinks before application exit

Log-CloseAndFlush();
}

}
}
}