using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    [SerializeField] private GameObject sphere;
    [SerializeField] private GameObject capsule;

    [SerializeField] private SphereCollider sphere_collider;
    [SerializeField] private Camera cam;
    [SerializeField] private Rigidbody rig;
    // Start is called before the first frame update
    private void Start()
    {
        print("��v���`�� : " + Camera.main.depth);
        print("�y��I�����b�| : " + sphere_collider.radius);
        cam.backgroundColor = Color.green;
        capsule.transform.localScale = new Vector3(3, 2, 1);
    }

    // Update is called once per frame
    private void Update()
    {
        cube.transform.LookAt(sphere.transform.position);
        sphere.transform.Rotate(0, 3, 0);
    }
    private void FixedUpdate()
    {
        rig.AddForce(new Vector3(0, 30, 0));
    }
}
