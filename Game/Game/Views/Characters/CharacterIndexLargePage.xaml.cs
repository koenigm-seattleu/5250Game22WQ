using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Game.ViewModels;

namespace Game.Views
{
    /// <summary>
    /// Index Page
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0019:Use pattern matching", Justification = "<Pending>")]
    [DesignTimeVisible(false)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CharacterIndexLargePage: ContentPage
    {
        // The view model, used for data binding
        readonly CharacterIndexViewModel ViewModel = CharacterIndexViewModel.Instance;

        /// <summary>
        /// Constructor for Index Page
        /// 
        /// Get the CharacterIndexView Model
        /// </summary>
        public CharacterIndexLargePage()
        {
            InitializeComponent();

            BindingContext = ViewModel;
        }

        public async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
        }
    }
}


/*
 
                            <Grid ColumnSpacing="5" RowSpacing="1">
                                <Grid.ColumnDefinitions>
                                    <ColumnDefinition Width="auto"/>
                                    <ColumnDefinition Width="*"/>
                                    <ColumnDefinition Width="auto"/>
                                </Grid.ColumnDefinitions>
                                <Grid.RowDefinitions>
                                    <RowDefinition Height="auto"/>
                                    <RowDefinition Height="auto"/>
                                    <RowDefinition Height="auto"/>
                                    <RowDefinition Height="auto"/>
                                </Grid.RowDefinitions>

                                <Label Grid.Column="0" Grid.Row="0" />
                                <Label Grid.Column="2" Grid.Row="0" />

                                <Image  Grid.Column="1" Grid.Row="0"
                                        Source="{Binding ImageURI}"
                                        Style="{StaticResource ImageBattleLargeStyle}"
                                        VerticalOptions="CenterAndExpand"/>

                                <Label Grid.Column="1" Grid.Row="1"
                                       Text="{Binding Name}" 
                                       Style="{StaticResource ListStyle}"/>

                                <StackLayout Grid.Column="1" Grid.Row="2"
                                    Orientation="Horizontal">
                                    
                                    <Label 
                                       Text="{Binding Path=Level, StringFormat='Level {0:G}'}" 
                                       Style="{StaticResource ListStyle}"/>

                                    <Label Text="{Binding Path=MaxHealth, StringFormat= '{0:G} hp'}" 
                                        Style="{StaticResource ListStyle}"/>
                                
                                </StackLayout>

                                <Label Grid.Column="1" Grid.Row="3"
                                       Text="{Binding Description}" 
                                       Style="{StaticResource ListStyle}"
                                       FontSize="Micro"/>

                            </Grid>

 */ 