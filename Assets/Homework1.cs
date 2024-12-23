using System;
using Unity.VisualScripting;
using UnityEngine;

public class Homework1 : MonoBehaviour
{
    public Vector3[] vectors;
    public float speed;
    private Vector3 target;
    private int targetIndex;
    private int lenght;
    private bool forward;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = vectors[0];
        targetIndex = 0;
        target = vectors[targetIndex];
        lenght = vectors.Length;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        if (target == transform.position)
        {
            if (forward)
            {
                targetIndex++;
                if (targetIndex >= lenght) forward = false;
            }
            else
            {
                targetIndex--;
                if (targetIndex <= 0) forward = true;
            }
            target = vectors[targetIndex];
            transform.LookAt(target);
        }
    }
}
