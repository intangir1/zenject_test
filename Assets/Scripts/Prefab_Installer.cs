using UnityEngine;
using Zenject;

public class Prefab_Installer : MonoInstaller
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