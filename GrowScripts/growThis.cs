using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace UnityStandardAssets.Utility
{
	public class growThis : MonoBehaviour
	{
		// A multi-purpose script which causes an action to occur when
		// a trigger collider is entered.

		// The game object to affect. If none, the trigger work on this game object
		public GameObject target;
		private GrowScript script;
		public GameObject source;
		public int triggerCount = 1;
		public bool repeatTrigger = false;
		public GameObject flower;

		private void DoActivateTrigger ()
		{
			triggerCount--;

			if (triggerCount == 0 || repeatTrigger) {
				

				if (target != null) {
					script = target.gameObject.GetComponent<GrowScript> ();
					script.growThis (flower);
				}
			}
		}


		private void OnTriggerEnter (Collider other)
		{
			if (other.gameObject.name == "Palm") {
				DoActivateTrigger ();
			}
		}
	}
}
