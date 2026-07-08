using UnityEngine;

[CreateAssetMenu(menuName = "Products/Product")]
public class ProductData : ScriptableObject
{ 
   [SerializeField] private string productName;
   [SerializeField] private ProductCategory productCategory;
   [SerializeField] private GameObject prefab;
   [SerializeField] private float price;

   public string ProductName
   {
        get { return productName; }
   }

   public ProductCategory ProductCategory
   {
        get { return productCategory; }
   }
   
   public GameObject Prefab
   {
        get { return prefab; }
   }

   public float Price
   {
        get { return price; }
   }
}