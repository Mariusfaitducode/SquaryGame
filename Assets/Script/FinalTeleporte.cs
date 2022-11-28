using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalTeleporte : MonoBehaviour
{
    public GameObject perso;

    public GameObject lab2D;

    public GameObject lab3D;

    //public Canvas canvasFond;

    public Camera camera;

    public Vector3 direction;

    private bool start;

    //private bool moveCam;

    private void OnTriggerEnter(Collider other)
    {
        Vector3 firstPos = perso.transform.position;
        //perso.transform.position = new Vector3(0, 110, 0);

        direction = new Vector3(29, 29, -100);
        camera.orthographic = false;
        start = true;
    }

    private void Update()
    {
        if (start)
        {
            if (perso.transform.position.y < 100)
            {
                print("ok");
                perso.transform.Translate(direction * Time.deltaTime * 0.2f);
            }
            else
            {
                print(camera.transform.position);
                if (camera.transform.position.y - perso.transform.position.y > 0.55f)
                    camera.transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * 0.5f);

                else
                {
                    perso.GetComponent<Renderer>().enabled = false;
                    lab2D.SetActive(false);
                    lab3D.SetActive(true);
                    //WaitToPlay();
                    perso.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
                    perso.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
                    perso.GetComponent<Rigidbody>().drag = 1f;
                    print("okk");
                    start = false;
                }
                
                
            }
            
        }
        
    }

    
}
