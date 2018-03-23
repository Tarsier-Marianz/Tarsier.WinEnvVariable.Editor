using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarsier.UI {
    public class ParseMessageEventArgs : System.EventArgs {
        private string m_MessageHeader;
        private string m_MessageText;
        private string m_ParseSource;
        private string m_DateDetails;
        private ParseMessageType m_Type = ParseMessageType.None;

        public ParseMessageEventArgs() : base() { }

        public ParseMessageEventArgs(ParseMessageType type, string MessageHeader, string MessageText) : this() {
            m_MessageHeader = MessageHeader;
            m_MessageText = MessageText;
            m_Type = type;
        }

        public ParseMessageEventArgs(ParseMessageType type, string LineHeader, string MessageText, string Source) : this(type, LineHeader, MessageText) {
            m_ParseSource = Source;
        }
        public ParseMessageEventArgs(ParseMessageType type, string LineHeader, string MessageText, string Source, string Date) : this(type, LineHeader, MessageText, Source) {
            m_DateDetails = Date;
        }

        public string MessageText {
            get { return m_MessageText; }
            set { m_MessageText = value; }
        }

        public string Source {
            get { return m_ParseSource; }
            set { m_ParseSource = value; }
        }

        public string LineHeader {
            get { return m_MessageHeader; }
            set { m_MessageHeader = value; }
        }

        public string DateDetails {
            get { return m_DateDetails; }
            set { m_DateDetails = value; }
        }

        public ParseMessageType MessageType {
            get { return m_Type; }
            set { m_Type = value; }
        }
    }

    public enum ParseMessageType {
        None = -1,
        Info = 0,
        Warning = 1,
        Error = 2,
        Success = 3,
        Update = 4,
        Delete = 5,
        Archive = 6,
        Folder = 7,
        File = 8,
        App = 9,
        Resolved = 10,
        Login = 11,
        Privilege = 12
    };
}
