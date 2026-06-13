using UnityEngine;

public class Product
{
    [SerializeField] private ProductData data;

    public ProductData Data
    {
        get { return data; }
    }
}
