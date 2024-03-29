﻿using System;

namespace Domain
{
    public class EmailSettings
    {
        public string SmtpServer { get; set; }

        public string SmtpUsername { get; set; }

        public string SmtpPassword { get; set; }

        public int SmtpServerPort { get; set; }

        public bool EnableSsl { get; set; }

        public string EmailDisplayName { get; set; }

        public string SenderName { get; set; }

        public EmailSettings() { }

        public EmailSettings(string smtpServer, string smtpUsername, string smtpPassword, int smtpPort)
        {
            this.SmtpServer = smtpServer;
            this.SmtpUsername = smtpUsername;
            this.SmtpPassword = smtpPassword;
            this.SmtpServerPort = smtpPort;
        }
    }
}
