using UnityEngine;

public class Bee : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector3 direcition;
    [SerializeField] Transform targetTransform;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    { 
        targetTransform = GameObject.Find("Sand Pillar").transform;

        transform.LookAt(targetTransform);

        direcition = (targetTransform.position - transform.position).normalized;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direcition * speed * Time.deltaTime, Space.World);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pillar"))
        {
            ObjectPool.Instance.ReturnObject(gameObject);
        }
    }
}
