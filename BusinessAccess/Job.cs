using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessAccess
{
    class Job
    {
        Boolean proccessJob(ChromeDriver driver, string str)
        {
            Thread.Sleep(20000);
            Boolean _check_Job = false;
            //error JOB
            try
            {
                if (driver.Title.Contains("Cảnh Báo"))
                {
                   
                    driver.Close();
                    var element = driver.FindElementByXPath("//*[@id=\"app\"]/div/div[1]/div[2]/div[3]/div[1]");
                    element.Click();
                    Thread.Sleep(1000);
                    element = driver.FindElementByXPath("//*[@id=\"app\"]/div/div[1]/div[2]/div[3]/div[2]/div/div[6]");
                    element.Click();
                    Thread.Sleep(1000);
                    element = driver.FindElementByXPath("//*[@id=\"app\"]/div/div[1]/div[2]/div[3]/div[2]/div/button");
                    element.Click();
                    _check_Job = false;
                }
            }
            catch
            {

            }


            //TĂNG LƯỢT THEO DÕI

            if (str.Contains("TĂNG LƯỢT THEO DÕI") == true)
            {
                bool check_follow = Follow(driver);
                if (check_follow == false)
                {
                   // Status("Follow lỗi mẹ rồi ");
                }
                _check_Job = check_follow;


            }


            //TĂNG LIKE CHO FANPAGE
            if (str.Contains("TĂNG LIKE CHO FANPAGE") == true)
            {
                Boolean checkjob = Like_Page(driver);
                if (checkjob == false)
                {
                    //Status("Lỗi mẹ rồi ");

                }
                _check_Job = checkjob;
            }


            //TĂNG LIKE CHO BÀI VIẾT
            if (str.Contains("TĂNG LIKE CHO BÀI VIẾT") == true)
            {
                Boolean check_like_post = Like_Post(driver);
                if (check_like_post == false)
                {
                    //Status("Like Post Lỗi Rồi ");

                }
                _check_Job = check_like_post;
            }

            //TĂNG HAHA CHO BÀI VIẾT
            if (str.Contains("TĂNG HAHA CHO BÀI VIẾT") == true)
            {

                driver.Close();
                _check_Job = false;
            }

            //TĂNG SAD CHO BÀI VIẾT
            if (str.Contains("TĂNG SAD CHO BÀI VIẾT") == true)
            {

                driver.Close();
                _check_Job = false;
            }
            return _check_Job;
        }

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
                    //Status("Like Page Ok");
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
                //Status("Nhiệm Vụ Theo Dõi Lỗi Rồi !");
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
