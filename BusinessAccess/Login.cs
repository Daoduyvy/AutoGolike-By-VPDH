using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessAccess
{
    class Login
    {
        /// <summary>
        /// Login function
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Pass"></param>
        /// <param name="driver"></param>
        void DangNhapGoLike(string ID, string Pass, ChromeDriver driver)
        {
            try
            {
                var _id = driver.FindElementByXPath("//*[@id=\"app\"]/div/div/div/form/div[1]/input");
                _id.SendKeys(ID);
                var _pass = driver.FindElementByXPath("//*[@id=\"app\"]/div/div/div/form/div[2]/input");
                _pass.SendKeys(Pass);
                Thread.Sleep(1000);
                var _DangNhap = driver.FindElementByXPath("//*[@id=\"app\"]/div/div/div/form/div[3]/button");
                _DangNhap.Click();
            }
            catch
            {

            }
        }

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

                //Kiem tra 2FA



            }
            catch
            {

            }


        }
    }
}
