using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FURNITURE FILE" , menuName = "FUN MENU")]
public class CatalogScriptableObj : ScriptableObject
{
    public Sprite itemImage;
    public string itemName;
    public string itemDes;
    public int price;

}
