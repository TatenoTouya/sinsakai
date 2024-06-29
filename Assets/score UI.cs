using System.Collections.Generic;
using UnityEngine;

public class NumberUI : MonoBehaviour
{
    [SerializeField] List<Sprite> spriteList;   // �X�v���C�g���X�g

    SpriteRenderer spriteRenderer;              // �X�v���C�g�����_���[

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // ���l�̕ύX
    public void SetNumber(int _num)
    {
        if (_num < 0 || _num >= spriteList.Count) return;

        spriteRenderer.sprite = spriteList[_num];
    }
}