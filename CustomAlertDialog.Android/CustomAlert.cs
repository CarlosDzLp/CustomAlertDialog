using System;
using Android.Support.V7.App;
using Android.Widget;
using Com.Airbnb.Lottie;
using Plugin.CurrentActivity;

namespace CustomAlertDialog.Droid
{
    public class CustomAlert
    {
        AlertDialog Adialog = null;
        public void Show(string message=null,string colorMesage=null,string image=null,string backgroundColor=null)
        {
            AlertDialog.Builder dialog = new AlertDialog.Builder(CrossCurrentActivity.Current.Activity);
            var inflater = Android.App.Application.Context.GetSystemService(Android.Content.Context.LayoutInflaterService) as Android.Views.LayoutInflater;
            Android.Views.View view = inflater.Inflate(Resource.Layout.CustomDialog, null);
            var colorBackground = (!string.IsNullOrWhiteSpace(backgroundColor)) ? Android.Graphics.Color.ParseColor(backgroundColor) : Android.Graphics.Color.White;
            view.SetBackgroundColor(colorBackground);
            var textMessage = view.FindViewById<TextView>(Resource.Id.text_dialog);
            if(textMessage != null)
            {
                var colorText = (!string.IsNullOrWhiteSpace(colorMesage)) ? Android.Graphics.Color.ParseColor(colorMesage) : Android.Graphics.Color.Black;
                textMessage.Text = (!string.IsNullOrWhiteSpace(message)) ? message : string.Empty;
                textMessage.SetTextColor(colorText);
            }
            var imageView = view.FindViewById<LottieAnimationView>(Resource.Id.animation_view);
            if(imageView != null)
            {
                int restId = CrossCurrentActivity.Current.Activity.Resources.GetIdentifier(image, "drawable", CrossCurrentActivity.Current.Activity.PackageName);
                imageView.SetAnimation(restId);
            }
            dialog.SetView(view);
            dialog.SetCancelable(false);
            Adialog = dialog.Create();
            Adialog.Show();
        }
        public void Hide()
        {
            Adialog.Dismiss();
        }
    }
}
