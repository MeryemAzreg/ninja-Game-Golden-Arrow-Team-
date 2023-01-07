using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ninja : MonoBehaviour
{
    float can = 100.0f;
    float su_anki_can = 100.0f;

    public Image canbari;
    public GameObject panel;
    

    //karakterin toplara deðdiðinde caný azalmasý için
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "toplar")
        {
            su_anki_can -= 33.5f;
            canbari.fillAmount = su_anki_can / can;
            if (su_anki_can <= 0)
            {
                panel.SetActive(true);
                Time.timeScale = 0.0f;
            }
        }
    }
    public Animator anim;
    public float hiz;
    private Rigidbody rb;
    bool zeminde=false;


    //zeminde olup olmadýðýný kontrol etmek için
     private void OnCollisionStay(Collision collision)
     {
         if (collision.gameObject.tag == "zeminn")
         {
             zeminde=true;
         }
     }
    private void OnCollisionExit(Collision collision)
    {
        zeminde = false;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }


    //karakterin yönleri
    void Update()
    {
        float yatayH = Input.GetAxisRaw("Horizontal");
        float dikeyH = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (zeminde)
            {
                anim.SetTrigger("zýplaa");
                rb.velocity = new Vector3(0, 6, 0);

            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetTrigger("koss");
            transform.Translate(-hiz * Time.deltaTime, 0, 0,Space.World);
            
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 movement = new Vector3(yatayH, 0.0f, dikeyH);
            Transform transform=gameObject.GetComponent<Transform>();
            transform.rotation = Quaternion.Euler(0,-90,0);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetTrigger("koss");
            transform.Translate(hiz * Time.deltaTime, 0, 0, Space.World);

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 movement = new Vector3(yatayH, 0.0f, dikeyH);
            Transform transform = gameObject.GetComponent<Transform>();
            transform.rotation = Quaternion.Euler(0, 90, 0);

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            anim.SetTrigger("sabitt");
            
        }

        //karakterin ekrandan çýkmamasý için
        float clampedPosition = Mathf.Clamp(transform.position.x, -7, 7);
        transform.position = new Vector3(clampedPosition, transform.position.y, transform.position.z);

    }
    }

