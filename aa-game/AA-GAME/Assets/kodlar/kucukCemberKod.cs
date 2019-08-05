using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kucukCemberKod : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D fizik;
    public float hiz;
    bool harketkont=false;
    GameObject oyunbittinesne;

    void Start()
    {
        oyunbittinesne = GameObject.FindGameObjectWithTag("oyunbittitag");
        fizik = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!harketkont)
        {
            fizik.MovePosition(fizik.position+Vector2.up*hiz*Time.deltaTime);

        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "donencembertag")
            transform.SetParent(collision.transform);
        {
            harketkont = true;
        }
        if (collision.tag == "kucukcembertag")
        {
            oyunbittinesne.GetComponent<oyunyoneticisi>().oyunBitti();
           //Debug.Log("oyun bitti");
        }
    }
}
