using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MetaProRotation : MonoBehaviour
{
    public float moveSpeed = 5f; // 控制前後移動速度
    public float rotationSpeed = 100f; // 控制旋轉速度
    private Vector2 moveInput; // 儲存搖桿的輸入值
    // 這個方法將會在搖桿有輸入時被調用
    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>(); // 獲取搖桿的二維輸入
        Debug.Log("OnMove called with input: " + moveInput); // 檢查方法是否被調用
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 前後移動：使用搖桿的 Y 軸輸入來控制物體前後
        float moveAmount = moveInput.y * moveSpeed * Time.deltaTime;
        transform.Translate(0, 0, moveAmount);

        // 左右旋轉：使用搖桿的 X 軸輸入來旋轉物體
        float rotationAmount = moveInput.x * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotationAmount, 0);

    }
}
