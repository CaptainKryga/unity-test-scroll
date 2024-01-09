using UnityEngine;
using UnityEngine.UI;

namespace Project.Scripts.View
{
	[RequireComponent(typeof(Image))]
	public abstract class ViewToggleItem : MonoBehaviour
	{
		private Image _img;
		[SerializeField] private Sprite _spriteOn, _spriteOff;

		private void Awake()
		{
			_img = GetComponent<Image>();
			_img.sprite = _spriteOff;
		}

		public virtual void OnToggle(bool flag)
		{
			_img.sprite = flag ? _spriteOn : _spriteOff;
		}
	}
}
