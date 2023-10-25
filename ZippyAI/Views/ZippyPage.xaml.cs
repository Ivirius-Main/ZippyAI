using Microsoft.UI.Xaml.Controls;

using ZippyAI.ViewModels;

namespace ZippyAI.Views;

public sealed partial class ZippyPage : Page
{
    public ZippyViewModel ViewModel
    {
        get;
    }

    public ZippyPage()
    {
        ViewModel = App.GetService<ZippyViewModel>();
        InitializeComponent();
    }
}
