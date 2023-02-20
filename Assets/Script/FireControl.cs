using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FireControl : MonoBehaviour
{
    public GameObject food;
    public float fireRate = 0.3f;
    private float nextFire = 0.0f;

 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("FireUp")&&(Time.time-nextFire)>=fireRate){
            transform.rotation = new Quaternion(0f,0f,0f,0f);
            Instantiate(food, transform.position, transform.rotation);
            nextFire = Time.time;
        }
        if(Input.GetButton("FireDown")&&(Time.time-nextFire)>=fireRate){
            transform.rotation = new Quaternion(0f,-1f,0f,0f);
            Instantiate(food, transform.position, transform.rotation);
            nextFire = Time.time;
        }
        if(Input.GetButton("FireRight")&&(Time.time-nextFire)>=fireRate){
            transform.rotation = new Quaternion(0f,1f,0f,1f);
            Instantiate(food, transform.position, transform.rotation);
            nextFire = Time.time;
        }
        if(Input.GetButton("FireLeft")&&(Time.time-nextFire)>=fireRate){
            transform.rotation = new Quaternion(0f,-1f,0f,1f);
            Instantiate(food, transform.position, transform.rotation);
            nextFire = Time.time;
        }
    }

}
