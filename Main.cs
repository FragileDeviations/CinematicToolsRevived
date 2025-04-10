namespace CinematicToolsRevived;

public class Main : MelonMod
{
    internal const string Name = "CinematicToolsRevived";
    internal const string Description = "Spawn a camera, clone your avatar";
    internal const string Author = "Mabel Amber, originally Krisp";
    internal const string Company = "FragileDeviations";
    internal const string Version = "1.0.2";
    internal const string DownloadLink = "https://thunderstore.io/c/bonelab/p/SoulWithMae/CinematicToolsRevived/";

    public override void OnInitializeMelon()
    {
        BoneMenu.Setup();
        TheHandler.SetupHooks();
    }
}