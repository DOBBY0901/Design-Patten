using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float stopDistance = 0.1f;

    [SerializeField] bool isMonving = false;
    [SerializeField] Vector3 targetPostion;
    [SerializeField] RaycastHit rayCasthit;

    private void Start()
    {
        targetPostion = transform.position;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out rayCasthit))
            {
                targetPostion = rayCasthit.point;

                isMonving = true;
            }

            
        }
        
        if (isMonving)
        {
            Move();
        }
    }

  

   void Move()
    { 
        Vector3 direction = (targetPostion - transform.position);

        float distance = Vector3.Distance(transform.position, targetPostion);

        transform.position += direction * speed * Time.deltaTime;

        if(distance < stopDistance) 
        {
            isMonving = true;    
        }
    }

}
    