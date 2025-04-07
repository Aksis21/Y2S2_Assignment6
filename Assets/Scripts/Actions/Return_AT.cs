using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class Return_AT : ActionTask
	{
		public BBParameter<GameObject> support;
		NavMeshAgent navAgent;

		protected override string OnInit()
		{
			navAgent = agent.GetComponent<NavMeshAgent>();
			return null;
		}

		protected override void OnExecute()
		{
			navAgent.SetDestination(support.value.transform.position);
		}
	}
}