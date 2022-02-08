using System;
using System.Linq;
using System.ComponentModel;

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
    public partial class CharacterIndexFlexPage: ContentPage
    {
        // The view model, used for data binding
        readonly CharacterIndexViewModel ViewModel = CharacterIndexViewModel.Instance;

        public CharacterIndexFlexPage(bool UnitTest) { }

        /// <summary>
        /// Constructor for Index Page
        /// 
        /// Get the CharacterIndexView Model
        /// </summary>
        public CharacterIndexFlexPage()
        {
            InitializeComponent();

            BindingContext = ViewModel;
        }

        public async void FlexCharacter_Clicked(object sender, EventArgs args)
        {
            var button = sender as ImageButton;
            var id = button.CommandParameter as string;
            var data = ViewModel.Dataset.FirstOrDefault(m => m.Id.Equals(id));

            await Navigation.PushAsync(new CharacterReadPage(new GenericViewModel<CharacterModel>(data)));

        }
    }
}