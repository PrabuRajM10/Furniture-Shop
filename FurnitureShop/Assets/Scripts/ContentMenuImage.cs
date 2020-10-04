using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ContentMenuImage : MonoBehaviour
{
    public CatalogScriptableObj inst;

    public Image displayitemImage;
    public Text displayitemName;
    public Text displayitemDes;
    public Text displayprice;
    void Start()
    {
        displayitemImage.sprite = inst.itemImage;
        displayitemName.text = inst.itemName;
        displayitemDes.text = inst.itemDes;
        displayprice.text = inst.price.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
