using MailButton.Repositories;

namespace MailButton;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
        string dbPath = FileAccessHelper.GetLocalFilePath("databaset.db3");
		var repo = new MessageRepository(dbPath);
		Console.WriteLine(dbPath);

    }

    private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

