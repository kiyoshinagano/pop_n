using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class SceneSetAndLoad : MonoBehaviour
{

    /*-----------------------------------------------------------------------
    * 概要：次に遷移するシーンをグローバル変数にセットする
    * 説明：オブジェクト名で判断して、シーン名をGlobal.NextSceneNameにセットする
    * ----------------------------------------------------------------------*/
    public void SetNextScene()
    {
        Global.NextSceneName = "";

        // Menu画面
        if (this.gameObject.name == "BtnLoadTra") { Global.NextSceneName = "Training"; }
        if (this.gameObject.name == "BtnLoadCha") { Global.NextSceneName = "Challenge"; }

        // Training画面
        if (this.gameObject.name == "BtnTrainingQ1") { Global.NextSceneName = "TraQ1Spec"; }
        if (this.gameObject.name == "BtnLoadTraQ1Question") { Global.NextSceneName = "TraQ1Question"; }

        if (this.gameObject.name == "BtnBackToMenu") { Global.NextSceneName = "Menu"; }
    }

    /*-----------------------------------------------------------------------
     * 概要：指定のシーンへ遷移する
     * 説明：Global.NextSceneNameを読み取って遷移
     * ----------------------------------------------------------------------*/
    public void LoadNextScene()
    {
        // シーン名がセットされていなかった場合
        if (Global.NextSceneName == "")
        {
            // エラーを出してとりあえずMenuに戻る
            Debug.LogError("SetNextSneceName：シーンがセットされませんでした。Menuに戻ります。");
            Global.NextSceneName = "Menu";
        }

        SceneManager.LoadScene(Global.NextSceneName);
    }

    /*-----------------------------------------------------------------------
     * 概要：シーンのセットと遷移を同時におこなう
     * 説明：SetNextSceneとLoadNextSceneを行う
     * ----------------------------------------------------------------------*/
    public void SetAndLoadNextScene()
    {
        SetNextScene();
        LoadNextScene();
    }
}

