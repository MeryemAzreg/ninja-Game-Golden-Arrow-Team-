using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private Rigidbody rb;
    public Animator anim;
    bool zeminde = false;
    public float jumpForce = 10.0f;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (zeminde)
            {
                anim.SetTrigger("zýplaa");
                // transform.Translate(0, 70 * Time.deltaTime, 0, Space.World);
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

                // rb.velocity = new Vector3(0, 6, 0);

            }
        }
    }
}
