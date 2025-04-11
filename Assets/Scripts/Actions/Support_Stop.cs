using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class Support_Stop : ActionTask
	{
		public BBParameter<float> rotateAngle;
        NavMeshAgent navAgent;
        
		protected override string OnInit()
        {
            navAgent = agent.GetComponent<NavMeshAgent>();
            return null;
        }

		protected override void OnExecute()
		{
			navAgent.SetDestination(agent.transform.position);
			rotateAngle.value = Random.Range(0f, 360f);
		}
	}
}