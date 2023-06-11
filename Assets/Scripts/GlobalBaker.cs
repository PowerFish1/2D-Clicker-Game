using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBaker : MonoBehaviour
{
    public GameObject statusBox;
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int bakerValue = 20;
    public GameObject bakerStats;
    public static int numberOfBakers;
    public static int cookiePerSecond;
    public AudioSource alertSound;
 

    // Update is called once per frame
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        cookiePerSecond = numberOfBakers;
        bakerStats.GetComponent<Text>().text = "Bakers " + numberOfBakers + " @ " + cookiePerSecond + " Cookie Per Second"; 
        if (currentCash >= bakerValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
            realText.GetComponent<Text>().text = "Buy Cookie Maker $" + bakerValue;
        }
        else
        {
            fakeButton.SetActive(true);
            realButton.SetActive(false);
            fakeText.GetComponent<Text>().text = "Buy Cookie Maker $" + bakerValue;
        }
    }

    public void BuyBaker()
    {
        if (currentCash < bakerValue)
        {
            statusBox.GetComponent<Text>().text = "Not enough cash to buy baker!";
            statusBox.GetComponent<Animation>().Play("StatusAnimation");
            alertSound.Play();
        }
    }
}
