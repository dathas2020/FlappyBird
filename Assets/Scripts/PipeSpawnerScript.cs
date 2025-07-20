using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    [SerializeField] private GameObject pipe;
    [SerializeField] private float spawnRate = 2.5f;
    private float timer;
    public Vector2 spawnRateRange = new Vector2(4f, 5f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        Spawn();
    }

    void Spawn() {
        spawnRate = RandSpawnrate();
        if (timer < spawnRate) {
            timer += Time.deltaTime;
        } else {
            timer = 0;
            transform.position = RandPosition();
            Instantiate(pipe, transform.position, transform.rotation);
        }
    }

    Vector3 RandPosition() {
        float y = Random.Range(-12, 12);
        Vector3 position = new Vector3 (27, y, 0);
        return position;
    }

    float RandSpawnrate() {
        float rate = Random.Range(spawnRateRange.x, spawnRateRange.y);
        return rate;
    }
}
