using MudBlazor;
namespace DooJoe.BlazorClient;
public static class MudStaticDefaultTheme
{
    public static MudTheme Default = new MudTheme()
    {
        Palette = new MudBlazor.PaletteLight()
        {
           /*  Primary = "#4A86FF",
            Secondary = "#FF4081",
            Tertiary = "#1EC8A5",
            Surface="#FEFEFE",
            Background="#FEFEFE",
            AppbarBackground = "#FEFEFE",
            DrawerBackground="#FEFEFE",
            LinesInputs="#ffffff25", */
        },
        PaletteDark = new MudBlazor.PaletteDark()
        {
            Primary="#1EC8A5",
            Surface="#282746",
            AppbarBackground="#212033",
            DrawerBackground="#212033",
            Background="#212033",
            Tertiary = "#776be7ff"
            /*
            Secondary = "#FF4081",
            ,
            Background="#212033",
            AppbarBackground = "#a3a1d4",
            DrawerBackground="#ffffff",
            LinesInputs="#1EC8A5" */
        },
        LayoutProperties = new MudBlazor.LayoutProperties()
        {
            DrawerWidthLeft = "200px",
            DrawerWidthRight = "300px"
        }
    };
}