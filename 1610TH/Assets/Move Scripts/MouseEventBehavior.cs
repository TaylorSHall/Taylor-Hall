using UnityEngine;
using UnityEngine.Events;

public class MouseEventBehavior : MonoBehaviour
{
    public UnityEvent MouseDown;
    public UnityEvent MouseUp;
    
    //Tip: Void is a function that returns void, or nothing.
    private void OnMouseDown()
    {
        MouseDown.Invoke();
    }
    private void OnMouseUp()
    {
        MouseUp.Invoke();
    }
}
