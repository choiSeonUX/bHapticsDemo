using Bhaptics.SDK2;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bHapticsEvent : MonoBehaviour
{
    [SerializeField] private Slider angleXSlider;
    [SerializeField] private Slider offsetYSlider;
    [SerializeField] Transform cube;
    [SerializeField] Transform player;

    private float minDistance = 1f;
    private float maxDistance = 10f;
    private float intensity;
    private float duration = 1f;
    private string currentEvent = "";

    private Dictionary<string, Vector2> eventAngles = new Dictionary<string, Vector2>();

    private void Start()
    {
        eventAngles["GUUUUN"] = new Vector2(0f, 0f);
        eventAngles["SHOTGUN"] = new Vector2(0f, 0f);
        eventAngles["BOOOMB"] = new Vector2(0f, 0f);
        eventAngles["KNIFE"] = new Vector2(0f, 0f);

        angleXSlider.onValueChanged.AddListener(delegate { OnSliderValueChanged(); });
        offsetYSlider.onValueChanged.AddListener(delegate { OnSliderValueChanged(); });
    }

    private void SetSliderValues(string eventName)
    {
        Vector2 angles = eventAngles[eventName];
        angleXSlider.value = angles.x;
        offsetYSlider.value = angles.y;
        currentEvent = eventName;
    }

    public void Gun()
    {
        SetSliderValues("GUUUUN");
        PlayEvent();
    }

    public void Bomb()
    {
        SetSliderValues("BOOOMB");
        PlayEvent();
    }

    public void Knife()
    {
        SetSliderValues("KNIFE");
        PlayEvent();
    }

    public void OnSliderValueChanged()
    {
        if (!string.IsNullOrEmpty(currentEvent))
        {
            eventAngles[currentEvent] = new Vector2(angleXSlider.value, offsetYSlider.value);
            PlayEvent();
        }
    }
    public void Reset()
    {
        if (!string.IsNullOrEmpty(currentEvent))
        {
            SetSliderValues(currentEvent);
        }
    }

    public void PlayEvent()
    {
        if (string.IsNullOrEmpty(currentEvent)) return;

        float distance = Vector3.Distance(player.position, cube.position);
        intensity = Mathf.Clamp(1 - ((distance - minDistance) / (maxDistance - minDistance)), 0, 1);

        float angleX = angleXSlider.value;
        float offsetY = offsetYSlider.value;

        switch (currentEvent)
        {
            case "GUUUUN":
                BhapticsLibrary.PlayParam(BhapticsEvent.GUUUUN, intensity, duration, angleX, offsetY);
                break;
            case "BOOOMB":
                BhapticsLibrary.PlayParam(BhapticsEvent.BOOOMB, intensity, duration, angleX, offsetY);
                break;
            case "KNIFE":
                BhapticsLibrary.PlayParam(BhapticsEvent.KNIFE, intensity, duration, angleX, offsetY);
                break;
        }
    }
}
