using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    public float springPower = 10f;
    void OnCollisionEnter2D (Collision2D collision)
    {
        if(collision.gameObject.tag == "Player"){
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * springPower, ForceMode2D.Impulse);
        }
    }
}
