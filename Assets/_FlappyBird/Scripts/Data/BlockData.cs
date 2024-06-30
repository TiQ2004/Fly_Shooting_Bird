using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "BlockData", menuName = "Block Data")] 
public class BlockData : ScriptableObject
{
    public List<BlockInfo> blockInfos;
}
[Serializable]
public class BlockInfo
{
    public BlockType blockType;
    public float maxHP;
    public List<Sprite> status;
}
public enum BlockType
{
    Wood = 1,
    Stone = 2,
    Metal = 3,
}