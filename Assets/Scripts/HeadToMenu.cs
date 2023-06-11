using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HeadToMenu : MonoBehaviour
{

    public void GoToMenu()
    {
        SceneManager.LoadScene(1);
    }
}
