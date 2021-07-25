using UnityEngine;
using Zenject;

public class Info_Installer : Installer<string, int, Info_Installer>
{
    [Inject]
    private string text;

    [Inject]
    private int num;

    public override void InstallBindings()
    {
        Container
            .Bind<IInfo>()
            .To<Info>()
            .AsSingle()
            .When(c => c.ObjectType == typeof(Some_object));


        Container
            .Bind<string>()
            .WithId("ID-TEST-TEXT")
            .FromInstance(text)
            .AsTransient();

        Container
            .Bind<int>()
            .WithId("ID-TEST-NUM")
            .FromInstance(num)
            .AsTransient();
    }
}