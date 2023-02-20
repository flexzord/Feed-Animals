using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
     public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
       transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Clamp(transform.position.z, -50f, 50f));
    }
    
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("food")){
            Destroy(gameObject);
        }
    }
}
