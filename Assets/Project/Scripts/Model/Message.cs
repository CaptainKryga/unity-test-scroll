using System;
using UnityEngine;

namespace Project.Scripts.Model
{
	[Serializable]
	public class MessageData
	{
		public Types.Trainer CharacterId;
		public string Title;
		public string Message;
		public Sprite Icon;
		public string Date;
		public Color TitleColor;
	}
}