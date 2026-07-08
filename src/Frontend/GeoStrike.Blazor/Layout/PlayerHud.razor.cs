#region

using Microsoft.AspNetCore.Components;

#endregion

namespace GeoStrike.Blazor.Layout;

public partial class PlayerHud : ComponentBase
{
    protected int creditos = 45000;
    protected int energia = 80;
    protected int maxEnergia = 100;

    protected int petroleo = 15400;

    [Inject] protected HttpClient Http { get; set; } = default!;

    protected override async Task OnInitializedAsync() { await Task.CompletedTask; }
}