using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadTraQ1Spec : MonoBehaviour {

    public void NextScene()
    {
        SceneManager.LoadScene(Global.CnsSceneTraQ1Spec);
    }
}
