using System.ComponentModel;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Game.ViewModels;
using Game.Models;

namespace Game.Views
{
    /// <summary>
    /// Index Page
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0019:Use pattern matching", Justification = "<Pending>")]
    [DesignTimeVisible(false)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CharacterIndexCollectionPage: ContentPage
    {
        // The view model, used for data binding
        readonly CharacterIndexViewModel ViewModel = CharacterIndexViewModel.Instance;

        public CharacterIndexCollectionPage(bool UnitTest) { }

        /// <summary>
        /// Constructor for Index Page
        /// 
        /// Get the CharacterIndexView Model
        /// </summary>
        public CharacterIndexCollectionPage()
        {
            InitializeComponent();

            BindingContext = ViewModel;
        }

        /// <summary>
        /// The Selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var current = (e.CurrentSelection.FirstOrDefault() as CharacterModel);

            await Navigation.PushAsync(new CharacterReadPage(new GenericViewModel<CharacterModel>(current)));

            return;
        }
    }
}