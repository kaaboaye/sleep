using System.Windows.Forms;

namespace sleep
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.SetSuspendState(PowerState.Suspend, false, true);
        }
    }
}
