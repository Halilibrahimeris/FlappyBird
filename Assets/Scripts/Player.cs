using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    #region variables
    public bool _Start;
    public bool UP;
    public bool Pause;
    public int Score;
    public float force;
    int deneme;
    int TimerScore;
    int GravityScore;
    int randomScore;
    #endregion
    #region Texts
    public TextMeshProUGUI Text;
    public TextMeshProUGUI Textv2;
    #endregion
    #region GameObjects
    public GameObject EndGameScreen;
    public GameObject StartButton;
    public GameObject ArrowUp;
    public GameObject ArrowDown;
    #endregion
    #region Audios
    AudioSource _duba;
    public AudioClip JumpSound;
    public AudioClip DeathSound;
    #endregion
    private GameManager gameManager;
    public Rigidbody2D rb2d;
    public Spawner spawner;

    private void Start()
    {
        gameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
        _duba = GetComponent<AudioSource>();
        _duba.clip = JumpSound;
        randomScore = Random.Range(4, 10);
        Debug.Log("Random = " + randomScore);
    }
    void Update()
    {
        if (_Start == false)
        {
            Time.timeScale = 0;
            if (Input.GetMouseButtonDown(0))
            {
                Time.timeScale = 1;
                StartButton.SetActive(false);
                _Start = true;
            }
        }
        if (Pause == false)
        {
            if (UP)
            {
                rb2d.gravityScale = -1.2f;
            }
            else
            {
                rb2d.gravityScale = 1.2f;
            }
            if (Input.GetMouseButtonDown(0))
            {
                if (UP)
                {
                    rb2d.velocity = Vector2.down * force;
                }
                else
                {
                    rb2d.velocity = Vector2.up * force;
                }
                if (_duba.isPlaying != true)
                {
                    _duba.Play();
                }
            }
            if ((TimerScore - 10 == 0) && deneme <= 3)
            {
                TimerScore = 0;
                spawner.SpawnRate -= 0.8f;
                deneme++;
            }
            if(GravityScore - (randomScore-1) == 0)
            {
                if (UP)
                {
                    ArrowDown.SetActive(true);
                }
                else
                {
                    ArrowUp.SetActive(true);
                }
            }
            if(GravityScore - randomScore == 0)
            {
                GravityScore = 0;
                randomScore = Random.Range(4, 10);
                Debug.Log("Random = " + randomScore);
                if (UP)
                {
                    UP = false;
                }
                else
                {
                    UP = true;
                }
            }
        }
    }

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Tubes")
        {
            EndGameScreen.SetActive(true);
            _duba.clip = DeathSound;
            _duba.Play();
            Textv2.gameObject.SetActive(false);
            Text.text = "Score: " + Score.ToString();
            Time.timeScale = 0;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Tube")
        {
            Score += 1;
            TimerScore += 1;
            GravityScore += 1;
            Textv2.text = "Score : " + Score.ToString();
        }
    }

    public void ResetGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public void StopGame()
    {
        Time.timeScale = 0;
        Pause = true;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        Pause = false;
    }
    public void SetActiveFalse()
    {
        gameObject.SetActive(false);
    }
}
