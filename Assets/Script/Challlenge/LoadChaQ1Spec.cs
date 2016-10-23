using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadChaQ1Spec : MonoBehaviour {

    public void NextScene()
    {
        SceneManager.LoadScene(Global.CnsSceneChaQ1Spec);
    }
}
