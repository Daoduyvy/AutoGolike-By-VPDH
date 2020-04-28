using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessAccess
{
    class Job
    {
        Boolean Like_Page(ChromeDriver driver)
        {
            Boolean check = false;
            try
            {
                var element = driver.FindElementByXPath("//*[@id=\"u_0_z\"]/div/div/div[1]/div/span/button");
                string str = element.Text;
                if (str.Contains("Thích") == true)
                {
                    element.Click();
                    Thread.Sleep(2000);

                    check = true;
                    driver.Close();

                }


            }
            catch
            {
                driver.Close();
                check = false;
            }
            return check;
        }

        Boolean Follow(ChromeDriver driver)
        {
            Boolean check_follow = false;
            try
            {
                var element = driver.FindElementsByXPath("//a[@role = 'button']");
                var _number = element.Count();
                if (_number != 0)
                {
                    for (int i = 0; i < _number; i++)
                    {
                        if (element[i].Text.Contains("Theo dõi") == true)
                        {
                            element[i].Click();
                            Thread.Sleep(10000);
                            check_follow = true;
                            driver.Close();
                            break;
                        }
                    }
                }


                Thread.Sleep(2000);


            }
            catch
            {
                driver.Close();

                check_follow = false;
            }

            return check_follow;
        }

        Boolean Like_Post(ChromeDriver driver)
        {
            Boolean check_like_post = false;
            try
            {
                Thread.Sleep(10000);
                var body = driver.FindElementByTagName("body");
                body.SendKeys(OpenQA.Selenium.Keys.Escape);
                var element = driver.FindElementsByXPath("//a[@aria-pressed = 'false']");

                var _number = element.Count();
                if (_number != 0)
                {
                    for (int i = 0; i < _number; i++)
                    {
                        if (element[i].Text.Contains("Thích") == true)
                        {
                            element[i].Click();
                            Thread.Sleep(10000);
                            check_like_post = true;
                            driver.Close();
                            break;
                        }
                    }
                }

            }
            catch
            {
                driver.Close();
                check_like_post = false;
            }

            return check_like_post;
        }
    }
}
