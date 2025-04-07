using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace NodeCanvas.Tasks.Conditions {

	public class AttackTarget_CT : ConditionTask
	{
		public BBParameter<bool> seePlayer;
		public BBParameter<bool> targetPlayer;

		protected override bool OnCheck()
		{
			if (seePlayer.value || targetPlayer.value)
			{
				targetPlayer.value = true;
				return true;
			}
			else return false;
		}
	}
}