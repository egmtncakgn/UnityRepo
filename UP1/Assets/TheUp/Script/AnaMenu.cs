using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnaMenu : MonoBehaviour {

    public void Oyna()
    {
        SceneManager.LoadScene(1);
    }
    public void Cik()
    {
        Application.Quit();
    }
}
