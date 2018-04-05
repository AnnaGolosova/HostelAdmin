namespace HostelAdmin.Services
{
    public enum LoginState
    {
        Success = 0,
        WrongEmail,
        WrongPassword,
        ConnectionError
    }
}