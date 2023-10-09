using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp1;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty] private List<IntegerQuestionItem> _integerItems;


    public MainPageViewModel()
    {
        GenerateIntegers();
    }


    private void GenerateIntegers()
    {
        var tempList = new List<IntegerQuestionItem>();
        var max = 999;

        for (var i = 0; i <= max; i++)
        {
            tempList.Add(new IntegerQuestionItem(i));
        }

        IntegerItems = tempList;
    }
}

public sealed class IntegerQuestionItem(int value)
{
    public int Value { get; set; } = value;
}