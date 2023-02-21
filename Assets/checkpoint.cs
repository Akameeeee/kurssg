using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    static Vector3 lastCheckpointPosition = Vector3.zero; //������� ���������� ���������
    //��� ��� ��� ����������� �� ����� ������������ �� ���������� ����

    private void Start()
    {
        if (lastCheckpointPosition != Vector3.zero)
        {
            transform.position = lastCheckpointPosition;
            //����� ��������������� ��������� ������ ���� �� "������" ���� �� ���� ��������
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("CheckPoint"))
        {
            lastCheckpointPosition = collision.transform.position;
            //���������� ������� ����� ���������� � ����������
        }
    }
}