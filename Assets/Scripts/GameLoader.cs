using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour
{
    public int SavedCookies;
    public int SavedCash;
    public int SavedBakers;
    public int SavedShops;

    // Start is called before the first frame update
    void Start()
    {
        if (MainMenuOptions.isLoading)
        {
            SavedCookies = PlayerPrefs.GetInt("SavedCookies");
            GlobalCookies.CookieCount = SavedCookies;
            SavedCash = PlayerPrefs.GetInt("SavedCash");
            GlobalCash.CashCount = SavedCash;
            SavedBakers = PlayerPrefs.GetInt("SavedBakers");
            GlobalBaker.numberOfBakers = SavedBakers;
            SavedShops = PlayerPrefs.GetInt("SavedShops");
            GlobalShop.numberOfShops = SavedShops;
        }
    }
}
