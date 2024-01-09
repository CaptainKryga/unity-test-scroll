using UnityEngine;

namespace Sub
{
	public class QSettings : MonoBehaviour
	{
		private void Start()
		{
			QualitySettings.vSyncCount = 1;
			Application.targetFrameRate = 60;
		}
	}
}
