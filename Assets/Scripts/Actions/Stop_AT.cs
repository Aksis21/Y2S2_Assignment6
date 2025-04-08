using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class Stop_AT : ActionTask
	{
		NavMeshAgent navAgent;

		protected override string OnInit()
		{
			navAgent = agent.GetComponent<NavMeshAgent>();
			return null;
		}

		protected override void OnExecute()
		{
			navAgent.SetDestination(agent.transform.position);
			EndAction(true);
		}
	}
}