using UnityEngine;

public class Column : MonoBehaviour
{
    [SerializeField] private ProductData acceptedProduct;

    public ProductData AcceptedProduct
    {
        get { return acceptedProduct; }
    }
}
