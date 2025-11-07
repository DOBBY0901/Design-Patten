using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float enemydead;
 
    bool score = false;

    void Start()
    {
        
    }

   
    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;

        if(transform.position.y < enemydead)
        {
            score = true;

            Game.Instance.AddScore(1);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Game.Instance.DamegePlayer(1);
            Destroy (gameObject);

        }

    }
}
