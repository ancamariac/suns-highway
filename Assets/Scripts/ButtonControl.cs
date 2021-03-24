using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonControl : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
	public bool pressed = false;

	public void OnPointerDown(PointerEventData data)
	{
		pressed = true;
	}

	public void OnPointerUp(PointerEventData data)
	{
		pressed = false;
	}
}