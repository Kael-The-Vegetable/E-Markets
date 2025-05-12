using System;

public class Company : IDisposable
{

	#region IDisposable Values
	private bool _disposed;
	~Company() => Dispose(false);
	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}
	private void Dispose(bool disposing)
	{
		if (_disposed) return;

		if (disposing)
		{ // put managed goods in here

		}
		_disposed = true;
	}
	#endregion
}
