using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour {

	// Use this for initialization
	public void NextScene () {
        SceneManager.LoadScene(Global.NextSceneName);
    }
}
