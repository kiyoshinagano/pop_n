using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadChaQ1Question : MonoBehaviour {

    public void NextScene()
    {
        SceneManager.LoadScene(Global.CnsSceneChaQ1Question);
    }
}
