#region Using Statements

using System.ComponentModel;
using Windows.UI.Xaml;
using Prism.Windows.Mvvm;
using PrismUnityBlankApplication.ViewModels;

#endregion

namespace PrismUnityBlankApplication.Views
{
  /// <summary>
  ///   An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class MainPage : SessionStateAwarePage,
                                         INotifyPropertyChanged
  {
    public MainPage()
    {
      this.InitializeComponent();
      this.DataContextChanged += this.MainPageDataContextChanged;
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public MainPageViewModel ConcreteDataContext
    {
      get { return this.DataContext as MainPageViewModel; }
    }

    private void MainPageDataContextChanged(FrameworkElement sender,
                                            DataContextChangedEventArgs args)
    {
      var propertyChanged = this.PropertyChanged;
      if (propertyChanged != null)
      {
        propertyChanged(this,
                        new PropertyChangedEventArgs(nameof(this.ConcreteDataContext)));
      }
    }
  }
}