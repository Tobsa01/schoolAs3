using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1.Controller
{
    public class GetUserIdController : IController
    {
        private GetUserIdView View;
        
        public GetUserIdController()
        {
            View = new GetUserIdView(this);
        }
       
        public void ShowForm()
        {
            View.ShowForm();
        }
        public void close()
        {
            View.HideForm();
            var bookView = ControllerManager.Get<BookController>();
            bookView.RefreshData();
        }

    }
}
