using CommunityToolkit.Mvvm.ComponentModel;

namespace UI.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    
    [ObservableProperty]
    public string title = "Workflows";
}