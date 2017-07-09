﻿// <copyright file="BingTests.cs" company="Automate The Planet Ltd.">
// Copyright 2017 Automate The Planet Ltd.
// Licensed under the Apache License, Version 2.0 (the "License");
// You may not use this file except in compliance with the License.
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <author>Anton Angelov</author>
// <site>https://automatetheplanet.com/</site>
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace HuddlePageObjectsElementsStringProperties
{
    [TestClass]
    public class BingTests
    {
        private IWebDriver _driver;

        [TestInitialize]
        public void SetupTest()
        {
            _driver = new FirefoxDriver();
            _driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 30));
        }

        [TestCleanup]
        public void TeardownTest()
        {
            _driver.Quit();
        }

        [TestMethod]
        public void SearchTextInBing_First()
        {
            var bingMainPage = new BingMainPage(_driver);
            bingMainPage.Navigate();
            bingMainPage.Search("Automate The Planet");
            bingMainPage.AssertResultsCount("236,000 RESULTS");
        }
    }
}
