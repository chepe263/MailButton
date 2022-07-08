using MailButton.Repositories;

namespace MailButton;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
        //SQLitePCL.Batteries_V2.Init();
        var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		//string dbPath = FileAccessHelper.GetLocalFilePath("databaset.db3");
		//builder.Services.AddSingleton<MessageRepository>(s => ActivatorUtilities.CreateInstance<MessageRepository>(s, dbPath));
		return builder.Build();
	}
}
