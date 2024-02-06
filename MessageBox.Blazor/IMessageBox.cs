
namespace LeaderAnalytics.MessageBox.Blazor;

public interface IMessageBox
{
    event Func<MessageVisuals, MessageType, Task<bool>> Notify;

    void AddHandler(Func<MessageVisuals, MessageType, Task<bool>> handler);
    Task<bool> Ask(string message, string button1Text = "Yes", string button2Text = "No");
    Task<bool> Confirm(string message, string button1Text = "Ok", string button2Text = "Cancel");
    Task<bool> Error(string message, string button1Text = "Ok", string button2Text = null);
    Task<bool> HideLoading();
    Task<bool> Info(string message, string button1Text = "Ok", string button2Text = null);
    Task<bool> ShowLoading(string message = "Working...");
    Task<bool> ShowMessage(string message, string button1Text, string button2Text, MessageType messageType);
    Task<bool> Warn(string message, string button1Text = "Ok", string button2Text = null);
}