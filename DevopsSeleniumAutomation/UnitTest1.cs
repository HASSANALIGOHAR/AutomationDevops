using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace DevopsSeleniumAutomation
{
    [TestClass]
    public class UnitTest1
    {
            [TestMethod]
            public void TestCase01_Login()
            { 
                WebDriver driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Url = "https://www.saucedemo.com/";
                Thread.Sleep(1000);
                driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
                driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
                driver.FindElement(By.Id("login-button")).Click();
                Thread.Sleep(1000);
                driver.Close();
            }

            [TestMethod]
            public void TestCase02_AddProduct()
            {
                WebDriver driver = new ChromeDriver();
                Thread.Sleep(1000);
                driver.Manage().Window.Maximize();
                driver.Url = "https://www.saucedemo.com/";
                Thread.Sleep(1000);
                driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
                driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
                driver.FindElement(By.Id("login-button")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
                driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
                Thread.Sleep(1000);
              
                //scroll down
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.scrollBy(0,300)");
                driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt")).Click();
                driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket")).Click();
                js.ExecuteScript("window.scrollBy(0,200)");
                driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie")).Click();
                driver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)")).Click();
                Thread.Sleep(500);
                js.ExecuteScript("window.scrollBy(0,100)");
                Thread.Sleep(1000);
                driver.Close();
            }

            [TestMethod]
            public void TestCase03_AddtoCart()
            {
                WebDriver driver = new ChromeDriver();
                Thread.Sleep(1000);
                //WebDriver driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Url = "https://www.saucedemo.com/";
                Thread.Sleep(1000);
                driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
                driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
                driver.FindElement(By.Id("login-button")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
                driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
                Thread.Sleep(1000);

                //scroll down
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.scrollBy(0,300)");
                driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt")).Click();
                driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket")).Click();
                js.ExecuteScript("window.scrollBy(0,200)");
                driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie")).Click();
                driver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)")).Click();
                Thread.Sleep(500);
                js.ExecuteScript("window.scrollBy(0,100)");
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//*[@id=\"shopping_cart_container\"]/a")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.Id("remove-sauce-labs-backpack")).Click();  //remove item
                Thread.Sleep(1000);
                driver.FindElement(By.Id("checkout")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.Id("first-name")).SendKeys("Hassan Ali");
                driver.FindElement(By.Id("last-name")).SendKeys("Gohar");
                driver.FindElement(By.Id("postal-code")).SendKeys("75400");
                driver.FindElement(By.Id("continue")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.Id("finish")).Click();
                string ExpectedResult = driver.FindElement(By.XPath("//*[@id=\"checkout_complete_container\"]/h2")).Text;
                Assert.AreEqual(ExpectedResult, "THANK YOU FOR YOUR ORDER");
                driver.Close();
            }

            [TestMethod]
            public void TestCase04_NavigationBar()
            {
                WebDriver driver = new ChromeDriver();
                Thread.Sleep(1000);
                //WebDriver driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Url = "https://www.saucedemo.com/";
                Thread.Sleep(1000);
                driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
                driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
                driver.FindElement(By.Id("login-button")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.Id("react-burger-menu-btn")).Click();
                Thread.Sleep(3000);
                driver.FindElement(By.Id("logout_sidebar_link")).Click();
                driver.Close();
            }
            [TestMethod]
            public void TestCase05_AboutScreen()
            {
                WebDriver driver = new ChromeDriver();
                Thread.Sleep(1000);
                //WebDriver driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Url = "https://www.saucedemo.com/";
                Thread.Sleep(1000);
                driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
                driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
                driver.FindElement(By.Id("login-button")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.Id("react-burger-menu-btn")).Click();
                Thread.Sleep(3000);
                driver.FindElement(By.Id("logout_sidebar_link")).Click();
                driver.Close();
            }



            [TestMethod]
            public void TestCase06_ClickOnSoicalIcon()
            {
                WebDriver driver = new ChromeDriver();
                //WebDriver driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Url = "https://www.saucedemo.com/";
                Thread.Sleep(1000);
                driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
                driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
                driver.FindElement(By.Id("login-button")).Click();
                Thread.Sleep(1000);

                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.scrollBy(0,800)");
                Thread.Sleep(1000);
                driver.FindElement(By.ClassName("social_twitter")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.ClassName("social_facebook")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.ClassName("social_linkedin")).Click();
                Thread.Sleep(1000);
                driver.Close();
                driver.Quit();

            }
             [TestMethod]
            public void TestCase07_ClickOnAboutScreen()
            {
            WebDriver driver = new ChromeDriver();
                //WebDriver driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Url = "https://www.saucedemo.com/";
                Thread.Sleep(1000);
                driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
                driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
                driver.FindElement(By.Id("login-button")).Click();
                Thread.Sleep(1000);
                Thread.Sleep(1000);
                driver.FindElement(By.Id("react-burger-menu-btn")).Click();
                Thread.Sleep(3000);
                driver.FindElement(By.Id("about_sidebar_link")).Click();
                driver.Close();
            }
        

             



    }
}
