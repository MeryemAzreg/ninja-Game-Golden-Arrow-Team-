using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toplar : MonoBehaviour
{
    
    private Vector3 yon = Vector3.left;

    public Image canbari;


    //toplarýn karaktere deðdiðinde silinmesi için
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag =="char")
        {
            Destroy(gameObject);
           
        }
    }


    // toplarýn geliþ hýzý ve yönü için
    void Update()
        {
            
            transform.Translate(yon * 5.3f * Time.deltaTime);

            if (transform.position.x <= -10)
            {
                yon = Vector3.right;
            }
            else if(transform.position.x >= 10){

                yon = Vector3.left;
            }
            
        }
    }


