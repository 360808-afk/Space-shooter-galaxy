using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UIManager : MonoBehaviour
{

    [SerializeField]
    private Text _scoreText;

    [SerializeField]
    private Image _LivesImg;

    [SerializeField]
    private Sprite[] _liveSprites;

    [SerializeField]
    private TextMeshProUGUI _gameOverText;

    [SerializeField]
	private TextMeshProUGUI _restartLevel;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       _scoreText.text = "Score: " + 0;
    }

    public void UpdateScore(int playerScore)
    {
        _scoreText.text = "Score: " + playerScore.ToString();
    }
    
    public void UpdateLives(int currentLives)
    {
        _LivesImg.sprite = _liveSprites[currentLives];
        _gameOverText.gameObject.SetActive(false);
        if (currentLives == 0)
        {            
            _gameOverText.gameObject.SetActive(true);
        }
    }
}
