namespace Project.Scripts.View
{
	public class ViewTab : ViewToggleItem
	{
		public override void OnToggle(bool flag)
		{
			base.OnToggle(flag);
			
			// if (flag)
			// 	ManagerApp.Instance.Push(Types.App.SwitchTab, null);
		}
	}
}