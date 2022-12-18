using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace lgames
{
    public class Log
    {

        private static readonly string infoFontColor = "#00bdfe";

        private static readonly string warnFontColor = "#ffc107";

        private static readonly string errorFontColor = "#ff534a";

        public static void Print(Object tag, string message)
        {
            Debug.Log($"<b>[{tag.GetType().Name}]</b> {message}", tag);
        }

        public static void Print(Object tag, string message, bool invisible = false)
        {
            if (!invisible)
            {
                Debug.Log($"<b>[{tag.GetType().Name}]</b> {message}", tag);
            }
        }

        public static void Info(Object tag, string message)
        {
            Debug.Log($"<color={infoFontColor}><b>[{tag.GetType().Name}]</b> {message}</color>", tag);
        }

        public static void Info(Object tag, string message, bool invisible = false)
        {
            if (!invisible)
            {
                Debug.Log($"<color={infoFontColor}><b>[{tag.GetType().Name}]</b> {message}</color>", tag);
            }
        }

        public static void Warn(Object tag, string message)
        {
            Debug.LogWarning($"<color={warnFontColor}><b>[{tag.GetType().Name}]</b> {message}</color>", tag);
        }

        public static void Warn(Object tag, string message, bool invisible = false)
        {
            if (!invisible)
                return;

            Debug.LogWarning($"<color={warnFontColor}><b>[{tag.GetType().Name}]</b> {message}</color>", tag);
        }

        public static void Error(Object tag, string message)
        {
            Debug.LogError($"<color={errorFontColor}><b>[{tag.GetType().Name}]</b> {message}</color>", tag);
        }

        public static void Error(Object tag, string message, bool invisible = false)
        {
            if (!invisible)
            {
                Debug.LogError($"<color={errorFontColor}><b>[{tag.GetType().Name}]</b> {message}</color>", tag);
            }
        }

    }
}
