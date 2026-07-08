using Microsoft.VisualBasic;
using UnityEngine;

public class HorizontalDoorOpening : MonoBehaviour
{
    [SerializeField] private float openAngle = 90f;

    private bool isOpen = false;
    private Quaternion closedRotation;
    private Quaternion openRotation;

    void Start()
    {
        closedRotation = transform.localRotation;
        openRotation = closedRotation * Quaternion.Euler(0, openAngle, 0);
        Debug.Log("Door script started");
    }

    public void OnMouseDown()
    {
        ToggleDoor();
        Debug.Log("Door clicked!");
    }

    public void ToggleDoor()
    {
        if(isOpen)
        {
            transform.localRotation = closedRotation;
            Debug.Log("The door has been closed");
        }
        else
        {
            transform.localRotation = openRotation;
            Debug.Log("The door has been opened");
        }

        isOpen = !isOpen;
    }
}
