using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Link;
using System.Web.Mvc;
using MvcWebApplication;
using MvcWebApplication.Controllers;

namespace MvcWebApplicationTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Index()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ViewResult result = controller.Index() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
