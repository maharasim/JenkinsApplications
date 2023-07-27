namespace TestProject1
{
	
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			string sample = "this is the applications";
			Assert.AreEqual("this is the applications", sample);
		}
	}
}