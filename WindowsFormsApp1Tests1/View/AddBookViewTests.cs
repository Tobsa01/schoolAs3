using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WindowsFormsApp1.Controller;

namespace WindowsFormsApp1.View.Tests
{
    [TestClass()]
    public class AddBookViewTests
    {
        [TestMethod()]
        public void checkInputFieldsTest()
        {
            AddBookView abv = new AddBookView(new Controller.AddBookController());
            Assert.IsFalse(abv.checkInputFields());
        }
    }
}