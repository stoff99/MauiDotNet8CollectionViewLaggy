namespace MauiApp1;

public partial class MainPage : ContentPage
{
    
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel();
    }

    private void Button_OnClicked(object sender, EventArgs e)
    {
        ((MainPageViewModel)BindingContext).EntryText = null;
    }
}