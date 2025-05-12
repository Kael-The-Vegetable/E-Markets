using BasicUtilities;
using System;
using UnityEngine;
public class TickManager : Singleton<TickManager>
{
	[field: SerializeField] public int TicksPerSecond { get; private set; } = 60;

	private float _timePerTick;
	public float TimePerTick => _timePerTick;

	public static event Action OnTick;

	private readonly StopwatchTimer _timer = new();
	private float _accountedTime = 0;
	protected override void Initialize()
	{
		_timePerTick = 1f / TicksPerSecond;
		_timer.OnTick += OnTimerTick;
		_timer.Start();
	}

	protected void OnDestroy()
	{
		_timer.Dispose();
	}

	private void OnTimerTick(StopwatchTimer timer)
	{
		while(_accountedTime < timer.ElapsedTime)
		{
			_accountedTime += TimePerTick;
			OnTick.Invoke();
		}
	}

	public void ProcessTick() => OnTick.Invoke();
}
