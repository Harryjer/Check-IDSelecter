using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
class IdSelecter
{
    static void Main()
    {
        string url = "https://testing.todorvachev.com/selectors/id/";
        string id = "testImage";

        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);

        IWebElement element = driver.FindElement(By.Id(id));

        if(element.Displayed)
        {
            GreenMessage("Element is displayed");
        }
        else
                {
            RedMessage("Element is not displayed");
        }
        driver.Quit();


    }

    private static void RedMessage(string message)
    {
        System.Console.ForegroundColor = System.ConsoleColor.Red;
        System.Console.WriteLine(message);
        System.Console.ForegroundColor = System.ConsoleColor.White;
    }

    private static void GreenMessage(string message)
    {
        System.Console.ForegroundColor = System.ConsoleColor.Green;
        System.Console.WriteLine(message);
        System.Console.ForegroundColor = System.ConsoleColor.White;
    }
}

