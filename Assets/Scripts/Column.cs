using UnityEngine;

public class Column : MonoBehaviour
{
    [SerializeField] private ProductData acceptedProduct;
    [SerializeField] private Transform[] slots;

    public ProductData AcceptedProduct
    {
        get { return acceptedProduct; }
    }

    public Transform[] Slots
    {
        get { return slots; }
    }

    public void Fill()
    {
        foreach (Transform slot in slots)
        {
            if(slot.childCount == 0)
            {
                Instantiate(
                    acceptedProduct.Prefab,
                    slot.position,
                    slot.rotation * Quaternion.Euler(0, 90, 0),
                    slot
                );
            }
        }
    }

    private void Start()
    {
        Fill();
    }
}
