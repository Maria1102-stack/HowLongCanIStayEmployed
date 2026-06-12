using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    private float openAngle = 90f;

    private bool isOpen = false;

    void Start()
    {
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
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            Debug.Log("The door has been closed");
        }
        else
        {
            transform.localRotation = Quaternion.Euler(0, openAngle, 0);
            Debug.Log("The door has been opened");
        }

        isOpen = !isOpen;
    }
}
