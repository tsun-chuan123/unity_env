using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MetaProRotation : MonoBehaviour
{
    public float moveSpeed = 5f; // ����e�Ჾ�ʳt��
    public float rotationSpeed = 100f; // �������t��
    private Vector2 moveInput; // �x�s�n�쪺��J��
    // �o�Ӥ�k�N�|�b�n�즳��J�ɳQ�ե�
    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>(); // ����n�쪺�G����J
        Debug.Log("OnMove called with input: " + moveInput); // �ˬd��k�O�_�Q�ե�
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �e�Ჾ�ʡG�ϥηn�쪺 Y �b��J�ӱ����e��
        float moveAmount = moveInput.y * moveSpeed * Time.deltaTime;
        transform.Translate(0, 0, moveAmount);

        // ���k����G�ϥηn�쪺 X �b��J�ӱ��ફ��
        float rotationAmount = moveInput.x * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotationAmount, 0);

    }
}
