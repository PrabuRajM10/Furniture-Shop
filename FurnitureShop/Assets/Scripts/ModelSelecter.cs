using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelSelecter : MonoBehaviour
{
    string itName;
    void Start()
    {
        itName = PlayerPrefs.GetString("ItemName");
        foreach(Transform iName in transform)
        {
            if(iName.name == itName)
            {
                iName.gameObject.SetActive(true);
            }
            else
            {
                iName.gameObject.SetActive(false);

            }
        }
    }

}
