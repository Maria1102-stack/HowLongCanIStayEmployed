using UnityEngine;

public class Product : MonoBehaviour
{
    [SerializeField] private ProductData data;

    public ProductData Data
    {
        get { return data; }
    }
}
