using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRigidBody;
    private float minSpeed = 12;
    private float maxSpeed = 16;
    private float maxTorque = 10;
    private float xRange = 4;
    private float ySpawnPos = -6;

    // Start is called before the first frame update
    void Start()
    {
        targetRigidBody = GetComponent<Rigidbody>();
        targetRigidBody.AddForce(RandomForce(), ForceMode.Impulse);
        targetRigidBody.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawnPos();
    }

    private Vector3 RandomForce() => Vector3.up * Random.Range(minSpeed, maxSpeed);

    private float RandomTorque() => Random.Range(-maxTorque, maxTorque);

    private Vector3 RandomSpawnPos() => new Vector3(Random.Range(-xRange, xRange), -ySpawnPos);

    private void OnMouseDown() 
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}