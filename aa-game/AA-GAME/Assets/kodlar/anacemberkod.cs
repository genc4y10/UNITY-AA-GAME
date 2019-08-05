using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anacemberkod : MonoBehaviour
{
    public GameObject kucukCember;
    GameObject oyunyoneticisi;
    // Start is called before the first frame update
    void Start()
    {

        oyunyoneticisi = GameObject.FindGameObjectWithTag("oyunbittitag");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            kucukcemberolustur();
        }
        
    }
    void kucukcemberolustur()

    {
        Instantiate(kucukCember, transform.position, transform.rotation);
        oyunyoneticisi.GetComponent<oyunyoneticisi>().kucukcemlerdetextgoster();
    }
}
