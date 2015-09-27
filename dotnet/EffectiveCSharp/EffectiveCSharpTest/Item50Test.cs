using System;
using System.Collections.Generic;
using EffectiveCSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EffectiveCSharpTest
{
    [TestClass]
    public class Item50Test
    {
        [TestMethod]
        public void ShouldActAsNewCopyGivenListContainStruct()
        {
            //given
            var attendees = new List<Person>();
            var person = new Person() { Name = "Original Name" };
            attendees.Add(person);

            //when
            var someone = attendees[0];
            someone.Name = "New Name";

            //then
            Assert.AreEqual("Original Name", attendees[0].Name);
        }
    }
}