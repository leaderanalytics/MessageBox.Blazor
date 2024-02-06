namespace LeaderAnalytics.MessageBox.Blazor;

public enum MessageType
{
    Info,
    Warning,
    Error,
    Loading,
    LoadingComplete,
    Ask,
    Confirm
}

public class MessageVisuals
{
    public string Message { get; private set; }
    public string Button1Text { get; private set; }
    public string Button2Text { get; private set; }

    public MessageVisuals(string message, string button1Text, string button2Text) : this(message, button1Text) => Button2Text = button2Text;

    public MessageVisuals(string message, string button1Text) : this(message) => Button1Text = button1Text;

    public MessageVisuals(string message) => Message = message;

    public MessageVisuals() { }
}

public class MessageBox : IMessageBox
{
    protected static int LoadingDialogCount;
    public event Func<MessageVisuals, MessageType, Task<bool>> Notify;

    public void AddHandler(Func<MessageVisuals, MessageType, Task<bool>> handler)
    {
        if (Notify == null)
            Notify += handler;
    }

    public virtual async Task<bool> ShowLoading(string message = "Working...")
    {
        if (LoadingDialogCount == 0)
            await Notify?.Invoke(new MessageVisuals(message), MessageType.Loading);

        LoadingDialogCount++;
        return true;
    }

    public virtual async Task<bool> HideLoading()
    {
        if (LoadingDialogCount == 1)
            await Notify?.Invoke(new MessageVisuals(), MessageType.LoadingComplete);

        LoadingDialogCount--;
        return true;
    }

    public virtual async Task<bool> Ask(string message, string button1Text = "Yes", string button2Text = "No") => await Notify?.Invoke(new MessageVisuals(message, button1Text, button2Text), MessageType.Ask);
    public virtual async Task<bool> Confirm(string message, string button1Text = "Ok", string button2Text = "Cancel") => await Notify?.Invoke(new MessageVisuals(message, button1Text, button2Text), MessageType.Confirm);
    public virtual async Task<bool> Info(string message, string button1Text = "Ok", string button2Text = null) => await Notify?.Invoke(new MessageVisuals(message, button1Text, button2Text), MessageType.Info);
    public virtual async Task<bool> Error(string message, string button1Text = "Ok", string button2Text = null) => await Notify?.Invoke(new MessageVisuals(message, button1Text, button2Text), MessageType.Error);
    public virtual async Task<bool> Warn(string message, string button1Text = "Ok", string button2Text = null) => await Notify?.Invoke(new MessageVisuals(message, button1Text, button2Text), MessageType.Warning);
    public virtual async Task<bool> ShowMessage(string message, string button1Text, string button2Text, MessageType messageType) => await Notify?.Invoke(new MessageVisuals(message, button1Text, button2Text), messageType);
}
