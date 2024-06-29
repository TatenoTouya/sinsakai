using System.Collections.Generic;
using UnityEngine;

public class NumberUI : MonoBehaviour
{
    [SerializeField] List<Sprite> spriteList;   // スプライトリスト

    SpriteRenderer spriteRenderer;              // スプライトレンダラー

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // 数値の変更
    public void SetNumber(int _num)
    {
        if (_num < 0 || _num >= spriteList.Count) return;

        spriteRenderer.sprite = spriteList[_num];
    }
}