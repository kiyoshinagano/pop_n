using UnityEngine;
using System.Collections;

public class Global : MonoBehaviour {

    /*---------------------------------------------------
     * 定数
     * --------------------------------------------------*/
    // シーン名
    public const string CnsSceneTraining = "Training";
    public const string CnsSceneChallenge = "Challenge";

    public const string CnsSceneTraQ1Spec = "TraQ1Spec";
    public const string CnsSceneTraQ1Question = "TraQ1Question";

    public const string CnsSceneChaQ1Spec = "ChaQ1Spec";
    public const string CnsSceneChaQ1Question = "ChaQ1Question";

    /*---------------------------------------------------
     * 変数
     * --------------------------------------------------*/
    public static string NextSceneName = "";    // 次に遷移するシーン名

    // このオブジェクト用の変数
    private static bool isCreatedObj = false;   // オブジェクト作成済みフラグ

    void Awake()
    {
        // 作成済みフラグがoffの場合
        if (isCreatedObj == false)
        {
            // シーンが切り替わってもオブジェクトを破棄しない
            DontDestroyOnLoad(this.gameObject);

            // 作成済みフラグをOnにする
            isCreatedObj = true;
            // 作成済みフラグがonの場合
        }
        else
        {
            // オブジェクトを破棄する
            Destroy(this.gameObject);
        }
    }
}
