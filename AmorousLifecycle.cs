using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Xna.Framework;

public static class AmorousLifecycle
{
	private const int _e2Ucgs0TphHTAenda7BAmHbfNPD = 4096;

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SetDefaultDllDirectories(int int_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern void AddDllDirectory(string string_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SetDllDirectory(string string_0);

	[STAThread]
	public static void _PijxDMohBfV8yAM5NbVyQM599kM(string[] args)
	{
		AppDomain.CurrentDomain.UnhandledException += delegate(object sender, UnhandledExceptionEventArgs e)
		{
			_mxSbmCQQPRHc7t2A2pm8HsbyvqfA(e.ExceptionObject as Exception);
			Environment.Exit(0);
		};
		Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
		Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
		Logger.Initialize();
		try
		{
			SetDefaultDllDirectories(_e2Ucgs0TphHTAenda7BAmHbfNPD);
			AddDllDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Environment.Is64BitProcess ? "x64" : "x86"));
		}
		catch
		{
			SetDllDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Environment.Is64BitProcess ? "x64" : "x86"));
		}
		FNALoggerEXT.LogInfo = delegate(string string_0)
		{
			Logger.Log(string_0);
		};
		FNALoggerEXT.LogWarn = delegate(string string_0)
		{
			Logger.Warning(string_0);
		};
		FNALoggerEXT.LogError = delegate(string string_0)
		{
			Logger.Error(string_0);
		};
		Environment.SetEnvironmentVariable("FNA_OPENGL_DISABLE_LATESWAPTEAR", "1");
		try
		{
			bool safemode = Array.Exists(args, (self) => self == "-safemode");
			if (Array.Exists(args, (self) => self == "-disablesound"))
			{
				Environment.SetEnvironmentVariable("FNA_AUDIO_DISABLE_SOUND", "1");
			}
			if (Array.Exists(args, (self) => self == "-d3d11"))
			{
				Environment.SetEnvironmentVariable("FNA_OPENGL_FORCE_ES3", "1");
				Environment.SetEnvironmentVariable("SDL_OPENGL_ES_DRIVER", "1");
			}
			using AmorousGame skYjfUaaNhTySNgoGUeFZ46X4dM = new AmorousGame(safemode);
			skYjfUaaNhTySNgoGUeFZ46X4dM.Run();
		}
		catch (Exception exception_)
		{
			_mxSbmCQQPRHc7t2A2pm8HsbyvqfA(exception_);
		}
	}

	private static void _mxSbmCQQPRHc7t2A2pm8HsbyvqfA(Exception exception_0)
	{
		Logger.Error("Unhandled exception: {0}", exception_0);
	}
}