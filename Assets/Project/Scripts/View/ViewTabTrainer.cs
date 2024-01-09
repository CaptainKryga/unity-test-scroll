using UnityEngine;

namespace Project.Scripts.View
{
	public class ViewTabTrainer : MonoBehaviour
	{
		[SerializeField] private RectTransform _content;
		private void OnEnable()
		{
			ManagerApp.Instance.Listen(Types.App.ViewCreateMessage, FuncViewCreateMessage);
		}

		private void OnDisable()
		{
			ManagerApp.Instance.UnListen(Types.App.ViewCreateMessage, FuncViewCreateMessage);
		}

		private void FuncViewCreateMessage(object obj)
		{
			for (int x = 0; x < _content.childCount; x++)
				Destroy(_content.GetChild(x).gameObject);
			
			ViewMessage[] vms = (ViewMessage[]) obj;

			for (int x = 0; x < vms.Length; x++)
			{
				vms[x].Setup(_content);
			}
		}
	}
}