using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class oyunyoneticisi : MonoBehaviour
{


    GameObject donencember;
    GameObject anacember;
    public Animator animator;
    public Text donenCemberLevel,bir,iki,uc;
    public int kactanecemberolsun;
    bool kontrol = true;
     void Start()
    {
        PlayerPrefs.SetInt("kayit",int .Parse(SceneManager.GetActiveScene().name));
        donencember = GameObject.FindGameObjectWithTag("donencembertag");
        anacember = GameObject.FindGameObjectWithTag("anacembertag");
        donenCemberLevel.text =SceneManager.GetActiveScene().name;

        if(kactanecemberolsun < 2)
        {
            bir.text = kactanecemberolsun+"";
        }else if (kactanecemberolsun <3)
        {
            bir.text = kactanecemberolsun + "";
            iki.text = (kactanecemberolsun-1) + "";
        }
        else
        {
            bir.text = kactanecemberolsun + "";
            iki.text = (kactanecemberolsun - 1) + "";
            uc.text = (kactanecemberolsun - 2) + "";
        }
        


    }
    IEnumerator yeniLevel()
    {
        donencember.GetComponent<dondurme>().enabled = false;
        anacember.GetComponent<anacemberkod>().enabled = false;
        yield return new WaitForSeconds(2);
        if (kontrol)
        {
            animator.SetTrigger("yenilevel");
            yield return new WaitForSeconds(2);

            SceneManager.LoadScene(int.Parse(SceneManager.GetActiveScene().name)+1);

        }
       
    }
   

    public void oyunBitti()
    {
        StartCoroutine(yanmethod());
    }
    IEnumerator yanmethod()
    {

        donencember.GetComponent<dondurme>().enabled = false;
        anacember.GetComponent<anacemberkod>().enabled = false;
        animator.SetTrigger("oyunbittitrigger");
        kontrol = false;
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("anaMenu");

    }
    public void kucukcemlerdetextgoster()

    {
        kactanecemberolsun--;
        if (kactanecemberolsun < 2)
        {
            bir.text = kactanecemberolsun + "";
            iki.text = "";
            uc.text = "";
        }
        else if (kactanecemberolsun < 3)
        {
            bir.text = kactanecemberolsun + "";
            iki.text = (kactanecemberolsun - 1) + "";
            uc.text = "";
        }
        else
        {
            bir.text = kactanecemberolsun + "";
            iki.text = (kactanecemberolsun - 1) + "";
            uc.text = (kactanecemberolsun - 2) + "";
        }
        if (kactanecemberolsun == 0)
        {
            StartCoroutine(yeniLevel());
        }

    }
}
