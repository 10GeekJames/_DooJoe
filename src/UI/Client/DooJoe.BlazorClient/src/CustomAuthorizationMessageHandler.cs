namespace DooJoe.BlazorClient;
public class CustomAuthorizationMessageHandler : AuthorizationMessageHandler
{
    public CustomAuthorizationMessageHandler(IAccessTokenProvider provider,
        NavigationManager navigationManager)
        : base(provider, navigationManager)
    {
        ConfigureHandler(
            authorizedUrls: new[] {
                "http://localhost:44310",
                "http://localhost:5020/api",
                "http://localhost:5270/api",
                "http://localhost:5272/api",
                "http://localhost:5274/api",
                "http://localhost:5276/api",
                "http://localhost:5240/api",
                "http://localhost:5280/api",
                "http://localhost:5282/api",
                "http://localhost:5284/api",
                "http://localhost:5286/api",
                "http://localhost:5288/api",
                "http://localhost:5250/api",

                "http://dooJoe.com:44310",
                "http://dooJoe.com:5020/api",
                "http://dooJoe.com:5270/api",
                "http://dooJoe.com:5272/api",
                "http://dooJoe.com:5274/api",
                "http://dooJoe.com:5276/api",
                "http://dooJoe.com:5240/api",
                "http://dooJoe.com:5280/api",
                "http://dooJoe.com:5282/api",
                "http://dooJoe.com:5284/api",
                "http://dooJoe.com:5286/api",
                "http://dooJoe.com:5288/api",
                "http://dooJoe.com:5250/api",
                

                 },
            scopes: new[] { "openid", "email", "profile", "roles" });

    }
}
