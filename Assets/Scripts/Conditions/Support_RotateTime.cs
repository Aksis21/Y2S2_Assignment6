using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {

	public class Support_RotateTime : ConditionTask
	{
		public float timeToRotate;
		public float rotateTime = 0f;

        protected override bool OnCheck()
		{
            rotateTime = Random.Range(1, 3);
			timeToRotate += Time.deltaTime;
			
			if (timeToRotate > rotateTime)
			{
				timeToRotate = 0f;
				return true;
			}
			else return false;
		}
	}
}