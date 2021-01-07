using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Tests
{
    [TestClass()]
    public class CurrentUserTests
    {
        [TestMethod()]
        public void getAdminTest()
        {
            CurrentUser.setCurrentUser(new Users());
            Assert.IsFalse(CurrentUser.getAdmin());
        }
    }
}