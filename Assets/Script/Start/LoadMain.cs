using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadMain : MonoBehaviour {

    public void NextScene()
    {
        SceneManager.LoadScene("Main");
    }
}
