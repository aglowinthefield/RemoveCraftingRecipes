using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Records;
using Mutagen.Bethesda.WPF.Reflection.Attributes;

namespace RemoveCraftingRecipes;

public class RemoveCraftingRecipesSettings
{
    [SettingName("Mods to trim")]
    [Tooltip("These mods will have their crafting recipes removed")]
    public HashSet<ModKey> ModsToTrim = new() { };

    [SettingName("Remove tempering")]
    [Tooltip("Also remove the tempering recipes if they exist")]
    public bool RemoveTempering = false;
}