using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthControl : MonoBehaviour
{
    public GameObject[] FullHearts;
    public GameObject[] EmptyHearts;

  
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject eHeart in EmptyHearts){
            eHeart.SetActive(false);
        }
        foreach(GameObject fHeart in FullHearts){
            fHeart.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
        
        
    }
    private void OnTriggerEnter(Collider other) {
         if(other.gameObject.CompareTag("enemy")){
            FullHearts[PlayerControl.lives].SetActive(false);
            EmptyHearts[PlayerControl.lives].SetActive(true);      
        }
    }
}
