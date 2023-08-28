namespace GrialControlsTestBed.Views;

public partial class LineChartSample : ContentPage
{
	public LineChartSample()
	{
		InitializeComponent();

		chart.BindingContext = SampleData.Line();
	}
}
