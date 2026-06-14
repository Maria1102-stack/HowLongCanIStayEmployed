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
            if (slot.childCount == 0)
            {
                Debug.Log($"Spawner: {acceptedProduct.ProductName}");
                Debug.Log($"Prefab: {acceptedProduct.Prefab.name}");
                Debug.Log($"Prefab rotation: {acceptedProduct.Prefab.transform.rotation.eulerAngles}");
                Debug.Log($"Slot rotation: {slot.rotation.eulerAngles}");

                GameObject product = Instantiate(
                     acceptedProduct.Prefab,
                    slot.position,
                    acceptedProduct.Prefab.transform.rotation,
                    slot
                );

                Debug.Log($"Spawned rotation: {product.transform.rotation.eulerAngles}");
            }
        }
    }

    private void Start()
    {
        Fill();
           
    }
}
