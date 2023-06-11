using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalShop : MonoBehaviour
{
    public GameObject statusBox;
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int shopValue = 20;
    public GameObject shopStats;
    public static int numberOfShops;
    public static int sellPerSecond;
    public AudioSource alertSound;




 
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        sellPerSecond = numberOfShops;
        shopStats.GetComponent<Text>().text = "Shops " + numberOfShops + " @ " + sellPerSecond + " Cookie Per Second";
        if (currentCash >= shopValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
            realText.GetComponent<Text>().text = "Buy Cookie Shop    $" + shopValue;
        }
        else
        {
            fakeButton.SetActive(true);
            realButton.SetActive(false);
            fakeText.GetComponent<Text>().text = "Buy Cookie Shop    $" + shopValue;
        }
    }


    public void BuyShop()
    {
        if (currentCash < shopValue)
        {
            statusBox.GetComponent<Text>().text = "Not enough cash to buy cookie shop!";
            statusBox.GetComponent<Animation>().Play("StatusAnimation");
            alertSound.Play();
        }
    }
}
