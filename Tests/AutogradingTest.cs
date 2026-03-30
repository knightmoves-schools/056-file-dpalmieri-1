namespace Tests;

using knightmoves;
using Xunit;

public class AutogradingTest
{
    //should write "hello file" to the `fileName` provided to the `Create` method
    [Fact]
    public void Should_Write_Hello_File_To_The_FileName_Provided_To_The_Create_Method(){
       string tempFileName = Path.GetTempFileName();
       
       var fileManager = new FileManager();
       fileManager.Create(tempFileName);

       Assert.True(File.Exists(tempFileName));
       Assert.Equal("file hello", File.ReadAllText(tempFileName));
    }
}