using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PhysicsCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Enter");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Collision Stay");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Collision Exit");
    }

    private void OnTriggerEnter(Collider other)
    {
        //collision�� �ٸ����� �浹 ���� ������ ���� �ȵ����� ����
        //spere collider�� is Trigger �׸� üũ�� �������.
        //Ʈ���Ÿ� �ٵ� �Ѹ� �հ� �������鼭 enter -stay - exit�� �Ҹ���
        //collision�� �ȺҸ�.
        //�̰� ��� ����  (�� �������� ������ �浹�� ������ �Ҷ� ��� ,  �ڵ��� ��������� �׳� �������� ���, ����, �̺�Ʈ)
        Debug.Log("Trigger Enter");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger Stay");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exit");
    }


    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward*3000, out hit))
        {
            if(hit.transform.gameObject.name == "Cube")
            {
                Debug.Log("HIT!!");
            }
        }
        Debug.DrawRay(transform.position, transform.forward*3000, Color.red);
    }
}
