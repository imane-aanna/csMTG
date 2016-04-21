﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using csMTG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csMTG.Tests
{
    [TestClass()]
    public class TreeTests
    {
        [TestMethod()]
        public void Tree_NewTree_RootCreated()
        {
            Tree t = new Tree();
            int root = t.children.Keys.First();
            Assert.AreEqual(root, 0);
        }

        [TestMethod()]
        public void Count_NewTreeCreated_Returns1()
        {
            Tree t = new Tree();
            Assert.AreEqual(t.Count(), 1);
        }

        [TestMethod()]
        public void AddChild_NormalScenario_OneChildAdded()
        {
            Tree t = new Tree();
            t.AddChild(0);

            int childId = t.id;

            Assert.IsTrue(t.children[0].Contains(childId));
            Assert.AreEqual(t.children[0].Count(), 1);
            Assert.AreEqual(t.parent[childId], 0);
        }

        [TestMethod()]
        //Case where we specify the id of the child that doesn't exist
        public void AddChild_ChildIdDoesntExist_SpecificIdCreated()
        {
            Tree t = new Tree();

            int childId = t.AddChild(0, 5);

            Assert.IsTrue(t.children[0].Contains(childId));
            Assert.AreEqual(t.children[0].Count(), 1);
            Assert.AreEqual(t.parent[childId], 0);
        }
    }
}