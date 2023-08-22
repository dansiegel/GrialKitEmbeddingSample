namespace GrialControlsTestBed.Views;

public partial class PieChartPage : ContentPage
{
	public PieChartPage()
	{
		InitializeComponent();

        BindingContext = SampleData.Ring();
    }
}
