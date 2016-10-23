using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadTraQ1Question : MonoBehaviour {

    public void NextScene()
    {
        SceneManager.LoadScene(Global.CnsSceneTraQ1Question);
    }
}
