using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Thread3AllProc
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] process = Process.GetProcesses();
                  foreach (Process p in process)
             {
                 Console.WriteLine("{0}   - {1}", p.ProcessName, p.Id);
             }
                  foreach (Process p in process)
                  {
                      if (p.Id == 1184 || p.Id == 2828)
                          p.Close();
                  }
        }

  
    }
}
