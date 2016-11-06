using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/*-----------------------------------------------------------------------
 * 概要：次に遷移するシーンをグローバル変数にセットするクラス
 * 説明：オブジェクト名で判断して、シーン名をGlobal.NextSceneNameにセットする
 * ----------------------------------------------------------------------*/

public class SetNextSceneName : MonoBehaviour {

    public void SetNextSneceName () {

        Global.NextSceneName = "";

        // Menu画面
        if (this.gameObject.name == "BtnLoadTra") { Global.NextSceneName = "Training"; }
        if (this.gameObject.name == "BtnLoadCha") { Global.NextSceneName = "Challenge"; }

        // Training画面
        if (this.gameObject.name == "BtnTrainingQ1") { Global.NextSceneName = "TraQ1Spec"; }
        if (this.gameObject.name == "BtnLoadTraQ1Question") { Global.NextSceneName = "TraQ1Question"; }

        if (this.gameObject.name == "BtnBackToMenu") { Global.NextSceneName = "Menu"; }
        
        // シーン名がセットされていなかった場合
        if (Global.NextSceneName == ""){
            // エラーを出してとりあえずMenuに戻る
            Debug.LogError("SetNextSneceName：シーンがセットされませんでした。Menuに戻ります。");
            Global.NextSceneName = "Menu";
        }
    }
}
