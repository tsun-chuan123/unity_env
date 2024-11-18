using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCircularMover : MonoBehaviour
{
    public Vector3 rotationCenter = new Vector3(0, 0, 2.93f); // ���त��
    public float radius = 5f; // �Z�����त�ߪ��b�|
    public float rotationSpeed = 1f; // ����t��

    private float angle = 0f; // �Ω�p���P�B�ʪ�����

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �C�@�V�W�[���רӹ�{����
        angle += rotationSpeed * Time.deltaTime;

        // �p��s�� X �M Z �y��
        float x = rotationCenter.x + Mathf.Cos(angle) * radius;
        float z = rotationCenter.z + Mathf.Sin(angle) * radius;

        // �]�m Cube ����m�A�Ϩ�¶�۫��w���I����
        transform.position = new Vector3(x, transform.position.y, z);

        // �� Cube �l�׭��V���त��
        transform.LookAt(rotationCenter);

    }
}
