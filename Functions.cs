using System;
using System.Collections.Generic;
using System.Text;
using rcloneapp3;
using System.Threading;
using System.Security.Cryptography.X509Certificates;
using Global;

namespace functions
{
    public class functions
    {
        public static void configs()
        {
            int times = 0;

            while (times < Global.Variables.configs.Length)
            {
                Console.WriteLine(Global.Variables.configs[times]);
                times = times + 1;
            }
        }

        public static void Mount(string config, string letter)
        {
            command($"rclone mount {config}:/ {letter}: --fuse-flag --VolumePrefix=\\gdrive\\{config}");

            Console.WriteLine($"Mounting {config}...");
        }

        public static void command(string command)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = $"/C {command}";
            process.StartInfo = startInfo;
            process.Start();
        }

    }
}
