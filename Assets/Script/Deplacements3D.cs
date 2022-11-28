using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacements3D : MonoBehaviour
{
    private Rigidbody m_rigid;
    
    public Camera mainCamera;

    public bool is_ortho = false;

    private bool is_collison = false;

    public Vector3 m_Input;
    public Vector3 m_Rotate;

    private void Start()
    {
        m_rigid = gameObject.GetComponent<Rigidbody>();
    }

    public void KeyZoom()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(Vector3.forward * 15f * Time.fixedDeltaTime); 

        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * 15f * Time.fixedDeltaTime); 

        }
    }

    public void orthographic_vision()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (is_ortho)
            {
                mainCamera.orthographic = false;
                is_ortho = false;
            }
            else
            {
                mainCamera.orthographic = true;
                is_ortho = true;
            }
            
        }
    }

    private void Update()
    {
        orthographic_vision();
        m_Input = new Vector3(Input.GetAxis("Vertical"), 0, 0);
        
        m_Rotate = new Vector3(0, 0, Input.GetAxis("Horizontal"));
        
        gameObject.transform.Rotate(m_Rotate * Time.deltaTime * -100f);
        gameObject.transform.Translate(m_Input * Time.deltaTime * -2f);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        //KeyRotation();
        
        //if (gameObject.)
        //m_rigid.AddForce(m_Input * -100f, ForceMode.Force);
        //KeyZoom();
    }
}
