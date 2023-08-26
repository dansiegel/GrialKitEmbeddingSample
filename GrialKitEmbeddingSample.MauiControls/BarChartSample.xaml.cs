namespace GrialControlsTestBed.Views;

public partial class BarChartSample : ContentPage
{
	public BarChartSample()
	{
		InitializeComponent();

        chart.BindingContext = SampleData.Bar();
    }
}
