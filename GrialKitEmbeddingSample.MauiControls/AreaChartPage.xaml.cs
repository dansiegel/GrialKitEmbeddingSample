namespace GrialControlsTestBed.Views;

public partial class AreaChartPage : ContentPage
{
	public AreaChartPage()
	{
		InitializeComponent();

		BindingContext = SampleData.MultiseriesWithLabels();
    }
}
