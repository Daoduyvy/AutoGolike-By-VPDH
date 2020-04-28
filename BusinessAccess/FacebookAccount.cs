using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccess
{
    public class FacebookAccount
    {
        void DangNhapFaceBook(string ID, string Pass, string FA, ChromeDriver driver)
        {
            driver.Url = "http://facebook.com";
            driver.Navigate();
            try
            {
                var email = driver.FindElementByCssSelector("#email");
                email.SendKeys(ID);

                var matkhau = driver.FindElementByCssSelector("#pass");
                matkhau.SendKeys(Pass);

                var dangnhap = driver.FindElementByXPath("//*[@id=\"u_0_b\"]");
                matkhau.SendKeys(OpenQA.Selenium.Keys.Return);

                ////Kiem Tra Ma 2FA
                //var secretKey = Base32Encoding.ToBytes(fa);
                //var totp = new Totp(secretKey);
                //var otp = totp.ComputeTotp();
                //string facode = otp.ToString();



            }
            catch
            {

            }


        }

        ChromeDriver CreateProfile(string userAgent, string pathProfile)
        {
            // Tạo Chrome Options
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("user-data-dir=" + pathProfile);
            options.AddArguments("chrome.switches", "--disable-extensions --disable-extensions-file-access-check --disable-extensions-http-throttling --disable-infobars --enable-automation --start-maximized");
            options.AddUserProfilePreference("credentials_enable_service", true);
            options.AddUserProfilePreference("profile.password_manager_enabled", true);
            options.AddArgument(string.Format("--user-agent={0}", userAgent));

            ChromeDriver driver = new ChromeDriver(options);

            //Lưu user agent đã sử dụng cho profile này để sử dụng trong lần tiếp theo
            File.Create(pathProfile + "\\UA.txt").Dispose();
            using (StreamWriter sw = new StreamWriter(pathProfile + "\\UA.txt"))
            {
                sw.WriteLine(userAgent);
            }

            return driver;

        }

    }
}
