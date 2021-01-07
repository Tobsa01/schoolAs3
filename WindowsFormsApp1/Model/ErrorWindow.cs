using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public static class ErrorWindow
    {
        public static void ShowCustomErrorWindow(string errorMessage, string errorTitle, MessageBoxIcon boxIcon, MessageBoxButtons boxButtons)
        {

            MessageBox.Show(errorMessage, errorTitle,
                boxButtons, boxIcon);
        }

        public static void ShowExceptionWindow(this Exception exception)
        {
            ShowCustomErrorWindow(exception.Message, "Exception", MessageBoxIcon.Error, MessageBoxButtons.OK);
        }
    }
}
