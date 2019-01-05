using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class objectPooling : MonoBehaviour
{
    public float shiftSpeed;
    public float xRangeLower;
    public float xRangeUpper;
    public float yRangeLower;
    public float yRangeUpper;

    void Update()
    {
        transform.position += -Vector3.right * shiftSpeed * Time.deltaTime; 
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "pool") {
            if (transform.tag == "cactus")
            {
                transform.position = new Vector2(Random.Range(xRangeLower, xRangeUpper), yRangeLower);
            }
            else if (transform.tag == "carrot")
            {
                float[] yRange = new float[2] { yRangeLower, yRangeUpper };
                int i = Random.Range(0, 2);
                transform.position = new Vector2(Random.Range(xRangeLower, xRangeUpper), yRange[i]);
            }
            else
            {
                transform.position = new Vector2(transform.position.x + 50, transform.position.y);
            }
        }
            
    }

}
