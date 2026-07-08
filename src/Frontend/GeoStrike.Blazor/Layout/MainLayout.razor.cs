#region

using Microsoft.AspNetCore.Components;
using MudBlazor;

#endregion

namespace GeoStrike.Blazor.Layout;

public partial class MainLayout : LayoutComponentBase
{
    protected readonly MudTheme _geoStrikeTheme = new()
    {
        PaletteDark = new PaletteDark
        {
            Primary = "#7055ff",
            Secondary = "#3d5afe",
            Background = "#0b0c10",
            Surface = "#171821",
            TextPrimary = "#ffffff",
            TextSecondary = "#8b8d99",
            Success = "#00e676",
            Warning = "#ffea00",
            DrawerBackground = "#11121a",
            AppbarBackground = "#171821"
        }
    };
}