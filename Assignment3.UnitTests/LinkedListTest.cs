using Assignment3.ProblemDomain;
using Assignment3.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Assignment3.UnitTests
{
    public class LinkedListTest
    {
        private SLL linkedList;

        [SetUp]
        public void Setup()
        {
            linkedList = new SLL();
        }


        [Test]
        public void Test_Add()
        {
            User user1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            User user2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
            linkedList.AddLast(user1);
            linkedList.Add(user2, 1);
            Assert.AreEqual(user2, linkedList.GetValue(1));
            Assert.AreEqual(2, linkedList.Count());
        }

        [Test]
        public void Test_AddFirst()
        {
            User user1 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
            linkedList.AddFirst(user1);
            Assert.AreEqual(user1, linkedList.GetValue(0));
            Assert.AreEqual(1, linkedList.Count());
        }

        [Test]
        public void Test_AddLast()
        {
            User user1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            linkedList.AddLast(user1);
            Assert.AreEqual(user1, linkedList.GetValue(0));
            Assert.AreEqual(1, linkedList.Count());
        }

        [Test]
        public void Test_Contains()
        {
            User user1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            User user2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
            linkedList.AddLast(user1);
            linkedList.AddLast(user2);
            Assert.IsTrue(linkedList.Contains(user2));
        }

        [Test]
        public void Test_GetValue()
        {
            User user1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            linkedList.AddLast(user1);
            Assert.AreEqual(user1, linkedList.GetValue(0));
        }

        [Test]
        public void Test_IndexOf()
        {
            User user1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            User user2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
            linkedList.AddLast(user1);
            linkedList.AddLast(user2);
            Assert.AreEqual(1, linkedList.IndexOf(user2));
        }

        [Test]
        public void Test_IsEmpty()
        {
            Assert.IsTrue(linkedList.IsEmpty());
        }

        [Test]
        public void Test_Remove()
        {
            User user1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            User user2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
            linkedList.AddLast(user1);
            linkedList.AddLast(user2);
            linkedList.Remove(0);
            Assert.AreEqual(user2, linkedList.GetValue(0));
            Assert.AreEqual(1, linkedList.Count());
        }

        [Test]
        public void Test_RemoveFirst()
        {
            User user1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            linkedList.AddLast(user1);
            linkedList.RemoveFirst();
            Assert.IsTrue(linkedList.IsEmpty());
        }

        [Test]
        public void Test_RemoveLast()
        {
            User user1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            linkedList.AddLast(user1);
            linkedList.RemoveLast();
            Assert.IsTrue(linkedList.IsEmpty());
        }

        [Test]
        public void Test_Replace()
        {
            User user1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            linkedList.AddLast(user1);
            User newUser = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
            linkedList.Replace(newUser, 0);
            Assert.AreEqual(newUser, linkedList.GetValue(0));
        }

        [Test]
        public void Test_Reverse()
        {
            User user1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            User user2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
            linkedList.AddLast(user1);
            linkedList.AddLast(user2);
            linkedList.Reverse();
            Assert.AreEqual(user1, linkedList.GetValue(1));
            Assert.AreEqual(user2, linkedList.GetValue(0));
        }

        [Test]
        public void Test_SortByName()
        {
            User user1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            User user2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
            linkedList.AddLast(user2);
            linkedList.AddLast(user1);
            linkedList.SortByName();
            Assert.AreEqual(user1, linkedList.GetValue(0));
            Assert.AreEqual(user2, linkedList.GetValue(1));
        }

        [Test]
        public void Test_ToArray()
        {
            User user1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            User user2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
            linkedList.AddLast(user1);
            linkedList.AddLast(user2);
            User[] array = linkedList.ToArray();
            Assert.AreEqual(user1, array[0]);
            Assert.AreEqual(user2, array[1]);
        }
    }
}
