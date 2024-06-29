using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnDestroy : MonoBehaviour
{
    // �j�󎞂Ƀ��[�h����V�[���̖��O
    public string sceneToLoad;

    void OnDestroy()
    {
        // �V�[�������[�h����
        SceneManager.LoadScene(sceneToLoad);
    }
}
