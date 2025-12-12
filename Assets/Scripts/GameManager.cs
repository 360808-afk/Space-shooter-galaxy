using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    private bool _isGameOver;

    [SerializeField]
    private GameManager _gameManager;


    public void GameOver()
    {
        _isGameOver = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && _isGameOver == true)
        {
            SceneManager.LoadScene("Game");
        }
    }

    void Start()
    {
    _gameManager = GameObject.Find("Game_Manager").GetComponent<GameManager>();
	    if (_gameManager == null)
        	{		
                Debug.LogError("GameManager is Null.");
        	}
    }

    void GameOverSequence()
    {
        _gameManager.GameOver();
    }

}
