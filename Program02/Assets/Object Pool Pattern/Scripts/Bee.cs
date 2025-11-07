using UnityEngine;

public class Bee : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector3 direcition;
    [SerializeField] Transform targetTransform;



    private void Awake()
    {
        targetTransform = GameObject.Find("Sand Pillar").transform;
    }

    public void SetDirection(Transform createTransform)
    {
        transform.LookAt(targetTransform);

        transform.position = createTransform.position;

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
