using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleViewer.Controllers;
using PersonReader.Interface;

namespace PeopleViewer.Test;

[TestClass]
public class PeopleControllerTests
{
    [TestMethod]
    public void PeopleController_OnRuntimeReaderAction_ModelIsPopulated()
    {
        // Arrange
        IPersonReader reader = new FakeReader();
        var controller = new PeopleController(reader);

        // Act 
        var result = controller.UseRuntimeReader();

        // Assert
        Assert.Inconclusive();
    }

    [TestMethod]
    public void PeopleController_OnRuntimeReaderAction_ReaderTypeIsPopulated()
    {
        Assert.Inconclusive();
    }
}
