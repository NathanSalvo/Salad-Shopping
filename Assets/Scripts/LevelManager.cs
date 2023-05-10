using UnityEngine;
using UnityEngine.SceneManagement;

public class DataManager : MonoBehaviour
{
    // static reference
    public static DataManager instance;

    // Current score
    public int score;
    // Current lives
    public int lives;
    // Current health
    public int health;

    // the current level
    public int level = 1;
    // total level
    public int totalLevels = 7;


    // called when the script is started
    void Awake ()
    {
        if(instance == null) {
            instance = this;
        } else {
            Destroy (gameObject);
        }
        DontDestroyOnLoad(instance);
    }

    // Loads the next level
    public void NextLevel () {
        if (level == totalLevels) {
            // show end of game
            // SceneManager.LoadScene("Victory")
        } else {
            // increase the stored level and load
            level = level + 1;
            SceneManager.LoadScene("Level" + level);
        }
    }

    // Reloads the current level
    public void ReloadLevel () {
        SceneManager.LoadScene("Level" + level);
    }

    // used to restart the game
    public void Restart() {
        // reset values
        score = 0;
        health = 3;
        level = 1;
        // load the set level
        SceneManager.LoadScene("Level" + level);
           // used when a player hits a trigger collider

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "LevelEnd") {
            // move to the next level
            Destroy(other.gameObject);
            Invoke("NextLevelAfterDelay", 0.2f);
            } else if (other.gameObject.tag == "GameController") {
            // player has fallen off the screen
            Level.instance.HitBaddie();
            }
    }

    // used to load the next level after a short delay.
    void NextLevelAfterDelay() {
        Level.instance.NextLevel();
    }
    }
}  