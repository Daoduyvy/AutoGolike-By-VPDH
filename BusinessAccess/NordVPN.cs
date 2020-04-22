using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccess
{
    public class NordVPN
    {
        public void RunCommandCMD(string command)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            Process cmd = new Process();
            cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.Arguments = "/c " + command;
            cmd.Start();
            cmd.WaitForExit();
        }
        public void NordDisconnect()
        {
            RunCommandCMD("\"C:\\Program Files (x86)\\NordVPN\\NordVPN.exe\" -d");
        }
        public void NordResetIP()
        {
            RunCommandCMD("\"C:\\Program Files (x86)\\NordVPN\\NordVPN.exe\" -changeip");
        }
        public void NordChangeRegion(string region)
        {
            string cmd = "\"C:\\Program Files (x86)\\NordVPN\\NordVPN.exe\"  -c -g" + region;
            RunCommandCMD(cmd);
        }
    }
}
