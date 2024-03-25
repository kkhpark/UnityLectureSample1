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
        //collision과 다른점은 충돌 힘의 연산이 들어가냐 안들어가냐의 차이
        //spere collider에 is Trigger 항목에 체크를 해줘야함.
        //트리거를 근데 켜면 뚫고 지나가면서 enter -stay - exit가 불리네
        //collision은 안불림.
        //이걸 어따 쓰냐  (비 현실적인 가상의 충돌을 만들어야 할때 사용 ,  자동문 감지라던지 그냥 지나가는 경우, 센서, 이벤트)
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
