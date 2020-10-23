using System;
using Xunit;
using CommandAPI.Models;

namespace CommandAPI.Tests
{
    public class CommandTests : IDisposable
    {
        Command testCommand;
        public CommandTests()
        {
            testCommand = new Command
            {
                HowTo = "Do something",
                Platform = "Some platform",
                CommandLine = "Some commandline"
            };
        }

        public void Dispose()
        {
            testCommand = null;
        }

        [Fact]
        public void CanChangeHowTo()
        {
            testCommand.HowTo = "Excute Unit Tests";

            Assert.Equal("Excute Unit Tests", testCommand.HowTo);
        }

        [Fact]
        public void CanChangePlatform()
        {
            testCommand.Platform = "xUnit platform";

            Assert.Equal("xUnit platform", testCommand.Platform);
        }

        [Fact]
        public void CanChangeCommandLine()
        {
            testCommand.CommandLine = "dotnet xUnit test";

            Assert.Equal("dotnet xUnit test", testCommand.CommandLine);
        }
    }
}

