using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public float windPower = 10f;
    void OnTriggerEnter2D (Collider2D collider)
    {
        if(collider.gameObject.tag == "Windy"){
            collider.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * windPower, ForceMode2D.Impulse);
        }        
    }

}
