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
        Agent = GetComponent<NavMeshAgent>(); //지금 컴포넌트를 가지고 와라
    }

    // Update is called once per frame
    void Update()
    {
        Agent.destination = Target.position;
    }
}
