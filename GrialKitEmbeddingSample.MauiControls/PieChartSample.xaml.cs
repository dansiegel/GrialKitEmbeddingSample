﻿namespace GrialControlsTestBed.Views;

public partial class PieChartSample : ContentPage
{
	public PieChartSample()
	{
		InitializeComponent();

        chart.BindingContext = SampleData.Ring();
    }
}
