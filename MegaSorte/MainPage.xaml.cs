namespace MegaSorte;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnGenerateLuckNumber(object sender, EventArgs e)
	{
		NameApp.IsVisible = false;
		ContainerNumbers.IsVisible = true;

		var set = GenerateNumbers();

		Number01.Text = set.ElementAt(0).ToString("D2");
        Number02.Text = set.ElementAt(1).ToString("D2");
        Number03.Text = set.ElementAt(2).ToString("D2");
        Number04.Text = set.ElementAt(3).ToString("D2");
        Number05.Text = set.ElementAt(4).ToString("D2");
        Number06.Text = set.ElementAt(5).ToString("D2");
    }

	private SortedSet<int> GenerateNumbers()
	{
        var random = new Random();
        var set = new SortedSet<int>();

		while(set.Count < 6) { 
			var number = random.Next(1, 60);
			set.Add(number); 
		}

		return set;
	}
}