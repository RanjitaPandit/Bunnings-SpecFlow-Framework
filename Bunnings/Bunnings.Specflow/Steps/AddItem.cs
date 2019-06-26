using System;
using Bunnings.Common.Pages;
using Bunnings.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Bunnings.Specflow
{
    [Binding]
    public class AddItem
    {
        [Given(@"I click on Search Bar and enter the keyword")]
        public void GivenIClickOnSearchBar()
        {

            //Click on Search Box
            var EnterKeyword_Obj = new Product();
            EnterKeyword_Obj.EnterKeyword();                       
            
        }

      
        [Given(@"Select an Item from the Product List")]
        public void GivenSelectAnItemFromTheProductList()
        {
            //Click
            var SelectProduct_Obj = new Product();
            SelectProduct_Obj.SelectProduct();

        }

        [Given(@"I enter Product details")]
        public void GivenIEnterProductDetails()
        {
            //Click 
            var ProductDetails_Obj = new Product();
            ProductDetails_Obj.ProductDetails();
        }

        [When(@"I click on Add to Wish List")]
        public void WhenIClickOnAddToWishList()
        {
            //Click 
            var AddItemToWishList_Obj = new Product();
            AddItemToWishList_Obj.AddItemToWishList();
        }

        [Then(@"The item should Successfully be added to My Wish List")]
        public void ThenTheItemShouldSuccessfullyBeAddedToMyWishList()
        {
            
             //Click 
            var ValidateAddedItem_Obj = new Product();
            ValidateAddedItem_Obj.ValidateAddedItem();

            //Verify
            var Verify_Obj = new Product();
            Verify_Obj.verify();
          
        }

    }
}
