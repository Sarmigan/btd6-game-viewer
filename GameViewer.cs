using MelonLoader;
using BTD_Mod_Helper;
using GameViewer;

[assembly: MelonInfo(typeof(GameViewer.GameViewer), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace GameViewer;

public class GameViewer : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<GameViewer>("GameViewer loaded!");
    }
}