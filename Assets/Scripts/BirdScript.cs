using UnityEditor;
using UnityEngine;
public class BirdScript : MonoBehaviour
{
    [SerializeField] private float flapStrength = 15;
    [SerializeField] private Rigidbody2D birdRigidBody;
    public LogicScript logic;
    private bool birdIsAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (birdIsAlive) {
            if (Input.GetKeyDown(KeyCode.Space) == true) {
                birdRigidBody.linearVelocity = Vector2.up * flapStrength;
            }
        }
        
    }

    public void OnCollisionEnter2D(Collision2D collision) {
        logic.gameOver();
        birdIsAlive = false;
    }
}

