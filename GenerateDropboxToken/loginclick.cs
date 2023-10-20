using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateDropboxToken
{
    class loginclick
    {
        public void Login()
        {
            string url = "http://localhost:8080/dropbox/";
            ChromeOptions option = new ChromeOptions();
            var service = ChromeDriverService.CreateDefaultService(AppDomain.CurrentDomain.BaseDirectory);
            IWebDriver chrome = new ChromeDriver(service, option, TimeSpan.FromMinutes(10));
            try
            {
                Thread.Sleep(10000);
                chrome.Url = url;
                Thread.Sleep(10000);
                string username = "test@test.com.sv"; // Tu dirección de correo electrónico
                string password = ""; // Tu contraseña
                                                    //string username = "office@capital-knowledge.co.jp"; string password = "capitaloo13";

                WebElement pageHtml = (WebElement)chrome.FindElement(By.ClassName("auth-buttons-container"));
                //MessageBox.Show("HtmlContent", pageHtml.Text);
                Thread.Sleep(20000);
                String val = pageHtml.GetAttribute("value");
                Console.WriteLine("Html" + val);
                //Thread.Sleep(10000);
                //        chrome.FindElement(By.Name("login_email")).SendKeys(username);
                //Thread.Sleep(10000);
                //        chrome.FindElement(By.Name("login_password")).SendKeys(password);

                //Thread.Sleep(200000);
                //        chrome.FindElement(By.XPath("//button[@type='submit']")).Click();
                //Thread.Sleep(200000);
                //        chrome.FindElement(By.Id("generate-token-button")).Click();
                //Thread.Sleep(20000);
                //        WebElement l = (WebElement)chrome.FindElement(By.Id("generated-token"));
                //// enter texts
                //l.SendKeys("Selenium");
            }
            catch (Exception ex)
            {

            }

        }
    }
}
