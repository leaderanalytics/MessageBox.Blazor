![Leader Analytics](./logo.png)

# MessageBox.Blazor

An easy, simple dialog box for Blazor.


# Getting Started

## Install MudBlazor
Skip this step if you have already installed MudBlazor in your project.  Otherwise, follow [this documentation](https://www.mudblazor.com/getting-started/installation#prerequisites) to install MudBlazor.

## Install MessageBox.Blazor
Install the [nuget package](https://www.nuget.org/packages/LeaderAnalytics.MessageBox.Blazor):

    dotnet add package LeaderAnalytics.MessageBox.Blazor

Add LeaderAnalytics.MessageBox.Blazor to _Imports.razor:

    @using LeaderAnalytics.MessageBox.Blazor

Add `MessageBoxProvider` to `MainLayout.razor`:

    <MessageBoxProvider />


Add Service registration:

    using LeaderAnalytics.MessageBox.Blazor;

    builder.Services.AddMessageBoxBlazor();



This project takes a dependency on [MudBlazor](https://www.mudblazor.com/).  Beyond that, it is not affiliated with, endorsed or supported by MudBlazor.
