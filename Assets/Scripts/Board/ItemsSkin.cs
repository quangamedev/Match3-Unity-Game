using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

[CreateAssetMenu(menuName = "Scriptable Objects/Board Items Skin Config", fileName = "new BoardItemsSkinConfig")]
public class ItemsSkin : ScriptableObject
{
    [SerializeField] private SpriteAtlas skinAtlas;
    [SerializeField] private string itemNamePrefix;

    public Sprite GetItemSprite(int itemId)
    {
        return skinAtlas.GetSprite($"{itemNamePrefix}_{itemId}");
    }
}
