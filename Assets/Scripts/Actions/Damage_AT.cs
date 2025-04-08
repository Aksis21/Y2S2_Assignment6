using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TMPro;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class Damage_AT : ActionTask
	{
		public BBParameter<GameObject> player;
		public BBParameter<GameObject> support;
		public GameObject attackLine;
		public BBParameter<float> HP;
		public Material lineMat;
		public Material attackMat;
		public GameObject textObj;
		public TextMeshProUGUI text;
		float damageTimer = 0f;
		float attackDamageTimer = float.PositiveInfinity;
		Vector3 playerDistance;
		Vector3 supportDistance;
		Color lineCol;
		Color attackCol;
		Player playerScript;

        protected override string OnInit()
        {
			playerScript = player.value.GetComponent<Player>();
			attackMat.color = Color.white;
            return null;
        }

        protected override void OnUpdate()
		{
			if (HP.value == 0)
			{
                agent.gameObject.SetActive(false);
				attackLine.SetActive(false);
				text.text = "Success!";
				textObj.SetActive(true);
				Time.timeScale = 0f;
            }

			playerDistance = player.value.transform.position - agent.transform.position;
			supportDistance = support.value.transform.position - agent.transform.position;

			attackDamageTimer += Time.deltaTime;
            attackCol = Color.Lerp(Color.red, Color.white, attackDamageTimer);
			if (attackCol != Color.white)
				attackMat.color = attackCol;

            if (playerDistance.magnitude < 7.5f)
			{
				damageTimer += Time.deltaTime;
				lineCol = Color.Lerp(Color.white, Color.red, damageTimer);
				lineMat.color = lineCol;
				if (damageTimer >= 1)
				{
					playerScript.takeDamage();
					if (supportDistance.magnitude > 10.5f) HP.value -= 1;
					damageTimer = 0f;
                    if (supportDistance.magnitude > 10.5f) attackDamageTimer = 0f;
				}
			}
			else damageTimer = 0f;
		}
	}
}