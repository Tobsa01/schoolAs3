using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.View
{
    public partial class MainView : Form
    {
        private MainController Controller { get; }
        private WindowsFormsApp1.Model.MainModel Model { get; }
        public MainView()
        {
            InitializeComponent();
            Controller = new MainController(this);
            Model = Controller.Model;
        }
    }
}
