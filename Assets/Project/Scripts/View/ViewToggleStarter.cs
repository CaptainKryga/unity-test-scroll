using UnityEngine;
using UnityEngine.UI;

namespace Project.Scripts.View
{
	public class ViewToggleStarter : MonoBehaviour
	{
		[SerializeField] private Toggle _toggle;

		private void Start()
		{
			_toggle.isOn = true;

			Destroy(this);
		}
	}
}
