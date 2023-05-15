using UnityEngine;
using TMPro;

// this class manages the level
public class Level : MonoBehaviour
{
    public static Level instance;
    
    public TMP_Text scoreDisplay;

    // how many points have been collected in this level
    private int pointsCollected;

    // Start is called before the first frame update
    void Start()
    {
        scoreDisplay.text = "Score: " + DataManager.instance.score;
        pointsCollected = 0;
    }

    // make sure this is the only level manager
    void Awake () {
        if(instance == null) {
            instance = this;
        } else {
            Destroy (gameObject);
        }
    }

    // used to increase the current score
    public void IncreaseScore(int points) {
        // increase the current points collected
        pointsCollected = pointsCollected + points;
        // display the total score
        scoreDisplay.text = "Score: " + (DataManager.instance.score + pointsCollected);
    }

    // used when the player hits a baddie
    public void HitBaddie () {
        // decrease the lives
        DataManager.instance.lives = DataManager.instance.lives - 1;
        if (DataManager.instance.lives == 0) {
            // restart the game when there are no more lives
            DataManager.instance.Restart();
        } else {
            // reload the current level (points collected are lost)
            DataManager.instance.ReloadLevel();
        }
    }

    // used to move to the next level
    public void NextLevel() {
        // increase the saved score in the DataManager by the points collected
        DataManager.instance.score = DataManager.instance.score + pointsCollected;
        // get the DataManager to move to the next level
        DataManager.instance.NextLevel();
    }

}