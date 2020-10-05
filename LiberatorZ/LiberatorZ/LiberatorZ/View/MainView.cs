using System.Windows.Forms;
using LiberatorZ.Controller;
using LiberatorZ.Model;

namespace LiberatorZ.View
{
    public partial class MainView : Form
    {
        private MainController Controller { get; }
        private MainModel Model { get; }
        public MainView()
        {
            InitializeComponent();
            Controller = new MainController(this);
            Model = Controller.Model;
        }

        public void CloseForm()
        {
            Application.Exit();
        }
    }
}
