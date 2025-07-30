using UnityEngine;

namespace Hackaton.Scripts.Utilities
{
    public static class ConsoleLogger
    {
        // Debug messages
        private const string DebugMessage = "<b>[{0}]</b> {1}";

        /// <summary>
        /// Logs a message to the console.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="name">The name of the object that is logging the message.</param>
        public static void LogMessage(string name, string message)
        {
#if UNITY_EDITOR
            Debug.Log(string.Format(DebugMessage, name, message));
#endif
        }

        /// <summary>
        /// Logs an error message to the console.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="name">The name of the object that is logging the message.</param>
        public static void LogError(string name, string message)
        {
#if UNITY_EDITOR
            Debug.LogError(string.Format(DebugMessage, name, message));
#endif
        }
    }
}