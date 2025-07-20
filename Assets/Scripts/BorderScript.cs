using UnityEngine;

public class BorderScript : MonoBehaviour
{

    public LogicScript logic;
    public BirdScript bird;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
        bird = GameObject.FindGameObjectWithTag("bird").GetComponent <BirdScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.layer == 3) {
            logic.gameOver();
            bird.birdIsAlive = false;
        }
    }
}
