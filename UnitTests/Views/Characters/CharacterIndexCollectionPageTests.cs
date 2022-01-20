using NUnit.Framework;

using Game;
using Game.Views;
using Game.Models;

using Xamarin.Forms;
using Xamarin.Forms.Mocks;

namespace UnitTests.Views
{
    [TestFixture]
    public class CharacterIndexCollectionPageTests : CharacterIndexCollectionPage
    {
        App app;
        CharacterIndexCollectionPage page;

        public CharacterIndexCollectionPageTests() : base(true) { }

        [SetUp]
        public void Setup()
        {
            // Initilize Xamarin Forms
            MockForms.Init();

            //This is your App.xaml and App.xaml.cs, which can have resources, etc.
            app = new App();
            Application.Current = app;

            page = new CharacterIndexCollectionPage();
        }

        [TearDown]
        public void TearDown()
        {
            Application.Current = null;
        }

        [Test]
        public void CharacterIndexCollectionPage_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = page;

            // Reset

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void CharacterIndexCollectionPage_OnCollectionViewSelectionChanged_Clicked_Default_Should_Pass()
        {
            // Arrange

            var selectedCharacter = new CharacterModel();

            CollectionView CharactersListView = (CollectionView)page.FindByName("CharactersListView");
            
            // Act

            // Triggers the OnCollectionViewSelectionChanged
            CharactersListView.SelectedItem = selectedCharacter;

            // Reset

            // Assert
            Assert.IsTrue(true); // Got to here, so it happened...
        }
    }
}