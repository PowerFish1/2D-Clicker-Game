using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveGame : MonoBehaviour
{
    public int saveGameCash;
    public GameObject saveButton;
    public GameObject statusBox;



    // Update is called once per frame
    void Update()
    {
        saveGameCash = GlobalCash.CashCount;
    }




    public void SaveTheGame()
    {
        PlayerPrefs.SetInt("SavedCookies", GlobalCookies.CookieCount);
        PlayerPrefs.SetInt("SavedCash", GlobalCash.CashCount);
        PlayerPrefs.SetInt("SavedBakers", GlobalBaker.cookiePerSecond);
        PlayerPrefs.SetInt("SavedShops", GlobalShop.numberOfShops);
        statusBox.GetComponent<Text>().text = "Game Saved!";
        statusBox.GetComponent<Animation>().Play("StatusAnimation");
    }
}
