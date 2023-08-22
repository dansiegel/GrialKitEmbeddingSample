namespace GrialControlsTestBed.Views;

public partial class BarChartPage : ContentPage
{
	public BarChartPage()
	{
		InitializeComponent();

        BindingContext = SampleData.Bar();
    }
}
