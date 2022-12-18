using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace lgames
{

    [InitializeOnLoad]
    public class HierarchyObjects : Editor
    {
        private static readonly List<string> objectNameList = new()
        {
            "CAMERA",
            "CAMERAS",
            "CHARACTER",
            "CHARACTERS",
            "CONTROLLER",
            "CONTROLLERS",
            "CREATE ON RUN",
            "EFFECT",
            "EFFECTS",
            "ENEMY",
            "ENEMIES",
            "ENVIRONMENT",
            "ENVIRONMENTS",
            "HANDLER",
            "HANDLERS",
            "LEVEL",
            "LEVELS",
            "LIGHTNING",
            "LIGHTNINGS",
            "MANAGER",
            "MANAGERS",
            "OBSTACLE",
            "OBSTACLES",
            "OBJECTIVE",
            "OBJECTIVES",
            "PLAYER",
            "PLAYERS",
            "POST PROCESSING",
            "POST PROCESSINGS",
            "RUN",
            "RUN ON CREATE",
            "UI",
            "USER INTERFACE"
        };

        private static Vector2 offset = new(20, 1);

        static HierarchyObjects()
        {
            EditorApplication.hierarchyWindowItemOnGUI += HandleHierarchyWindowItemOnGUI;
        }

        private static void HandleHierarchyWindowItemOnGUI(int instanceID, Rect selectionRect)
        {
            var obj = EditorUtility.InstanceIDToObject(instanceID);

            if (obj != null)
            {
                Color backgroundColor = Color.white;
                Color textColor = Color.white;
                Texture2D texture = null;

                foreach (string objName in objectNameList)
                {
                    if (objName.Equals(obj.name))
                    {
                        backgroundColor = new Color32(48, 86, 86, 255);
                        textColor = Color.yellow;
                    }
                }

                if (backgroundColor != Color.white)
                {
                    Rect offsetRect = new(selectionRect.position + offset, selectionRect.size);
                    Rect bgRect = new(selectionRect.x, selectionRect.y, selectionRect.width + 50, selectionRect.height);

                    EditorGUI.DrawRect(bgRect, backgroundColor);
                    EditorGUI.LabelField(offsetRect, obj.name, new GUIStyle()
                    {
                        normal = new GUIStyleState() { textColor = textColor },
                        fontStyle = FontStyle.Bold
                    });

                    if (texture != null)
                        EditorGUI.DrawPreviewTexture(new Rect(selectionRect.position, new Vector2(selectionRect.height, selectionRect.height)), texture);
                }
            }
        }

    }
}
