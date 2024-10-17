

namespace HololiveConcertBlazorLibrary.DataModels;

public class PerformanceModel
{
	public int ActNumber { get; set; }
	public string SongName { get; set; }
	public bool IsHololiveOriginal { get; set; }
	public string FirstName { get; set; }
	public string? LastName { get; set; }
	public bool IsGroupPerformance { get; set; }
	public string EventName { get; set; }
	public string ConcertName { get; set; }
	public string StageName { get; set; }
	public DateTime ConcertDate { get; set; }
}
