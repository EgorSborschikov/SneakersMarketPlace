namespace SneakersMarketPlace.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
#pragma warning disable CA1822 // Mark members as static
    public string AutorizHeader => "АВТОРИЗАЦИЯ В СИСТЕМЕ";
    public string AutorizSubHeader => "Чтобы совершать заказы, необхолимо войти в систему";
    public string LoginPlaceholder => "Логин:";
    public string PasswordPlaceholder => "Пароль:";
    public string RememberMe => "Запомнить меня";
    public string ForgotPassword => "Забыли пароль?";
    public string SignIn => "Войти";
#pragma warning restore CA1822 // Mark members as static
}