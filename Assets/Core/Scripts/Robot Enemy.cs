using StarterAssets;
using UnityEngine;
using UnityEngine.AI;

public class RobotEnemy : MonoBehaviour
{
    [SerializeField] Transform target;

    FirstPersonController Player;
    NavMeshAgent agent;

    void Awake()
    {
        // get the agent from the inspector
        agent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        // get the player from the scene
        Player = FindFirstObjectByType<FirstPersonController>();
        
    }

    void Update()
    {
        // set the destination of the agent to the target
        agent.SetDestination(Player.transform.position);
    }
}
