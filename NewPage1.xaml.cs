namespace MauiApp1;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();

        // Update Slider label dynamically
    }
    // Handle notification submission
    private async void OnSendClicked(object sender, EventArgs e)
    {
        string message = MessageEntry.Text;
        string recipient = RecipientPicker.SelectedItem?.ToString();

        if (string.IsNullOrWhiteSpace(message) || recipient == null)
        {
            await DisplayAlert("Error", "Please complete all fields.", "OK");
            return;
        }

        await DisplayAlert("Notification Sent",
            $"Message: {message}\nRecipient: {recipient}",
            "OK");
    }

    // Handle dynamic content update
    private void OnUpdateContentClicked(object sender, EventArgs e)
    {
        DynamicLabel.Text = $"Updated at {DateTime.Now:T}";
    }
}
