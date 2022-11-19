using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebDriver = SeleniumPOM.Driver.WebDriver;

namespace SeleniumPOM.Page;

public class HomePage
{
    private IWebDriver driver = WebDriver.Instance;

    public IWebElement BackPack => driver.FindElement(By.ClassName("inventory_item_img"));
    public IWebElement AddToCart => driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));

    public IWebElement BackToProducts => driver.FindElement(By.Id("back-to-products"));


}
