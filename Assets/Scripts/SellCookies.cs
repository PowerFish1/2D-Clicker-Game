using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellCookies : MonoBehaviour
{
    public GameObject textBox;
    public GameObject statusBox;
    public AudioSource sellCookieSound01;
    public AudioSource sellCookieSound02;
    public int generateTone;
    public AudioSource alertSound;
    public static int CookiePrice = 5;
    public int InternalPrice;

    public void SellCookie()
    {
        generateTone = Random.Range(1, 3);
        InternalPrice = CookiePrice;

        if (GlobalCookies.CookieCount == 0)
        {
            alertSound.Play();
            statusBox.GetComponent<Text>().text = "Not enough cookies to sell!";
            statusBox.GetComponent<Animation>().Play("StatusAnimation");
        }

        else
        {
            GlobalCookies.CookieCount -= 1;
            GlobalCash.CashCount += InternalPrice;
            
            if (generateTone == 1)
            {
                sellCookieSound01.Play();
            }
            else
            {
                sellCookieSound02.Play();
            }
            
        }
    }
}
