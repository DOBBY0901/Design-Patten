using UnityEngine;

public class Bee : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector3 direcition;
    [SerializeField] Transform targetTransform;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        targetTransform = GameObject.Find("Sand Pillar").transform;
        
        direcition =transform.position - targetTransform.position;

        transform.LookAt(direcition);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direcition * speed * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
