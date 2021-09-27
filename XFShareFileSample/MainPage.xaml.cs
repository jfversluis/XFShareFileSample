using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace XFShareFileSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Subject = "Gerald's YouTube",
                Text = "Please subscribe",
                Title = "Gerald's YouTube",
                Uri = "https://youtube.com/GeraldVersluis"
            });
        }

        async void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            var image = await MediaPicker.PickPhotoAsync();

            if (image == null)
            {
                return;
            }

            await Share.RequestAsync(new ShareFileRequest
            {
                Title = "Gerald's YouTube",
                File = new ShareFile(image)
            });
        }
    }
}
