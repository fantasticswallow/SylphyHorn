﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetroTrilithon.Serialization;

namespace SylphyHorn.Serialization
{
	public class GeneralSettings : SettingsHost
	{
		private readonly ISerializationProvider _provider;

		public GeneralSettings(ISerializationProvider provider)
		{
			this._provider = provider;
		}

		public SerializableProperty<bool> LoopDesktop => this.Cache(key => new SerializableProperty<bool>(key, this._provider));

		public SerializableProperty<bool> NotificationWhenSwitchedDesktop => this.Cache(key => new SerializableProperty<bool>(key, this._provider, true));

		public SerializableProperty<int> NotificationDuration => this.Cache(key => new SerializableProperty<int>(key, this._provider, 2500));

		public SerializableProperty<bool> OverrideWindowsDefaultKeyCombination => this.Cache(key => new SerializableProperty<bool>(key, this._provider, false));

		public SerializableProperty<bool> SuspendKeyDetection => this.Cache(key => new SerializableProperty<bool>(key, this._provider));

		public SerializableProperty<string> DesktopBackgroundFolderPath  => this.Cache(key => new SerializableProperty<string>(key, this._provider));
	}
}
