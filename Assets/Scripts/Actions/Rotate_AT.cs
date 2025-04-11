using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class Rotate_AT : ActionTask
	{
		public BBParameter<float> targetAngle;
		Quaternion currentRot;
		Quaternion targetRot;

		float time;
		float timeToNext;

		protected override void OnExecute()
		{
			currentRot = agent.transform.rotation;
			targetRot = Quaternion.Euler(0, targetAngle.value, 0);
			time = 0f;
			timeToNext = Random.Range(1f, 2f);
		}

		protected override void OnUpdate()
		{
			if (time > 1f + timeToNext) EndAction(true);
			time += Time.deltaTime;
			agent.transform.rotation = Quaternion.Slerp(currentRot, targetRot, time);
		}
	}
}