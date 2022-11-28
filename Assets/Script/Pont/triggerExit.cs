using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerExit : MonoBehaviour
{
    public GameObject perso;
    public GameObject perso3D;
    public GameObject labyrinthe;
    public GameObject pontGame;
    public GameObject door;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            WaitToPlay(2);
        }
            
    }
    
    void WaitToPlay(float sec)
    {
        StartCoroutine(Delay(sec));
    }
    
    
    public IEnumerator Delay(float sec)
    {
        yield return new WaitForSeconds(sec);

        perso.transform.position = perso3D.transform.position;

        perso.SetActive(true);
        labyrinthe.SetActive(true);
        pontGame.SetActive(false);
            
        door.SetActive(false);
    }
}
