/* Copyright(c) 2018, Olaf Kober
 * Licensed under GNU Lesser General Public License v3.0 (LPGL-3.0).
 * https://github.com/Amarok79/Amarok.Contracts
 */

using System;
using NCrunch.Framework;
using NFluent;
using NUnit.Framework;


namespace Amarok.Contracts
{
	public partial class Test_Verify
	{
		[Test, Isolated]
		public void Configurable_OffByDefault()
		{
			if (NCrunchEnvironment.NCrunchIsResident())
			{
				Check.That(Verify.Configurable.IsEnabled)
					.IsFalse();
			}
			else
			{
				Assert.Ignore("Does work only with NCrunch and process isolation.");
			}
		}

		[Test, Isolated]
		public void Configurable_OnIfEnvVarDefined()
		{
			if (NCrunchEnvironment.NCrunchIsResident())
			{
				Environment.SetEnvironmentVariable("AMAROK_CONTRACTS_ENABLED", "1");

				Check.That(Verify.Configurable.IsEnabled)
					.IsTrue();
			}
			else
			{
				Assert.Ignore("Does work only with NCrunch and process isolation.");
			}
		}

		[Test, Isolated]
		public void Configurable_CanBeSwitchedOnOff()
		{
			if (NCrunchEnvironment.NCrunchIsResident())
			{
				Check.That(Verify.Configurable.IsEnabled)
					.IsFalse();

				Verify.Configurable.IsEnabled = true;

				Check.That(Verify.Configurable.IsEnabled)
					.IsTrue();

				Verify.Configurable.IsEnabled = false;

				Check.That(Verify.Configurable.IsEnabled)
					.IsFalse();
			}
			else
			{
				Assert.Ignore("Does work only with NCrunch and process isolation.");
			}
		}

		[Test, Isolated]
		public void Configurable_CanBeSwitchedOnOff_EvenThoughEnvVarDefined()
		{
			if (NCrunchEnvironment.NCrunchIsResident())
			{
				Environment.SetEnvironmentVariable("AMAROK_CONTRACTS_ENABLED", "1");

				Check.That(Verify.Configurable.IsEnabled)
					.IsTrue();

				Verify.Configurable.IsEnabled = false;

				Check.That(Verify.Configurable.IsEnabled)
					.IsFalse();

				Verify.Configurable.IsEnabled = true;

				Check.That(Verify.Configurable.IsEnabled)
					.IsTrue();
			}
			else
			{
				Assert.Ignore("Does work only with NCrunch and process isolation.");
			}
		}
	}
}
