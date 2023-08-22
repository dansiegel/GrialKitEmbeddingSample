namespace GrialControlsTestBed.Views;

public partial class BarMultiSeriesPage : ContentPage
{
	public BarMultiSeriesPage()
	{
		InitializeComponent();

		BindingContext = SampleData.MultiSeriesBar();

    }
}
