﻿namespace IntegrationTest.Services
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Repository.XMLData;
    using KundtManager;

    [TestClass]
    public class LoadFilesTest
    {
        [ClassInitialize]
        public void LoadDI()
        {
            StartDI.ConfigureServices();            
        }

        [TestMethod]
        public void GetSavedStructs_Ok()
        {
            //Arrange
            IXMLStruct xmlData = new XMLStruct();
            LoadStructs ls = new LoadStructs(xmlData);

            //Act


            //Assert
        }

    }
}
