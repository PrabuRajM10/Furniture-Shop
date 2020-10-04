using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UImanager : MonoBehaviour
{
    private Text iName;

   

    private void Start()
    {
        iName = GetComponent<Text>();
        //Debug.Log(iName);
    }
    public void OnClickSelect()
    {
        PlayerPrefs.SetString("ItemName", iName.text);
        PlayerPrefs.Save();
        Debug.Log(PlayerPrefs.GetString("ItemName"));
        SceneManager.LoadScene("SampleScene");
    }
     public void Back()
    {
        SceneManager.LoadScene("Catalog");
       
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void View()
    {

        SceneManager.LoadScene("Catalog");
    }
    public void BackToMM()
    {

        SceneManager.LoadScene("MenuScene");
    }

}
