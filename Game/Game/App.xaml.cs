using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Game.Views;

/*
    Listing the Fonts out
    Custom Fonts are ttf files placed in the Resources Fonts Folder of the Shared Code
    Make sure each font is set with properties to be an embeded resource, and always copy as the build action
    Also list each font below, if multiple fonts, ensure unique alias
    Set the FontFamily property to the Alias in the xaml
 */
[assembly: ExportFont("blackcastlemf_bg5n.ttf", Alias = "CustomFont")]

namespace Game
{
    /// <summary>
    /// Main Application entry point
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class App : Application
    {
        /// <summary>
        /// Default App Constructor
        /// </summary>
        [System.Obsolete]
        public App()
        {
            InitializeComponent();

            // Add each model here to warm up and load it.
            _ = Helpers.DataSetsHelper.WarmUp();

            // Call the Main Page to open
            MainPage = new MainPage();
        }

        /// <summary>
        /// On Startup code if needed
        /// </summary>
        protected override void OnStart()
        {
        }

        /// <summary>
        /// On Sleep code if needed
        /// </summary>
        protected override void OnSleep()
        {
        }

        /// <summary>
        /// On App Resume code if needed
        /// </summary>
        protected override void OnResume()
        {
        }
    }
}