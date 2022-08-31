using Microsoft.AspNetCore.Components;
using SalesRepTracking.UI.Models;

namespace SalesRepTracking.UI.Pages;

public partial class AddRep
{
    public PersonalInfo PersonalInfo { get; set; } = new();
    
    [Inject]
    public NavigationManager NavManager { get; set; }
    public void SubmitData()
    {
        // Do things
        NavManager.NavigateTo("/success");
    }
}