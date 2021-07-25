using UnityEngine;
using Zenject;

public class Signal_scene_installer : MonoInstaller<Signal_scene_installer>
{
    public override void InstallBindings()
    {
        SignalBusInstaller.Install(Container);

		Container
			.DeclareSignal<Signal_test>();

		Container
			.Bind<Greeter>()
			.AsSingle();

		Container
			.BindSignal<Signal_test>()
			.ToMethod<Greeter>(cls => cls.Greet)
			.FromResolve();



		Container
            .DeclareSignal<Signal_test_nums>();


        Container
            .BindInterfacesTo<Signal_listener>()
            .AsSingle();
        

    }
}