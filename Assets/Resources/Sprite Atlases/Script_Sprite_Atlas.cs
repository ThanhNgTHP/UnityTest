using Mono.Cecil;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.U2D;

public class Script_Sprite_Atlas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SpriteAtlas spriteAtlas = Resources.Load<SpriteAtlas>("Sprite Atlases/Sprite Atlas");
        //print(spriteAtlas.spriteCount);
        Sprite sprite = spriteAtlas.GetSprite("arknights_muc_su");
    }

    // Update is called once per frame
    void Update()
    {
    }
}
