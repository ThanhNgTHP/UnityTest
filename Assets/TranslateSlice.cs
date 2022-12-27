using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateSlice : MonoBehaviour
{

    // https://learn.unity.com/tutorial/using-9-slicing-for-scalable-sprites-2019-3#

    float minSize = 5;
    float maxSize = 10;
    float resizeSpeed = 3;
    float positionY;

    SpriteRenderer spriteRenderer;
    void Start()
    {
        Cursor.visible = false;
        spriteRenderer = GetComponent<SpriteRenderer>();

        //spriteRenderer.size = new Vector2(7.5f, spriteRenderer.size.y);

        //print(spriteRenderer.size);

        positionY = -Camera.main.orthographicSize + spriteRenderer.size.y * 0.5f;


    }

    // Update is called once per frame
    void Update()
    {
        //print(Input.GetAxisRaw("Mouse ScrollWheel"));

        float sizeX = spriteRenderer.size.x;
        //sizeX += resizeSpeed;

        //print(Input.mousePosition);

        sizeX = Mathf.Clamp(sizeX, minSize, maxSize);
        spriteRenderer.size = new Vector2(sizeX, spriteRenderer.size.y);
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePosition.x, positionY);

    }
}
