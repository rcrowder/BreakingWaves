using UnityEngine;

public class FPSCounter : MonoBehaviour
{
    private float deltaTime;

    void Start()
    {
        deltaTime = 0f;
    }

    void Update()
    {
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
    }

    void OnGUI()
    {
        int w = Screen.width, h = Screen.height;

        GUIStyle style = new GUIStyle();
        style.alignment = TextAnchor.UpperLeft;
        style.fontSize = 20; // h * 2 / 100;
        style.normal.textColor = new Color(0.0f, 0.0f, 0.5f, 1.0f);

        float msec = deltaTime * 1000.0f;
        float fps = 1.0f / deltaTime;
        string text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);

        Rect rect = new Rect(0, 0, w, h * 2 / 100);
        GUI.Label(rect, text, style);
    }
}
