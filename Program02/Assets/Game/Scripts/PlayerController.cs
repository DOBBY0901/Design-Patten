using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float movelimit;

 
    void Update()
    {
        float playerinput = Input.GetAxisRaw("Horizontal");

        Vector3 playermove = new Vector3(playerinput, 0, 0) * speed * Time.deltaTime;

        transform.position += playermove;

        if (transform.position.x > movelimit)
        {
            transform.position = new Vector3(movelimit, transform.position.y, transform.position.z);
        }

        else if (transform.position.x < -movelimit)
        {
            transform.position = new Vector3(-movelimit, transform.position.y, transform.position.z);
        }

    }
}
