using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace LeaderAnalytics.MessageBox.Blazor.Demo.Components;

public abstract class BasePage : ComponentBase
{
    [Inject] protected IMessageBox MessageBox { get; set; }
    [Inject] protected ISnackbar Snackbar { get; set; }
}
