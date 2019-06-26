using Bunnings.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace Bunnings.Common.Pages
{
     public class Product
    {
        #region Initialize Web Elements

        //Web Element for Search Bar
        private IWebElement SearchBar => DriverContext.Driver.FindElement(By.XPath("//*[@id='headerMainMenu']/div[2]/div/div[1]/div/div/input[1]"));

        //Web Element for Product or Item
        private IWebElement Item => DriverContext.Driver.FindElement(By.XPath("/html/body/form/div[6]/div/div[2]/div[3]/div/div/section/div[2]/div/div[1]/div[1]/div/section/article[1]/a/div/div[1]"));
        
        //Web Element to enter Amount of Product
        private IWebElement Amount => DriverContext.Driver.FindElement(By.XPath("//*[@id='select2-select-size-container']"));

        //Web Element to enter Quantity of Product
        private IWebElement Quantity => DriverContext.Driver.FindElement(By.XPath("//*[@id='body_1_ctl01_ucAddLineItemButtons_ucQuantityTextBox']"));

        //Web Element to Add Button -Add to Wish List
        private IWebElement AddItemButton => DriverContext.Driver.FindElement(By.XPath("/html/body/form/div[6]/div/div[2]/div[1]/section/div/div[2]/div[4]/div[2]/div[3]/button"));

        // Web Element for Wish List Page
        private IWebElement WishList => DriverContext.Driver.FindElement(By.XPath("//*[@id='RefreshHeader']/header/div[3]/div/div[2]/ul/li[2]/a"));
                        
        #endregion

        #region Methods
        public void EnterKeyword()
        {
            //Click on Search Bar
            SearchBar.Click();

            //Type Product Name in Search
            SearchBar.SendKeys("Paint");

            //Search Products 
            SearchBar.SendKeys(Keys.Enter);
            
        }

        public void SelectProduct()
        {
            // Select one Product from the list
            Item.Click();

        }

        public void ProductDetails()
        {
            // Enter the amount of the selected Product
            Amount.Click();

            // Enter the Quantity of selected Product
            Quantity.Click();
        }

        public void AddItemToWishList()
        {
          //Click on Add Button to add the Product to Wish List
            AddItemButton.Click();

            // Explicit wait 
            WebDriverWait wait = new WebDriverWait(DriverContext.Driver, TimeSpan.FromSeconds(30));
            wait.Until(a => DriverContext.Driver.FindElement(By.XPath("//button//span[text()='Added']")).Enabled);
            
           
    }

        public void ValidateAddedItem()
        {
            // Check the added Item in the Wish List
            WishList.Click();

        }

        public void verify()
        {
            bool present;
            try
            {
                DriverContext.Driver.FindElement(By.CssSelector("#content-layout_inside-anchor > div.container_12 > section:nth-child(5) > table > thead > tr > th.text-align-left"));

                present = true;
                
            }

            catch (NoSuchElementException e)
            {
                present = false;
               
            }
            
        }
     
        #endregion
    }
}
