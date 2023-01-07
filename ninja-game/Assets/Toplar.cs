using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toplar : MonoBehaviour
{
    
    private Vector3 yon = Vector3.left;

    public Image canbari;


    //toplar�n karaktere de�di�inde silinmesi i�in
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag =="char")
        {
            Destroy(gameObject);
           
        }
    }


    // toplar�n geli� h�z� ve y�n� i�in
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


