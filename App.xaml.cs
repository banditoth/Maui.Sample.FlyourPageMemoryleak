﻿namespace FlyoutLeak;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MemoryFlyPage();
	}
}

