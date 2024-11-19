using FFImageLoading.Maui;
using InfinitRunnerSarah;

public delegate void Callback();

public class Player : Animacao
{
    public Player(CachedImageView a) : base(a)
    {
        for (int i = 1; i <= 06; ++i)
            Animacao1.Add($"andando{i.ToString("D2")}.png");
        for (int i = 1; i <= 06; ++i)
            Animacao2.Add($"morrendo{i.ToString("D2")}.png");
        SetAnimacaoAtiva(1);
    }
    public void Die()
    {
        loop = false;
        SetAnimacaoAtiva(2);
    }
    public void Run()
    {
        loop = true;
        SetAnimacaoAtiva(1);
        Play();
    }
    public void MoveY(int S)
    {
        ImageView.TranslationY += S;
    }
    public double GetY()
    {
        return ImageView.TranslationY;
    }
    public void SetY(double a)
    {
        ImageView.TranslationY = a;
    }
}
