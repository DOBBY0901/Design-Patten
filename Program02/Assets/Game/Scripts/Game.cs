using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public static Game Instance { get; private set; }

    [SerializeField] Text scoreText;
    [SerializeField] Text heartText;
    [SerializeField] GameObject gameoverPanel;

    [SerializeField] int score = 0;

    [SerializeField] int startheart = 3;
    

    bool isGameover = false;
    int heart;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        score = 0;
        heart = startheart;
        isGameover = false;
       
        UpdateScoreUI();
        UpdateHeartUI();

        if(gameoverPanel != null)
        {
           gameoverPanel.SetActive(false);
        }

    }

    public void AddScore(int scorecount)
    {
        score += scorecount;
        UpdateScoreUI();
    }
    
    public void DamegePlayer(int damage = 1)
    {
        heart -= damage;
        UpdateHeartUI();

        if (heart <= 0)
        {
            GameOver();
            
        }
    }

    void GameOver()
    {
        isGameover = true;
        Time.timeScale = 0;
       
        if (gameoverPanel != null)
        {
            gameoverPanel.SetActive(true);
        }

    }

    void UpdateScoreUI()
    {
       scoreText.text = "Á¡¼ö : " + score;
    }

    void UpdateHeartUI()
    {
        heartText.text = "¸ñ¼û : " + heart;
    }

   
}
