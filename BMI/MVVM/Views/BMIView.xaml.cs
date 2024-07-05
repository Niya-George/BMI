namespace BMI.MVVM.Views;
using BMI.MVVM.ViewModels;
public partial class BMIView : ContentPage
{
	public BMIView()
	{
		InitializeComponent();
		BindingContext = new BMIViewModel();
	}
}