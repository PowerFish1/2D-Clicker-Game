using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisasterScript : MonoBehaviour
{
    public GameObject statusBox;
    public float cookieCheck;
    public int generateChance;
    public bool disasterActive;
    public int cookieLoss;

    // Update is called once per frame
    void Update()
    {
        cookieCheck = GlobalCookies.CookieCount / 10;

        if (!disasterActive)
        {
            StartCoroutine(StartDisaster());
        }
    }

    IEnumerator StartDisaster()
    {
        disasterActive = true;
        generateChance = Random.Range(1, 50);
        if (cookieCheck >= generateChance)
        {
            cookieLoss = Mathf.RoundToInt(GlobalCookies.CookieCount * 0.25f);
            statusBox.GetComponent<Text>().text = "You lost " + cookieLoss + " cookies in a factory fire!";
            GlobalCookies.CookieCount -= cookieLoss;
            yield return new WaitForSeconds(3);
            statusBox.GetComponent<Animation>().Play("StatusAnimation");
            yield return new WaitForSeconds(1);
            statusBox.SetActive(false);
            statusBox.SetActive(true);
            yield return new WaitForSeconds(6);
        }
        else
        {
            yield return new WaitForSeconds(10);
        }
        disasterActive = false;
    }
}