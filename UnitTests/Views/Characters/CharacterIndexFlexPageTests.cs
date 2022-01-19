using System.Linq;

using NUnit.Framework;

using Game;
using Game.Views;
using Game.Models;
using Game.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Mocks;

namespace UnitTests.Views
{
    [TestFixture]
    public class CharacterIndexFlexPageTests : CharacterIndexFlexPage
    {
        App app;
        CharacterIndexFlexPage page;

        public CharacterIndexFlexPageTests() : base(true) { }

        [SetUp]
        public void Setup()
        {
            // Initilize Xamarin Forms
            MockForms.Init();

            //This is your App.xaml and App.xaml.cs, which can have resources, etc.
            app = new App();
            Application.Current = app;

            page = new CharacterIndexFlexPage();
        }

        [TearDown]
        public void TearDown()
        {
            Application.Current = null;
        }

        [Test]
        public void CharacterIndexFlexPage_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = page;

            // Reset

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void CharacterIndexFlexPage_FlexCharacter_Clicked_Default_Should_Pass()
        {
            // Arrange
            var data = CharacterIndexViewModel.Instance.Dataset.First();

            ImageButton button = new ImageButton { CommandParameter = data.Id };

            // Act
            page.FlexCharacter_Clicked(button, null);

            // Reset

            // Assert
            Assert.IsTrue(true);    // Got to here, so it happened...
        }
    }
}