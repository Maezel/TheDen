using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.Mapping;

[GenerateTypedNameReferences]
public sealed partial class MappingLayerButton : Button
{
    public MappingLayerButton()
    {
        RobustXamlLoader.Load(this);
    }
}

