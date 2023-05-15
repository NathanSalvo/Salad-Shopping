/**
 * Saves player relevant informtaion between scenes
 */
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


    // used to restart the game
    public void Restart() {
        // reset values
        score = 0;
        lives = 3;
        level = 1;
        // load the set level
        SceneManager.LoadScene("Level" + level);
    }
}

