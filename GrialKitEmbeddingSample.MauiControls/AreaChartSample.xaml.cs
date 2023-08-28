namespace GrialControlsTestBed.Views;

public partial class AreaChartSample : ContentPage
{
	public AreaChartSample()
	{
		InitializeComponent();

		chart.BindingContext = SampleData.MultiseriesWithLabels();
    }
}
