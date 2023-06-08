using UnityEngine;

public class Generate : MonoBehaviour {

    public GameObject obstacles;
//spawns baby
    void Start() {
	InvokeRepeating("CreateObstacle", 10.0f, 7f);
    }

    void CreateObstacle() {
	Instantiate(obstacles);
    }
} 