using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D objectToThrow;
    Vector2 startPos, endPos, direction;
    float touchTimeStart, touchTimeFinish, timeInterval;
    
    [SerializeField]
    [Range(0.05f, 1f)]
    float throwForce = 0.3f;

    void Update()
    {
        if (checkTouchHasBegan()) return;
        if (checkTouchHasEnded()) throwObject();

    }

    void throwObject () {
        objectToThrow.AddForce(-direction/timeInterval * throwForce);
    }

    bool checkTouchHasBegan()
    {
        if (checkTouchPhase(TouchPhase.Began)) {
            touchTimeStart = Time.time;
            startPos = Input.GetTouch(0).position;
            return true;
        }
        return false;
    }

    bool checkTouchHasEnded()
    {
        if (checkTouchPhase(TouchPhase.Ended)) {
            touchTimeFinish = Time.time;
            timeInterval = touchTimeFinish - touchTimeStart;
            endPos = Input.GetTouch(0).position;
            direction = startPos - endPos;
            return true;
        }
        return false;
    }

    bool checkTouchPhase(TouchPhase touchPhase)
    {
        return (Input.touchCount > 0 && Input.GetTouch(0).phase == touchPhase);
    }
}
