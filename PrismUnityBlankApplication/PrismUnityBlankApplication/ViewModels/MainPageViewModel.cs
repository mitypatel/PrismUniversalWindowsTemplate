#region Using Statements

using Prism.Windows.Mvvm;
using Prism.Windows.Navigation;

#endregion

namespace PrismUnityBlankApplication.ViewModels
{
  public class MainPageViewModel : ViewModelBase
  {
    private readonly INavigationService _navigationService;

    public MainPageViewModel(INavigationService navigationService)
    {
      this._navigationService = navigationService;
    }
  }
}