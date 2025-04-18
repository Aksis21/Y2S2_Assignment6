using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class Support_Approach : ActionTask
	{
		public BBParameter<bool> targetPlayer;
		public BBParameter<GameObject> player;
		NavMeshAgent navAgent;

		protected override string OnInit()
		{
			navAgent = agent.GetComponent<NavMeshAgent>();
			return null;
		}

		protected override void OnUpdate()
		{
			targetPlayer.value = true;
			navAgent.SetDestination(player.value.transform.position);
		}
	}
}