using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            // コルーチン開始
            StartCoroutine(LoadScene());
        }
    }

    // シーンをロードする(非同期)
    IEnumerator LoadScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("title");

        // ロードがまだなら次のフレームへ
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}