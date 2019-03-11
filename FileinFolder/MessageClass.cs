using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileinFolder
{

    public enum MessageType
    {
        Message,
        RunTime,
        FolderPath,
        FilePath,
        Error,
    }

    public class MessageEventArgs : EventArgs
    {
        public MessageType messageType;
        public String Message; //传递字符串信息
        public MessageEventArgs(string message, MessageType type = MessageType.Message)
        {
            this.Message = message;
            this.messageType = type;
        }

    }

    public delegate void MessageEventHandler(MessageEventArgs e);

    public class MessageClass
    {
        public event MessageEventHandler OnMessageSend = null;

        public void MessageSend(MessageEventArgs e)
        {
            OnMessageSend?.Invoke(e);
        }
    }
}
