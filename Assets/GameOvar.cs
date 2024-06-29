using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnDestroy : MonoBehaviour
{
    // 破壊時にロードするシーンの名前
    public string sceneToLoad;

    void OnDestroy()
    {
        // シーンをロードする
        SceneManager.LoadScene(sceneToLoad);
    }
}
