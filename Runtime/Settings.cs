using System.Collections.Generic;
using UnityEngine;

using LogType = Padoru.Diagnostics.LogType;

namespace Padoru.Core
{
	[CreateAssetMenu(menuName = "Padoru/Settings", fileName = "PadoruSettings")]
	public class Settings : ScriptableObject
	{
		[Header("Project initialization")]
		public string ProjectContextPrefabName = "ProjectContext";
		[Tooltip("Only the scenes specified in the list will trigger the initialization of the framework")]
		public List<string> scenes;

		[Header("Logging")]
		public LogType LogType = LogType.Info;
		public LogType StacktraceLogType = LogType.Info;
	}
}
