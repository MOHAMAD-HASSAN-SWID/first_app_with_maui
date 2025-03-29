//using Google.Android.Material.Slider;
using Microsoft.Maui.Controls;
namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void on_sweitch_toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                mode_lable.Text = "Dark Mode";

            }
            else
            {
                mode_lable.Text = "Lighte Mode";
            }
                
        }

        private void onButton_print(object sender, EventArgs e)
        {
            Label_print.Text = $" The Name Is {Entry_name.Text}\n" +
                $"The Favourt Color Is {picker_color.SelectedItem}\n" +
                $"The Number Your Choise Is {(int)Slider_number.Value}\n" +
                $"The Mode Color Is {mode_lable.Text}";
        }

        private void OnButton_open_new_page(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewPage1());
        }
    }

}
