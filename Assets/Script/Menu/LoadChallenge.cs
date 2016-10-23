using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadChallenge : MonoBehaviour {

    public void NextScene()
    {
        SceneManager.LoadScene(Global.CnsSceneChallenge);
    }
}
