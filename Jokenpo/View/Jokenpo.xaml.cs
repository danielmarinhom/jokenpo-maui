using Microsoft.Maui.Controls;
using Jokenpo.ViewModel;
namespace Jokenpo.View;

public partial class Jokenpo : ContentPage
{
	public Jokenpo()
	{
        InitializeComponent();
        BindingContext = new JokenpoViewModel();
    }
}