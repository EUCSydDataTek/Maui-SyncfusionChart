using MauiAppSyncfusionChart.ViewModels;

namespace MauiAppSyncfusionChart;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}

