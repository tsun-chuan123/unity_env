using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCircularMover : MonoBehaviour
{
    public Vector3 rotationCenter = new Vector3(0, 0, 2.93f); // 旋轉中心
    public float radius = 5f; // 距離旋轉中心的半徑
    public float rotationSpeed = 1f; // 旋轉速度

    private float angle = 0f; // 用於計算圓周運動的角度

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 每一幀增加角度來實現旋轉
        angle += rotationSpeed * Time.deltaTime;

        // 計算新的 X 和 Z 座標
        float x = rotationCenter.x + Mathf.Cos(angle) * radius;
        float z = rotationCenter.z + Mathf.Sin(angle) * radius;

        // 設置 Cube 的位置，使其繞著指定的點旋轉
        transform.position = new Vector3(x, transform.position.y, z);

        // 讓 Cube 始終面向旋轉中心
        transform.LookAt(rotationCenter);

    }
}
