using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    static void Main()
    {
        // Set the URL
        string url = "https://userinyerface.com/";

        // Initialize the ChromeDriver (make sure to download and specify the path to chromedriver.exe)
        IWebDriver driver = new ChromeDriver("path/to/chromedriver.exe");

        try
        {
            // Test Case #1: Help Form Testing
            // Step 1: Navigate to the main page
            driver.Navigate().GoToUrl(url);

            // Verify if the main page is open
            if (driver.Title.Contains("User Inyerface"))
            {
                Console.WriteLine("Step 1: Main page is open - PASSED");
            }
            else
            {
                Console.WriteLine("Step 1: Main page is open - FAILED");
            }

            // Step 2: Click the "Click Here" link
            IWebElement clickHereLink = driver.FindElement(By.LinkText("Click Here"));
            clickHereLink.Click();

            // Verify if the game page is open
            if (driver.Title.Contains("User Inyerface - Game"))
            {
                Console.WriteLine("Step 2: Game page is open - PASSED");
            }
            else
            {
                Console.WriteLine("Step 2: Game page is open - FAILED");
            }

            // Step 3: Click the "Help" button on the Help form
            IWebElement helpButton = driver.FindElement(By.XPath("//button[contains(text(), 'Help')]"));
            helpButton.Click();

            // Verify if the Help response is displayed
            IWebElement helpResponse = driver.FindElement(By.ClassName("help-content"));

            Console.WriteLine("Step 3: Help response is displayed - PASSED");

            // Test Case #2: Timer Testing
            // Step 1: Navigate to the main page
            driver.Navigate().GoToUrl(url);

            // Verify if the main page is open
            if (driver.Title.Contains("User Inyerface"))
            {
                Console.WriteLine("Step 1: Main page is open - PASSED");
            }
            else
            {
                Console.WriteLine("Step 1: Main page is open - FAILED");
            }

            // Step 2: Click the "Click Here" link
            IWebElement clickHereLink2 = driver.FindElement(By.LinkText("Click Here"));
            clickHereLink2.Click();

            // Verify if the game page is open
            if (driver.Title.Contains("User Inyerface - Game"))
            {
                Console.WriteLine("Step 2: Game page is open - PASSED");
            }
            else
            {
                Console.WriteLine("Step 2: Game page is open - FAILED");
            }

            // Step 3: Verify that the timer starts from zero
            IWebElement timerElement = driver.FindElement(By.Id("timer"));
            string timerText = timerElement.Text;
            if (timerText == "00:00:00" || timerText == "00:00")
            {
                Console.WriteLine("Step 3: Timer starts from zero - PASSED");
            }
            else
            {
                Console.WriteLine("Step 3: Timer starts from zero - FAILED");
            }

            // Test Case #3: Next Button
            // Step 1: Click the "Next" button
            IWebElement nextButton = driver.FindElement(By.XPath("//button[contains(text(), 'Next')]"));
            nextButton.Click();

            // Implement verifications for Test Case #3 here.

        }
        catch (Exception e)
        {
            // Output error message
            Console.WriteLine("Test Case - FAILED");
            Console.WriteLine(e.Message);
        }
        finally
        {
            // Close the browser
            driver.Quit();
        }
    }
}
