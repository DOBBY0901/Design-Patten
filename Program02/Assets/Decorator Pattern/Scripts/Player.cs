using UnityEngine;

public class Player :Debuff
{
    [SerializeField] float speed;
    [SerializeField] float stopDistance = 0.1f;
    [SerializeField] float rotationspeed = 50f;

    [SerializeField] bool isMoving = false;
    [SerializeField] Vector3 targetPostion;
    [SerializeField] RaycastHit rayCasthit;

    [SerializeField] Rigidbody rigidbody;
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
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
        
      
    }

    private void FixedUpdate()
    {
        if (isMoving)
        {
            Move();
        }
    }

    void Move()
    { 
        Vector3 direction = (targetPostion - transform.position);
        
        direction.y = 0;    
        
        float distance = direction.magnitude;

        if(distance < stopDistance) 
        {
            isMoving = false; 
            
            rigidbody.linearVelocity = Vector3.zero;

            return;
        }

        Vector3 newPosition = rigidbody.position + direction.normalized * speed * Time.fixedDeltaTime;

        rigidbody.MovePosition(newPosition);

        Quaternion targetRotation = Quaternion.LookRotation(direction);

        Quaternion smoothRotation = Quaternion.Slerp(rigidbody.rotation, targetRotation, rotationspeed * Time.fixedDeltaTime);

        rigidbody.MoveRotation(smoothRotation);

    }

    public override void Acivate()
    {
        Debug.Log("Player");
    }
}
    