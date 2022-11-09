using Applied_Activity_2.Services;

namespace Applied_Activity_2;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        DependencyService.Register<WebClientService>();
        DependencyService.Register<HolidayDataStoreAPI>();
        MainPage = new AppShell();
	}
}

