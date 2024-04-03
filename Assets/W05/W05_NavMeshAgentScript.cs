using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class W05_NavMeshAgentScript : MonoBehaviour
{

    public Transform Target;
    NavMeshAgent Agent;

    // Start is called before the first frame update
    void Start()
    {
        Agent = GetComponent<NavMeshAgent>(); //���� ������Ʈ�� ������ �Ͷ�
    }

    // Update is called once per frame
    void Update()
    {
        Agent.destination = Target.position;
    }
}
