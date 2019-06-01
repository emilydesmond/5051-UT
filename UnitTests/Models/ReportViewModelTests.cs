﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Models;
using System.Collections.Generic;

namespace UnitTests.Models
{
    [TestClass]
    public class ReportViewModelTests
    {
        [TestMethod]
        public void ReportViewModel_Instantiate_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ReportViewModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ReportViewModel_NumberOfUsers_Get_Default_Should_Pass()
        {
            // Arrange
            var myTest = new ReportViewModel();

            // Act
            var result = myTest.NumberOfUsers; 

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void LogViewModel_Set_Default_Should_Pass()
        {
            // Arrange
            var myTest = new LogViewModel();
            var myList = new List<LogModel>();
            myList.Add(new LogModel { PhoneID = "Phone" });

            // Act
            myTest.LogList = myList;
            var result = myTest.LogList;

            // Assert
            Assert.AreEqual("Phone", result[0].PhoneID);
        }
    }
}
