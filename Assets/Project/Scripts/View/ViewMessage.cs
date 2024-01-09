using Project.Scripts.Model;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Project.Scripts.View
{
	public class ViewMessage : MonoBehaviour
	{
		[SerializeField] private TMP_Text _title;
		[SerializeField] private TMP_Text _message;
		[SerializeField] private Image _img;
		[SerializeField] private TMP_Text _date;
		
		public void Setup(MessageData data)
		{
			_title.text = data.Title;
			_title.color = data.TitleColor;
			_message.text = data.Message;
			_img.sprite = data.Icon;
			_date.text = data.Date.Split('.')[0] + "." + data.Date.Split('.')[1];
		}
		
		public void Setup(RectTransform parent)
		{
			transform.SetParent(parent);
		}
	}
}