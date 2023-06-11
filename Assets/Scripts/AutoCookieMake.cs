using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCookieMake : MonoBehaviour
{
    public bool MakingCookie = false;
    public static int CookieIncrease = 1;
    public int InternalIncrease;


    // Update is called once per frame
    void Update()
    {
        CookieIncrease = GlobalBaker.cookiePerSecond;
        InternalIncrease = CookieIncrease;


        if (!MakingCookie)
        {
            MakingCookie = true;
            StartCoroutine(CreateTheCookie());
        }

    }


    IEnumerator CreateTheCookie()
    {
        GlobalCookies.CookieCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        MakingCookie = false;
    }
}
