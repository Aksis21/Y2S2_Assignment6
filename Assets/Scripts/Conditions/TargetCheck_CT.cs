using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {

	public class TargetCheck_CT : ConditionTask {

		//Check if the support is targeting the player... somehow?
		public BBParameter<GameObject> support;
		Blackboard supportBoard;

		protected override string OnInit()
		{
			return null;
		}

		//Called whenever the condition gets enabled.
		protected override void OnEnable() {
			
		}

		//Called whenever the condition gets disabled.
		protected override void OnDisable() {
			
		}

		//Called once per frame while the condition is active.
		//Return whether the condition is success or failure.
		protected override bool OnCheck() {
			return true;
		}
	}
}