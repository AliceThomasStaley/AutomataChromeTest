using System;
using NavegacionAutomatica.Clases;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NavegacionAutomatica
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(Constantes.StrRutaChromeDriver);
            driver.Url = "https://www.amazon.com.mx/";
            IWebElement txtbusqueda = driver.FindElement(By.Id("twotabsearchtextbox"));
            IWebElement btnBusqueda = driver.FindElement(By.Id("nav-search-submit-button"));
            txtbusqueda.SendKeys("Nintendo Switch Oled");
            btnBusqueda.Click();


        }
    }
}
