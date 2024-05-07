using StardewModdingAPI;
using StardewModdingAPI.Utilities;

namespace GrowThatGiantCrop;

public sealed class ModConfig
{
    public Keybind GrowCropButton { get; set; } = new Keybind(SButton.OemTilde);
    public bool EnableMod { get; set; } = true;
}