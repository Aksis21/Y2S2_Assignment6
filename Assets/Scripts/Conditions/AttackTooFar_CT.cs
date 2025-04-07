using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {

	public class AttackTooFar_CT : ConditionTask
	{
		public BBParameter<GameObject> support;
		Vector3 distance;

		protected override bool OnCheck()
		{
			distance = support.value.transform.position - agent.transform.position;

			if (distance.magnitude < 10.5f) return false;
			else return true;
		}
	}
}