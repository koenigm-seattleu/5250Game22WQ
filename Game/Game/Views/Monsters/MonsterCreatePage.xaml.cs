using System;
using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Game.Models;
using Game.ViewModels;

namespace Game.Views
{
    /// <summary>
    /// Create Monster
    /// </summary>
    [DesignTimeVisible(false)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MonsterCreatePage : ContentPage
    {
        // The Monster to create
        public GenericViewModel<MonsterModel> ViewModel { get; set; }

        // Hold the current location selected
        public ItemLocationEnum PopupLocationEnum = ItemLocationEnum.Unknown;

        /// <summary>
        /// Constructor for Unit Tests
        /// </summary>
        /// <param name="UnitTest"></param>
        public MonsterCreatePage(bool UnitTest) { }

        /// <summary>
        /// Constructor for Create makes a new model
        /// </summary>
        public MonsterCreatePage(GenericViewModel<MonsterModel> data)
        {
            InitializeComponent();

            data.Data = new MonsterModel();
            this.ViewModel = data;

            this.ViewModel.Title = "Create";

            _ = UpdatePageBindingContext();
        }

        /// <summary>
        /// Redo the Binding to cause a refresh
        /// </summary>
        /// <returns></returns>
        public bool UpdatePageBindingContext()
        {
            // Temp store off the difficulty
            var difficulty = this.ViewModel.Data.Difficulty;

            // Clear the Binding and reset it
            BindingContext = null;
            BindingContext = this.ViewModel;

            ViewModel.Data.Difficulty = difficulty;

            return true;
        }

        /// <summary>
        /// Save by calling for Create
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public async void Save_Clicked(object sender, EventArgs e)
        {
            // If the image in the data box is empty, use the default one..
            if (string.IsNullOrEmpty(ViewModel.Data.ImageURI))
            {
                ViewModel.Data.ImageURI = new MonsterModel().ImageURI;
            }

            MessagingCenter.Send(this, "Create", ViewModel.Data);
            _ = await Navigation.PopModalAsync();
        }

        /// <summary>
        /// Cancel the Create
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public async void Cancel_Clicked(object sender, EventArgs e)
        {
            _ = await Navigation.PopModalAsync();
        }

        ///// <summary>
        ///// 
        ///// Randomize the Monster
        ///// Keep the Level the Same
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //public bool RandomizeMonster()
        //{
        //    // Randomize Name
        //    ViewModel.Data.Name = RandomPlayerHelper.GetMonsterName();
        //    ViewModel.Data.Description = RandomPlayerHelper.GetMonsterDescription();

        //    // Randomize the Attributes
        //    ViewModel.Data.Attack = RandomPlayerHelper.GetAbilityValue();
        //    ViewModel.Data.Speed = RandomPlayerHelper.GetAbilityValue();
        //    ViewModel.Data.Defense = RandomPlayerHelper.GetAbilityValue();

        //    ViewModel.Data.Difficulty = RandomPlayerHelper.GetMonsterDifficultyValue();

        //    ViewModel.Data.ImageURI = RandomPlayerHelper.GetMonsterImage();

        //    ViewModel.Data.UniqueItem = RandomPlayerHelper.GetMonsterUniqueItem();

        //    _ = UpdatePageBindingContext();

        //    return true;
        //}
    }
}