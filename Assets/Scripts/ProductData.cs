using UnityEngine;

[CreateAssetMenu(menuName = "Products/Product")]
public class ProductData : ScriptableObject
{ 
   [SerializeField] private string productName;
   [SerializeField] private ProductCategory productCategory;
   [SerializeField] private GameObject prefab;
   [SerializeField] private float price;

   public string productName
   {
        get { return productName; }
   }

   public ProductCategory productCategory
   {
        get { return productCategory; }
   }
   
   public GameObject prefab
   {
        get { return prefab; }
   }

   public float price
   {
        get { return price; }
   }
}