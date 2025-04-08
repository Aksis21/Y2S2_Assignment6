using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class RegenHP_AT : ActionTask
	{
		public BBParameter<float> HP;
		public Material attackMat;
		Color matCol;
		float timer = 0f;

		protected override void OnUpdate()
		{
			timer += Time.deltaTime;
			if (timer > 1)
			{
				timer = 0f;
				HP.value += 1;
			}

			matCol = Color.Lerp(Color.white, Color.green, timer);
			attackMat.color = matCol;
		}
	}
}