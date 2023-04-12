using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    
    [SerializeField] NavMeshAgent agent;
    [SerializeField] Transform targetPlayer;
    
    private void Update()
    {
        if(Vector3.Distance(targetPlayer.position, transform.position) < 1000)
        {
            agent.destination = targetPlayer.position;
        }
    }
   
   
}
