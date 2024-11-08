using InfinitRunnerSarah;

public delegate void Callback();

public class Player : Animacao
{
    for (int i = 1; i <= 06; ++i)
    Animacao1.Add($"andando"{i.ToString("D2")}.png");
    for (int i = 1; i <= 06; ++i)
    Animacao2.Add($"morrendo"{ i.ToString("D2")}.png");
    SetAnimacaoAtiva(1);
}

public void Die()
{
    Lookup = false;
    SetAnimacaoAtiva(2);
}
public void Run()
{
    Lookup = true;
    SetAnimacaoAtiva(1);
    Play();
}
