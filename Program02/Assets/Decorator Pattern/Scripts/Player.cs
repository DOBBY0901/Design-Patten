using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float stopDistance = 0.1f;
    [SerializeField] float rotationspeed = 50f;

    [SerializeField] bool isMoving = false;
    [SerializeField] Vector3 targetPostion;
    [SerializeField] RaycastHit rayCasthit;

    private void Awake()
    {
        
    }
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

                isMoving = true;
            }

            
        }
        
        if (isMoving)
        {
            Move();
        }
    }

  

   void Move()
    { 
        Vector3 direction = (targetPostion - transform.position);
        
        direction.y = 0;    
        
        float distance = Vector3.Distance(transform.position, targetPostion);

        transform.position += direction * speed * Time.deltaTime;

        if(distance < stopDistance) 
        {
            isMoving = false; 
            
            
        }

    }

    
}
    