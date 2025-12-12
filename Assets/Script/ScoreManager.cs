using UnityEngine;


public class ScoreManager : MonoBehaviour
{
    
    [SerializeField] private int _currentScore = 0;

    
    public static ScoreManager Instance { get; private set; }

    private void Awake()
    {
        
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    
    public void AddScore(int value)
    {
        //Debug.Log($"Score: {_currentScore}");
        _currentScore += value;
        UpdateUI();
    }
    private void UpdateUI() 
    {
        if (UImanager.Instance != null)
        {
            UImanager.Instance.UpdateScoreDisplay(_currentScore);
        }
    }

    public int GetCurrentScore()
    {
        return _currentScore;
    }

    
    public void ResetScore()
    {
        _currentScore = 0;
    }
}
