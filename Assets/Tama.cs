using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tama : MonoBehaviour
{

    private GameObject gameoverText;
    private GameObject scoreText;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOver");
        this.scoreText = GameObject.Find("ScoreText");

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "TamaTag")
        {

    
            Destroy(this.gameObject);

            this.gameoverText.GetComponent<Text>().text = "Game Over";

        }else if (collision.gameObject.tag == "DenkiBallTag")
        {
            this.score += 200;
            this.scoreText.GetComponent<Text>().text = "Score " + this.score + "pt";
        }else if (collision.gameObject.tag == "BaTag")
        {
            this.score += 50;
            this.scoreText.GetComponent<Text>().text = "Score " + this.score + "pt";

        }else if (collision.gameObject.tag=="RedBallTag") {
            this.score += 500;
            this.scoreText.GetComponent<Text>().text = "Score " + this.score + "pt";

        }
    }

}