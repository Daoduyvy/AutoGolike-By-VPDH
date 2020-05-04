using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccess
{
    public class Auto
    {
        ChromeDriver Create_Profile(string pathProfile, string userAgent)
        {

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("user-data-dir=" + pathProfile);
            //options.AddArgument("--start-maximized");
            options.AddArguments("chrome.switches", "--disable-extensions --disable-extensions-file-access-check --disable-extensions-http-throttling --disable-infobars --enable-automation --start-maximized");
            options.AddUserProfilePreference("credentials_enable_service", true);
            options.AddUserProfilePreference("profile.password_manager_enabled", true);
            options.AddArgument(string.Format("--user-agent={0}", userAgent));
            ChromeDriver driver = new ChromeDriver(options);
            File.Create(pathProfile + "\\UA.txt").Dispose();
            using (StreamWriter sw = new StreamWriter(pathProfile + "\\UA.txt"))
            {
                sw.WriteLine(userAgent);
            }



            return driver;
        }
    }
}
