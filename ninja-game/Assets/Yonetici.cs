using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Yonetici : MonoBehaviour
{
    public GameObject toplar;
    public TextMeshProUGUI ttime;
    public GameObject panel1;
    float sayac = 60.9f;
    private GameObject kapsul;
    private Rigidbody rb;


    // oyunu kaybedince çýkan tekrar butonu için
    public void tekrar_oyna()
    {
        SceneManager.LoadScene(0);
        sayac = 60.9f;
        Time.timeScale = 1.0f;
    }


    // toplarýn random gelmesi için
    void Start()
    {
         float randRight = Random.Range(0.0f, 8.0f) + 1;
         float randLeft = Random.Range(0.0f, 8.0f) + 1;
        InvokeRepeating("Spawner", 1.0f, 3.0f);
    }

    void Spawner()
    {
        int randSayi = Random.Range(0,3);
        if (randSayi == 0)
        {
            kapsul=Instantiate(toplar,new Vector3(10, 1.5f, 1),Quaternion.identity);
            rb=kapsul.GetComponent<Rigidbody>();
            Destroy(kapsul, 3.7f);
        }
        if (randSayi == 1)
        {
            kapsul = Instantiate(toplar, new Vector3(-10, 1.5f, 1), Quaternion.identity);
            rb = kapsul.GetComponent<Rigidbody>();
            Destroy(kapsul, 3.7f);

        }
        if (randSayi == 2)
        {
            kapsul = Instantiate(toplar, new Vector3(10, 1.5f, 1), Quaternion.identity);
            rb = kapsul.GetComponent<Rigidbody>();
            Destroy(kapsul, 3.7f);
            kapsul = Instantiate(toplar, new Vector3(-10, 1.5f, 1), Quaternion.identity);
            rb = kapsul.GetComponent<Rigidbody>();
            Destroy(kapsul, 3.7f);
        }
    }


    //geri sayým ve sürenin ekranda gözükmesi için
    private void Update()
    {
        ttime.text=((int) sayac).ToString();
        if (sayac > 0)
        {
            sayac -= Time.deltaTime;
        }
        else
        {
            panel1.SetActive(true);
            sayac = 0.0f;
            Time.timeScale = 0.0f;
        }
        
    }


    //oyunu kazanýnca çýkan tekrar butonu için
    public void tekrar_oyna1()
    {
        SceneManager.LoadScene(0);
        sayac = 60.9f;
        Time.timeScale = 1.0f;
        
    }
}
