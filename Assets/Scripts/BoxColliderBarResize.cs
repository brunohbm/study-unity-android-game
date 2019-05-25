using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColliderBarResize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    	var rectTransform = gameObject.GetComponent<RectTransform>();
		 float width = rectTransform.sizeDelta.x;
		 float height = rectTransform.sizeDelta.y;
    	Vector2 colliderSize = new Vector2(width, height);    	    	 
    	 Debug.Log("Screen Width : " + width);
    	 Debug.Log("Screen height : " + height);
    	GetComponent<BoxCollider2D>().size = colliderSize;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
