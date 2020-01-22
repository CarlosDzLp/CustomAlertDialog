using System;
using CustomAlertDialog.Droid;
using Xamarin.Forms;

[assembly:Dependency(typeof(Dialogs))]
namespace CustomAlertDialog.Droid
{
    public class Dialogs : CustomAlertDialog.IDialogs//IDialogs
    {
        CustomAlert alert = null;
             
        public void Hide()
        {
            alert.Hide();
        }

        public void Show(string message)
        {
            alert = new CustomAlert();
            alert.Show(message, null, "loading", null);
        }
    }
}
