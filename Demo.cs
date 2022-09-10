namespace SampleLibrary2
{
	public static class Demo
	{
		public static int Length(string a, string b) => SampleLibrary1.Demo.Concat(a,b).Length;
	}
}