using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class AttackPlayer_AT : ActionTask
	{
		public BBParameter<bool> seePlayer;
		public BBParameter<bool> targetPlayer;
		public BBParameter<float> timeToForget;
		public BBParameter<GameObject> player;
		public float forgetTimer = 0f;

		NavMeshAgent navAgent;

		protected override string OnInit()
		{
			navAgent = agent.GetComponent<NavMeshAgent>();
			return null;
		}

		protected override void OnUpdate()
		{
			//If the support can no longer see the player, begin counting down to forgetting them.
			if (!seePlayer.value)
				forgetTimer += Time.deltaTime;
			else forgetTimer = 0f;

			//Stop targeting the player if enough time has passed.
			if (forgetTimer > timeToForget.value)
				targetPlayer.value = false;

			navAgent.SetDestination(player.value.transform.position);
		}
	}
}