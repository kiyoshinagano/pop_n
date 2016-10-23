using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadMenu : MonoBehaviour {

    public void NextScene()
    {
        SceneManager.LoadScene("Menu");
    }
}
