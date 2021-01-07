using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WindowsFormsApp1.Model.Tests
{
    [TestClass()]
    public class BookAdminModelTests
    {
        [TestMethod()]
        public void IssueExistsTest()
        {
            LibratorsEntities context = new LibratorsEntities();
            BookAdminModel b = new BookAdminModel();
          
            Issues i = new Issues() 
            {
                FK_Inventar_Number= "0000000000000005",
                FK_UserID = 1,
                FK_MANumber = 1234,
                IssueState = "aus",
                ReturnDate = DateTime.Now,
                StartDate = DateTime.Now.AddDays(-12)            
            };
            Assert.IsTrue(BookAdminModel.IssueExists(i,"aus"));
        }
    }
}