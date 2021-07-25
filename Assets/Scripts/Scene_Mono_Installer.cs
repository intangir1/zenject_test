using UnityEngine;
using Zenject;

public class Scene_Mono_Installer : MonoInstaller
{
    [SerializeField]
    private string text;

    [SerializeField]
    private int num;

    public override void InstallBindings()
    {
        Info_Installer.Install(Container, text, num);
    }
}