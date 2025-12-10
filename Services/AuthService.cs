using Supabase.Gotrue;

public class AuthService
{
    public bool IsLoggedIn { get; private set; } = false;

    public void SetUser(Session? session)
    {
        IsLoggedIn = session?.User != null;
    }
}
