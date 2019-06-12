namespace UnitTest
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Repository.XMLData; 

    [TestClass]
    public class XMLTest
    {
        [TestMethod]
        public void LoadFileStruct_Ok()
        {
            //Arrange
            XMLStruct xmlStruct = new XMLStruct();
            
            //Act
            var test = xmlStruct.GetStructureFiles();

            //Assert
            Assert.AreEqual(1, test.Count);
        }
    }
}


