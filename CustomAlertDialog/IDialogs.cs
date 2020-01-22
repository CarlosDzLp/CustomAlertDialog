using System;
namespace CustomAlertDialog
{
    public interface IDialogs
    {
        void Show(string message);
        void Hide();
    }
}
