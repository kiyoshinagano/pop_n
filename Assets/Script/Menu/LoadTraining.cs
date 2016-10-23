using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadTraining : MonoBehaviour {

    public void NextScene()
    {
        SceneManager.LoadScene(Global.CnsSceneTraining);
    }
}
