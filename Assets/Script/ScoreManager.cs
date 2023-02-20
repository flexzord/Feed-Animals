using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;

    private int score = 0;
    // Start is called before the first frame update
    private void Awake() {
        instance = this;
    }
    void Start()
    {
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(){
        score+=10;
        scoreText.text = score.ToString();
    }
}
