using UnityEngine;

public class Clonedestroy : MonoBehaviour
{
    void Update()
    {
        DestroyAllClones(gameObject);
    }

    private void DestroyAllClones(GameObject original)
    {
        // ���ׂĂ̓����I���W�i���̃C���X�^���X���擾����
        GameObject[] clones = GameObject.FindGameObjectsWithTag(original.tag);

        // ���ׂẴN���[�����폜����
        foreach (GameObject clone in clones)
        {
            if (clone != original)
            {
                Destroy(clone);
            }
        }
    }
}