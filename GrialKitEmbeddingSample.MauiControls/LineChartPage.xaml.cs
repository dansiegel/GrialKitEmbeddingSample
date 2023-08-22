namespace GrialControlsTestBed.Views;

public partial class LineChartPage : ContentPage
{
	public LineChartPage()
	{
		InitializeComponent();

		BindingContext = SampleData.Line();
	}
}
