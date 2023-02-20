using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;

    public float playerSpeed;
    public float foodSpeed;

    public static int lives;
    

    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
    }

    // Update is called once per frame
    void Update()
    {
    
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right*playerSpeed*horizontalInput*Time.deltaTime);
        transform.Translate(Vector3.forward*playerSpeed*verticalInput*Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -18f, 18f), transform.position.y, Mathf.Clamp(transform.position.z, -18f, 18f));
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("enemy")){
            lives--;
                 
        }
    }    
}
