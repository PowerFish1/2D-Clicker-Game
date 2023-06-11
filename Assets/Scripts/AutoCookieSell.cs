using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoCookieSell : MonoBehaviour
{
    public bool SellingCookie = false;
    public static int cookieDecrease = 1;
    public int InternalDecrease;
    public GameObject statusBox;
    public GameObject shopStats;
    public AudioSource alertSound;


    // Update is called once per frame
    void Update()
    {
        if (GlobalCookies.CookieCount > 0)
        {
            cookieDecrease = GlobalShop.sellPerSecond;
            InternalDecrease = cookieDecrease;
            

            if (!SellingCookie)
            {
                SellingCookie = true;
                StartCoroutine(AutoSell());
            }
        }

        else
        {
            GlobalShop.sellPerSecond = 0;
            statusBox.GetComponent<Text>().text = "Not enough cookies in the shop to sell!";
            shopStats.GetComponent<Text>().text = "Shops " + GlobalShop.numberOfShops + " @ " + GlobalShop.sellPerSecond + " Cookie Per Second";
        }
    }


    IEnumerator AutoSell()
    {
        if (GlobalCookies.CookieCount < GlobalShop.numberOfShops)
        { 
            GlobalCash.CashCount += GlobalCookies.CookieCount * SellCookies.CookiePrice;
            GlobalCookies.CookieCount -= GlobalCookies.CookieCount;
        }
        else
        {
            GlobalCash.CashCount += GlobalShop.sellPerSecond * SellCookies.CookiePrice;
            GlobalCookies.CookieCount -= InternalDecrease;
        }
        yield return new WaitForSeconds(1);
        SellingCookie = false;
    }
}
