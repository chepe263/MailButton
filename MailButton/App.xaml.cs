using MailButton.Repositories;

namespace MailButton;

public partial class App : Application
{
	// public static MessageRepository Messages { get; private set; }

	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
        // MessageRepository messagerepo

        //Messages = messagerepo;
	}
}
