using UnityEngine;

namespace Project.Scripts.View
{
	public class ViewTrainer : ViewToggleItem
	{
		[SerializeField] private Types.Trainer type;
		
		public override void OnToggle(bool flag)
		{
			base.OnToggle(flag);
			
			ManagerApp.Instance.Push(Types.App.SwitchTrainer, flag ? type : Types.Trainer.None);
		}
	}
}