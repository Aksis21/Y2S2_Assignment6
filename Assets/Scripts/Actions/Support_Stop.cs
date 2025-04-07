using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class Support_Stop : ActionTask
	{
        NavMeshAgent navAgent;
		float direction = 0;
        
		protected override string OnInit()
        {
            navAgent = agent.GetComponent<NavMeshAgent>();
            return null;
        }
		protected override void OnExecute()
		{
			navAgent.SetDestination(agent.transform.position);

			direction = Random.Range(0f, 4f);
			agent.transform.eulerAngles = new Vector3(0, 0 + 90 * direction, 0);
		}
	}
}