using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp1;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty] private string _entryText;
}