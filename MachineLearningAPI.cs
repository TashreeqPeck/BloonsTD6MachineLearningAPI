using MelonLoader;
using BTD_Mod_Helper;
using MachineLearningAPI;

[assembly: MelonInfo(typeof(MachineLearningAPI.MachineLearningAPI), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace MachineLearningAPI;

public class MachineLearningAPI : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<MachineLearningAPI>("MachineLearningAPI loaded!");
    }
}