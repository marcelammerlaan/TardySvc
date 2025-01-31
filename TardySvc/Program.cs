using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

// sc create tardysvc binPath="C:\Users\xxx\source\repos\TardySvc\TardySvc\bin\Debug\TardySvc.exe"
namespace TardySvc
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new Tardy()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
