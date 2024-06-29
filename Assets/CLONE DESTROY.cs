using UnityEngine;

public class Clonedestroy : MonoBehaviour
{
    void Update()
    {
        DestroyAllClones(gameObject);
    }

    private void DestroyAllClones(GameObject original)
    {
        // すべての同じオリジナルのインスタンスを取得する
        GameObject[] clones = GameObject.FindGameObjectsWithTag(original.tag);

        // すべてのクローンを削除する
        foreach (GameObject clone in clones)
        {
            if (clone != original)
            {
                Destroy(clone);
            }
        }
    }
}