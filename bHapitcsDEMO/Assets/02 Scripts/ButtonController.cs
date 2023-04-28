using UnityEngine.EventSystems; 

public class ButtonController :  IPointerDownHandler, IPointerUpHandler
{
    private bool isPressed;
    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }
}
