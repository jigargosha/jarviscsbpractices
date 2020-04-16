using System;

namespace Prestige.Common
{
    /// <summary>
    /// Notifies Talent
    /// </summary>
    public static class NotificationService
    {
        static public string NotifyTalent(string s)
        {
            var message = "talent: " + s;
            Console.WriteLine(message);
            return message;
        }
    }
}