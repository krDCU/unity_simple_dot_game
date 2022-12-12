using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody; // �̵��� ����� ������ �ٵ� ������Ʈ
    public float speed = 8f; // �̵��ӷ�

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }


    void Update()
    {
        //������ , �������� �Է� ���� �����Ͽ� ����
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //���� �̵��ӵ��� �Է°��� �̵��ӷ��� ����� ����
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        //Vector 3 �ӵ��� (xSpeed, 0f, zSpeed) �� ����
        Vector3 newVelocity = new Vector3 (xSpeed, 0f, zSpeed);

        // ������ٵ��� �ӵ��� newVelocity �Ҵ�
        playerRigidbody.velocity = newVelocity;
    }

    public void Die()
    {
        //���� ������Ʈ ��Ȱ��ȭ
        gameObject.SetActive(false);
    }
}
