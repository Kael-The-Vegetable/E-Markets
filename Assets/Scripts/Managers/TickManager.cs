using BasicUtilities;
using System;
using UnityEngine;
public class TickManager : Singleton<TickManager>
{
	[field: SerializeField] public int TicksPerSecond { get; set; } = 60;

	public static event Action OnTick;
	protected override void Initialize()
	{
		float tickTime = 1f / TicksPerSecond;
		OnTick += () => OneShotTimer.Delay(tickTime, OnTick, destroyCancellationToken);
		OnTick += () => Debug.Log(Time.time);
		OnTick.Invoke();
	}
}
