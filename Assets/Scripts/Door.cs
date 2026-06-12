using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    private float openAngle = 90f;

    private bool isOpen = false;

    public void onMouseDown()
    {
        ToggleDoor();
    }

    public void ToggleDoor()
    {
        if(isOpen)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, openAngle, 0);
        }

        isOpen = !isOpen;
    }
}
