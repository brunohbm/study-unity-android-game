using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColliderUIResize : MonoBehaviour
{
    void Start()
    {
        var rectTransform = gameObject.GetComponent<RectTransform>();
        float width = rectTransform.rect.width;
        float height = rectTransform.rect.height;
        Vector2 colliderSize = new Vector2(width, height);
        GetComponent<BoxCollider2D>().size = colliderSize;
    }
}
