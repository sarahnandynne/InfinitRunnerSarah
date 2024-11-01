namespace InfinitRunnerSarah;

public partial class MainPage : ContentPage
{
	bool EstaMorto = false;
	bool EstaPulando = false;
	const int TempoEntreFrames = 25;
	int velocidade1 = 0;
	int velocidade2 = 0;
	int velocidade3 = 0;
	int velocidade = 0;
	int LarguraJanela = 0;
	int AlturaJanela = 0;

	public MainPage()
	{
		InitializeComponent();
	}
    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);
		CorrigeTamanhoCenario(width, height);
		CalculaVelocidade(width);
    }
	void CalculaVelocidade(double width)
	{
		velocidade1 = (int)(width * 0.001);
		velocidade2 = (int)(width * 0.004);
		velocidade3 = (int)(width * 0.008);
		velocidade = (int)(width * 0.01);
	}
	void CorrigeTamanhoCenario(double width, double height)
	{
		foreach (var ceu in HsLayer1.Children)
		(ceu as Image).WidthRequest = width;
		foreach (var predio in HsLayer2.Children)
		(predio as Image).WidthRequest = width;
		foreach (var mato in HsLayer3.Children)
		(mato as Image).WidthRequest = width;
		foreach (var chao in HsLayer4Chao.Children)
		(chao as Image).WidthRequest = width;

		HsLayer1.WidthRequest = width;
		HsLayer2.WidthRequest = width;
		HsLayer3.WidthRequest = width;
		HsLayer4Chao.WidthRequest = width;
	}
}

