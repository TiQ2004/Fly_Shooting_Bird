using GameTool;
using UnityEngine;

public class Block : BasePooling
{
    public SpriteRenderer sr;
    public BoxCollider2D coll;
    public BlockType blockType;
    public float curHp;

    public void SetData()
    {
        curHp = GameData.Instance.blockData.blockInfos[(int)blockType].maxHP;
        sr.sprite = GameData.Instance.blockData.blockInfos[(int)blockType].status[2];
    }

}
