using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "Script_obj_installer", menuName = "Installers/Script_obj_installer")]
public class Script_obj_installer : ScriptableObjectInstaller<Script_obj_installer>
{
    public string text;
    public int num;

    public override void InstallBindings()
    {
        Container
            .Bind<string>()
            .WithId("ID-PREFAB-TEXT")
            .FromInstance(text)
            .AsTransient();


        Container
            .Bind<int>()
            .WithId("ID-PREFAB-NUM")
            .FromInstance(num)
            .AsTransient();
    }
}