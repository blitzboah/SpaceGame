using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    float score;
    public Text scoreText;
    public Text highScore;
    GameObject player;
    public GameObject RH;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        highScore.text = PlayerPrefs.GetFloat("HighScore").ToString("0");
    }

    void Update()
    {
        
        if(player == true)
        {
            score += 1f * Time.deltaTime;
            scoreText.text = score.ToString("0");
        }
        
        if(player == false)
        {
            RH.SetActive(true);
        }

        if(score > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", score);
            highScore.text = score.ToString("0");
        }



    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Home()
    {
        SceneManager.LoadScene("Menu");
    }
}
