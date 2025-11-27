using UnityEngine;

public class deathReset : MonoBehaviour
{
    public GameObject thePlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Crossed the Line they should die");
           

        }
    }
}
