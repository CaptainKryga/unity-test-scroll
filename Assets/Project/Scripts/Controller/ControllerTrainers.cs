using System;
using System.Collections.Generic;
using Project.Scripts.Model;
using Project.Scripts.View;
using UnityEngine;

namespace Project.Scripts.Controller
{
	public class ControllerTrainers : MonoBehaviour
	{
		[SerializeField] private Database _database;
		[SerializeField] private ViewMessage _prefab;

		private void OnEnable()
		{
			ManagerApp.Instance.Listen(Types.App.SwitchTrainer, FuncSwitchTrainer);
		}

		private void OnDisable()
		{
			ManagerApp.Instance.UnListen(Types.App.SwitchTrainer, FuncSwitchTrainer);
		}

		private void Start()
		{
			ManagerApp.Instance.Push(Types.App.SwitchTrainer, Types.Trainer.None);
		}

		private void FuncSwitchTrainer(object obj)
		{
			Types.Trainer trainer = (Types.Trainer) obj;

			List<ViewMessage> list = new List<ViewMessage>();
			for (int x = 0; x < _database.messages.Length; x++)
			{
				DateTime tempDate = DateTime.ParseExact(_database.messages[x].Date, "dd.MM.yyyy",
					System.Globalization.CultureInfo.InvariantCulture);

				if ((_database.messages[x].CharacterId == trainer || trainer == Types.Trainer.None) &&
					DateTime.Now >= tempDate)
				{
					ViewMessage vm = Instantiate(_prefab);
					vm.Setup(_database.messages[x]);
					list.Add(vm);
					vm.name = tempDate.ToString("yyyyMMdd");
				}
			}
			
			list.Sort((x, y) => String.CompareOrdinal(y.name, x.name));

			ManagerApp.Instance.Push(Types.App.ViewCreateMessage, list.ToArray());
		}
	}
}
