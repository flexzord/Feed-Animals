using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabes;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn(prefabes));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawn(GameObject[] prefabes){
        yield return new WaitForSeconds(5f);
        while(true){
        int randPrefabe = Random.Range(0,prefabes.Length);
        int randPosition = Random.Range(-15,15);
        Instantiate(prefabes[randPrefabe], new Vector3(randPosition,0,30), new Quaternion(0,-2,0,0));
        yield return new WaitForSeconds(1f);
        randPrefabe = Random.Range(0,prefabes.Length);
        randPosition = Random.Range(-15,15);
        Instantiate(prefabes[randPrefabe], new Vector3(randPosition,0,-30), new Quaternion(0,0,0,0));
        yield return new WaitForSeconds(1f);
        randPrefabe = Random.Range(0,prefabes.Length);
        randPosition = Random.Range(-15,15);
        Instantiate(prefabes[randPrefabe], new Vector3(30,0,randPosition), new Quaternion(0,-1,0,1));
        yield return new WaitForSeconds(1f);
        randPrefabe = Random.Range(0,prefabes.Length);
        randPosition = Random.Range(-15,15);
        Instantiate(prefabes[randPrefabe], new Vector3(-30,0,randPosition), new Quaternion(0,1,0,1));
        }
     
    }
}
