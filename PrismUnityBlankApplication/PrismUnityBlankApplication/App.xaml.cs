#region Using Statements

using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.Resources;
using Windows.UI.Xaml;
using Microsoft.Practices.Unity;
using Prism.Unity.Windows;
using Prism.Windows.AppModel;
using PrismUnityBlankApplication.Helpers;

#endregion

namespace PrismUnityBlankApplication
{
  /// <summary>
  ///   Provides application-specific behavior to supplement the default Application class.
  /// </summary>
  public sealed partial class App : PrismUnityApplication
  {
    /// <summary>
    ///   Initializes the singleton application object.  This is the first line of authored code
    ///   executed, and as such is the logical equivalent of main() or WinMain().
    /// </summary>
    public App()
    {
      this.InitializeComponent();
    }

    protected override Task OnInitializeAsync(IActivatedEventArgs args)
    {
      this.Container.RegisterInstance<IResourceLoader>(new ResourceLoaderAdapter(new ResourceLoader()));

      return base.OnInitializeAsync(args);
    }

    protected override Task OnLaunchApplicationAsync(LaunchActivatedEventArgs args)
    {
      this.NavigationService.Navigate(PageTokens.MAIN_PAGE,
                                      null);
      Window.Current.Activate();
      return Task.FromResult(true);
    }
  }
}