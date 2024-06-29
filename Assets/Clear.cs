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
            // �R���[�`���J�n
            StartCoroutine(LoadScene());
        }
    }

    // �V�[�������[�h����(�񓯊�)
    IEnumerator LoadScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("title");

        // ���[�h���܂��Ȃ玟�̃t���[����
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}