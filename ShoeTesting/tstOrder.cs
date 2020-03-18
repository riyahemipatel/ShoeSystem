using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoeTesting
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class that we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see if it exists 
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void CustomerName()
        {
            //create an instance of the class that we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Riya";
            //assign the data to the property
            AnOrder.CustomerName = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.CustomerName, TestData);
        }
        [TestMethod]
        public void OrderDateOK()
        {
            //create an instance of the class that we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.DateAdded = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.DateAdded, TestData);
        }
        [TestMethod]
        public void OrderNumber()
        {
            //create an instance of the class that we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderNo = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.OrderNo, TestData);


        }
        [TestMethod]
        public void PaymentAmount()
        {
            //create an instance of the class that we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.PaymentAmount = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.PaymentAmount, TestData);
        }
        [TestMethod]
        public void CustomerNumber()
        {
            //create an instance of the class that we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.CustomerID = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.CustomerID, TestData);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class that we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = 1234;
            TestItem.CustomerName = "Riya";
            TestItem.OrderNo = 9034;
            TestItem.PaymentAmount = 56;
            TestItem.OrderDate = DateTime.Now.Date;
            //set THisOrder to the test data
            AllOrder.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrder.Add();
            //set the primary key of the test data
            TestItem.OrderNo = PrimaryKey;
            //find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);




        }






        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method

            Int32 CustomerID = 1;
            DateTime OrderDate = DateTime.MinValue;
            Int32 OrderNo = 3;
            Int32 PaymentAmount = 0;
            String CustomerName = "Riya";
            Boolean Active = true;
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName, Active);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            //create an instance of the class that we want to create
            clsOrder AnOrder = new clsOrder();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            Int32 CustomerID = 1;
            DateTime OrderDate = DateTime.MinValue;
            Int32 OrderNo = 3;
            Int32 PaymentAmount = 0;
            String CustomerName = "Riya";
            Boolean Active = true;
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName, Active);
            //test to see that the resul is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerNameMinBoundary()
        {
            //create an instance of the class that we want to create
            clsOrder AnOrder = new clsOrder();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            Int32 CustomerID = 1;
            DateTime OrderDate = DateTime.MinValue;
            Int32 OrderNo = 3;
            Int32 PaymentAmount = 0;
            String CustomerName = "Riya";
            Boolean Active = true;
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName, Active);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            //create an instance of the class that we want to create
            clsOrder AnOrder = new clsOrder();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            Int32 CustomerID = 1;
            DateTime OrderDate = DateTime.MinValue;
            Int32 OrderNo = 3;
            Int32 PaymentAmount = 0;
            String CustomerName = "Riya";
            Boolean Active = true;
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName, Active);
            //test to see that the resul is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            //create an instance of the class that we want to create
            clsOrder AnOrder = new clsOrder();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            Int32 CustomerID = 1;
            DateTime OrderDate = DateTime.MinValue;
            Int32 OrderNo = 3;
            Int32 PaymentAmount = 0;
            String CustomerName = "Riya";
            Boolean Active = true;
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName, Active);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIDMaxBoundary()
        {
            //create an instance of the class that we want to create
            clsOrder AnOrder = new clsOrder();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            Int32 CustomerID = 1;
            DateTime OrderDate = DateTime.MinValue;
            Int32 OrderNo = 3;
            Int32 PaymentAmount = 0;
            String CustomerName = "Riya";
            Boolean Active = true;
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName, Active);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            //create an instance of the class that we want to create
            clsOrder AnOrder = new clsOrder();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            Int32 CustomerID = 1;
            DateTime OrderDate = DateTime.MinValue;
            Int32 OrderNo = 3;
            Int32 PaymentAmount = 0;
            String CustomerName = "Riya";
            Boolean Active = true;
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName, Active);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            //create an instance of the class that we want to create
            clsOrder clsOrder = new clsOrder();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            Int32 CustomerID = 1;
            DateTime OrderDate = DateTime.MinValue;
            Int32 OrderNo = 3;
            Int32 PaymentAmount = 0;
            String CustomerName = "Riya";
            Boolean Active = true;
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName, Active);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");

        }

        internal class AnOrder
        {
            public int CustomerID { get; private set; }

            internal static int Valid(int someOrder)
            {
                throw new NotImplementedException();
            }


            [TestMethod]
            public void CustomerIDMinBoundary()
            {
                //create an instance of the class that we want to create
                clsOrder clsOrder = new clsOrder();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                Int32 CustomerID = 1;
                DateTime OrderDate = DateTime.MinValue;
                Int32 OrderNo = 3;
                Int32 PaymentAmount = 0;
                String CustomerName = "Riya";
                Boolean Active = true;
                //invoke the method
                Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName, Active);
                //test to see that the result is NOT OK i.e there should be an error message
                Assert.AreNotEqual(Error, "");

            }

            [TestMethod]
            public void CustomerIDMinPlusOne()
            {
                //create an instance of the class that we want to create
                clsOrder AnOrder = new clsOrder();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                Int32 CustomerID = 1;
                DateTime OrderDate = DateTime.MinValue;
                Int32 OrderNo = 3;
                Int32 PaymentAmount = 0;
                String CustomerName = "Riya";
                Boolean Active = true;
                //invoke the method
                Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName, Active);
                //test to see that the result is NOT OK i.e there should be an error message
                Assert.AreNotEqual(Error, "");

            }

            [TestMethod]
            public void PaymentAmountMaxLessOne()
            {
                //create an instance of the class that we want to create
                clsOrder AnOrder = new clsOrder();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                Int32 CustomerID = 1;
                DateTime OrderDate = DateTime.MinValue;
                Int32 OrderNo = 3;
                Int32 PaymentAmount = 0;
                String CustomerName = "Riya";
                Boolean Active = true;
                //invoke the method
                Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName, Active);
                //test to see that the result is NOT OK i.e there should be an error message
                Assert.AreNotEqual(Error, "");

            }

            [TestMethod]
            public void PaymentAmountMaxBoundary()
            {
                //create an instance of the class that we want to create
                clsOrder AnOrder = new clsOrder();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                Int32 CustomerID = 1;
                DateTime OrderDate = DateTime.MinValue;
                Int32 OrderNo = 3;
                Int32 PaymentAmount = 0;
                String CustomerName = "Riya";
                Boolean Active = true;
                //invoke the method
                Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName, Active);
                //test to see that the result is NOT OK i.e there should be an error message
                Assert.AreNotEqual(Error, "");

            }

            [TestMethod]
            public void PaymentAmountMaxPlusOne()
            {
                //create an instance of the class that we want to create
                clsOrder AnOrder = new clsOrder();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                Int32 CustomerID = 1;
                DateTime OrderDate = DateTime.MinValue;
                Int32 OrderNo = 3;
                Int32 PaymentAmount = 0;
                String CustomerName = "Riya";
                Boolean Active = true;
                //invoke the method
                Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName, Active);
                //test to see that the result is NOT OK i.e there should be an error message
                Assert.AreNotEqual(Error, "");
            }
            [TestMethod]
            public void PaymentAmountMinLessOne()
            {
                //create an instance of the class that we want to create
                clsOrder AnOrder = new clsOrder();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                Int32 CustomerID = 1;
                DateTime OrderDate = DateTime.MinValue;
                Int32 OrderNo = 3;
                Int32 PaymentAmount = 0;
                String CustomerName = "Riya";
                Boolean Active = true;
                //invoke the method
                Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName, Active);
                //test to see that the result is NOT OK i.e there should be an error message
                Assert.AreNotEqual(Error, "");

            }

            [TestMethod]
            public void PaymentAmountMinBoundary()
            {
                //create an instance of the class that we want to create
                clsOrder AnOrder = new clsOrder();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                Int32 CustomerID = 1;
                DateTime OrderDate = DateTime.MinValue;
                Int32 OrderNo = 3;
                Int32 PaymentAmount = 0;
                String CustomerName = "Riya";
                Boolean Active = true;
                //invoke the method
                Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName, Active);
                //test to see that the result is NOT OK i.e there should be an error message
                Assert.AreNotEqual(Error, "");

            }

            [TestMethod]
            public void PaymentAmountMinPlusOne()
            {
                //create an instance of the class that we want to create
                clsOrder AnOrder = new clsOrder();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                Int32 CustomerID = 1;
                DateTime OrderDate = DateTime.MinValue;
                Int32 OrderNo = 3;
                Int32 PaymentAmount = 0;
                String CustomerName = "Riya";
                Boolean Active = true;
                //invoke the method
                Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName, Active);
                //test to see that the result is NOT OK i.e there should be an error message
                Assert.AreNotEqual(Error, "");

            }

            [TestMethod]
            public void OrderDateMaxLessOne()
            {
                //create an instance of the class that we want to create
                clsOrder AnOrder = new clsOrder();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                Int32 CustomerID = 1;
                DateTime OrderDate = DateTime.MinValue;
                Int32 OrderNo = 3;
                Int32 PaymentAmount = 0;
                String CustomerName = "Riya";
                Boolean Active = true;
                //invoke the method
                Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName, Active);
                //test to see that the result is NOT OK i.e there should be an error message
                Assert.AreNotEqual(Error, "");

            }

            [TestMethod]
            public void OrderDateMaxBoundary()
            {
                //create an instance of the class that we want to create
                clsOrder AnOrder = new clsOrder();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                Int32 CustomerID = 1;
                DateTime OrderDate = DateTime.MinValue;
                Int32 OrderNo = 3;
                Int32 PaymentAmount = 0;
                String CustomerName = "Riya";
                Boolean Active = true;
                //invoke the method
                Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName, Active);
                //test to see that the result is NOT OK i.e there should be an error message
                Assert.AreNotEqual(Error, "");

            }

            [TestMethod]
            public void OrderDateMaxPlusOne()
            {
                //create an instance of the class that we want to create
                clsOrder AnOrder = new clsOrder();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                Int32 CustomerID = 1;
                DateTime OrderDate = DateTime.MinValue;
                Int32 OrderNo = 3;
                Int32 PaymentAmount = 0;
                String CustomerName = "Riya";
                Boolean Active = true;
                //invoke the method
                Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName, Active);
                //test to see that the result is NOT OK i.e there should be an error message
                Assert.AreNotEqual(Error, "");
            }


            [TestMethod]
            public void OrderDateMinLessOne()
            {
                //create an instance of the class that we want to create
                clsOrder AnOrder = new clsOrder();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                Int32 CustomerID = 1;
                DateTime OrderDate = DateTime.MinValue;
                Int32 OrderNo = 3;
                Int32 PaymentAmount = 0;
                String CustomerName = "Riya";
                Boolean Active = true;
                //invoke the method
                Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName, Active);
                //test to see that the resul is NOT OK i.e there should be an error message
                Assert.AreNotEqual(Error, "");

            }

            [TestMethod]
            public void OrderDateMinBoundary()
            {
                //create an instance of the class that we want to create
                clsOrder AnOrder = new clsOrder();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                Int32 CustomerID = 1;
                DateTime OrderDate = DateTime.MinValue;
                Int32 OrderNo = 3;
                Int32 PaymentAmount = 0;
                String CustomerName = "Riya";
                Boolean Active = true;
                //invoke the method
                Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName, Active);
                //test to see that the resul is NOT OK i.e there should be an error message
                Assert.AreNotEqual(Error, "");

            }

            [TestMethod]
            public void OrderDateMinPlusOne()
            {
                //create an instance of the class that we want to create
                clsOrder AnOrder = new clsOrder();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                Int32 CustomerID = 1;
                DateTime OrderDate = DateTime.MinValue;
                Int32 OrderNo = 3;
                Int32 PaymentAmount = 0;
                String CustomerName = "Riya";
                Boolean Active = true;
                //invoke the method
                Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName, Active);
                //test to see that the resul is NOT OK i.e there should be an error message
                Assert.AreNotEqual(Error, "");

            }

            [TestMethod]
            public void OrderNoMaxLessOne()
            {
                //create an instance of the class that we want to create
                clsOrder AnOrder = new clsOrder();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                Int32 CustomerID = 1;
                DateTime OrderDate = DateTime.MinValue;
                Int32 OrderNo = 3;
                Int32 PaymentAmount = 0;
                String CustomerName = "Riya";
                Boolean Active = true;
                //invoke the method
                Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName, Active);
                //test to see that the resul is NOT OK i.e there should be an error message
                Assert.AreNotEqual(Error, "");

            }

            [TestMethod]
            public void OrderNoMaxBoundary()
            {
                //create an instance of the class that we want to create
                clsOrder AnOrder = new clsOrder();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                Int32 CustomerID = 1;
                DateTime OrderDate = DateTime.MinValue;
                Int32 OrderNo = 3;
                Int32 PaymentAmount = 0;
                String CustomerName = "Riya";
                Boolean Active = true;
                //invoke the method
                Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName, Active);
                //test to see that the resul is NOT OK i.e there should be an error message
                Assert.AreNotEqual(Error, "");

            }

            [TestMethod]
            public void OrderNoMaxPlusOne()
            {
                //create an instance of the class that we want to create
                clsOrder AnOrder = new clsOrder();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                Int32 CustomerID = 1;
                DateTime OrderDate = DateTime.MinValue;
                Int32 OrderNo = 3;
                Int32 PaymentAmount = 0;
                String CustomerName = "Riya";
                Boolean Active = true;
                //invoke the method
                Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName, Active);
                //test to see that the resul is NOT OK i.e there should be an error message
                Assert.AreNotEqual(Error, "");
            }


            [TestMethod]
            public void OrderNoMinLessOne()
            {
                //create an instance of the class that we want to create
                clsOrder AnOrder = new clsOrder();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                Int32 CustomerID = 1;
                DateTime OrderDate = DateTime.MinValue;
                Int32 OrderNo = 3;
                Int32 PaymentAmount = 0;
                String CustomerName = "Riya";
                Boolean Active = true;
                //invoke the method
                Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName, Active);
                //test to see that the resul is NOT OK i.e there should be an error message
                Assert.AreNotEqual(Error, "");

            }

            [TestMethod]
            public void OrderNoMinBoundary()
            {
                //create an instance of the class that we want to create
                clsOrder AnOrder = new clsOrder();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                Int32 CustomerID = 1;
                DateTime OrderDate = DateTime.MinValue;
                Int32 OrderNo = 3;
                Int32 PaymentAmount = 0;
                String CustomerName = "Riya";
                Boolean Active = true;
                //invoke the method
                Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName, Active);
                //test to see that the result is NOT OK i.e there should be an error message
                Assert.AreNotEqual(Error, "");

            }

            [TestMethod]
            public void OrderNoMinPlusOne()
            {
                //create an instance of the class that we want to create
                clsOrder AnOrder = new clsOrder();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                Int32 CustomerID = 1;
                DateTime OrderDate = DateTime.MinValue;
                Int32 OrderNo = 3;
                Int32 PaymentAmount = 0;
                String CustomerName = "Riya";
                Boolean Active = true;
                //invoke the method
                Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName, Active);
                //test to see that the result is NOT OK i.e there should be an error message
                Assert.AreNotEqual(Error, "");

            }

            [TestMethod]
            public void ActiveMaxLessOne()
            {
                //create an instance of the class that we want to create
                clsOrder AnOrder = new clsOrder();
                //create a string variable to store the result of the validation
                Boolean Error = true;
                //create some test data to test the method
                Int32 CustomerID = 1;
                DateTime OrderDate = DateTime.MinValue;
                Int32 OrderNo = 3;
                Int32 PaymentAmount = 0;
                String CustomerName = "Riya";
                Boolean Active = true;
                //invoke the method
                Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName);
                //test to see that the result is NOT OK i.e there should be an error message
                Assert.AreNotEqual(Error, "");

            }

            [TestMethod]
            public void ActiveMaxBoundary()
            {
                //create an instance of the class that we want to create
                clsOrder AnOrder = new clsOrder();
                //create a string variable to store the result of the validation
                Boolean Error = true;
                //create some test data to test the method
                Int32 CustomerID = 1;
                DateTime OrderDate = DateTime.MinValue;
                Int32 OrderNo = 3;
                Int32 PaymentAmount = 0;
                String CustomerName = "Riya";
                Boolean Active = true;
                //invoke the method
                Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName);
                //test to see that the result is NOT OK i.e there should be an error message
                Assert.AreNotEqual(Error, "");

            }

            [TestMethod]
            public void ActiveMaxPlusOne()
            {
                //create an instance of the class that we want to create
                clsOrder AnOrder = new clsOrder();
                //create a string variable to store the result of the validation
                Boolean Error = true;
                //create some test data to test the method
                Int32 CustomerID = 1;
                DateTime OrderDate = DateTime.MinValue;
                Int32 OrderNo = 3;
                Int32 PaymentAmount = 0;
                String CustomerName = "Riya";
                Boolean Active = true;
                //invoke the method
                Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName);
                //test to see that the resul is NOT OK i.e there should be an error message
                Assert.AreNotEqual(Error, "");
            }


            [TestMethod]
            public void ActiveMinLessOne()
            {
                //create an instance of the class that we want to create
                clsOrder AnOrder = new clsOrder();
                //create a string variable to store the result of the validation
                Boolean Error = true;
                //create some test data to test the method
                Int32 CustomerID = 1;
                DateTime OrderDate = DateTime.MinValue;
                Int32 OrderNo = 3;
                Int32 PaymentAmount = 0;
                String CustomerName = "Riya";
                Boolean Active = true;
                //invoke the method
                Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName);
                //test to see that the resul is NOT OK i.e there should be an error message
                Assert.AreNotEqual(Error, "");

            }

            [TestMethod]
            public void ActiveMinBoundary()
            {
                //create an instance of the class that we want to create
                clsOrder AnOrder = new clsOrder();
                //create a string variable to store the result of the validation
                Boolean Error = true;
                //create some test daTa to test the method
                Int32 CustomerID = 1;
                DateTime OrderDate = DateTime.MinValue;
                Int32 OrderNo = 3;
                Int32 PaymentAmount = 0;
                String CustomerName = "Riya";
                Boolean Active = true;
                //invoke the method
                Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName);
                //test to see that the resul is NOT OK i.e there should be an error message
                Assert.AreNotEqual(Error, "");

            }

            [TestMethod]
            public void ActiveMinPlusOne()
            {
                //create an instance of the class that we want to create
                clsOrder AnOrder = new clsOrder();
                //create a string variable to store the result of the validation
                Boolean Error = true;
                //create some test data to test the method
                Int32 CustomerID = 1;
                DateTime OrderDate = DateTime.MinValue;
                Int32 OrderNo = 3;
                Int32 PaymentAmount = 0;
                String CustomerName = "Riya";
                Boolean Active = true;
                //invoke the method
                Error = AnOrder.Valid(CustomerID, OrderDate, OrderNo, PaymentAmount, CustomerName);
                //test to see that the resul is NOT OK i.e there should be an error message
                Assert.AreNotEqual(Error, "");

            }

            [TestMethod]
            public void FindMethodOK()
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //boolean variable to store the result of the validation
                Boolean Found = false;
                //create some test data to use with the method
                Int32 OrderNo = 1;
                //invoke the method
                Found = AnOrder.Find(OrderNo);
                //test to see that the result is correct
                Assert.IsTrue(Found);
            }
            [TestMethod]
            public void TestOrderNoFound()
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //boolean variable to store the result of the search
                Boolean Found = false;
                //boolean variable to record if data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 OrderNo = 21;
                //invoke the method
                Found = AnOrder.Find(OrderNo);
                //check the address no
                if (AnOrder.OrderNo != 21)
                {
                    OK = false;
                }
                //test to see that the result is correct
                Assert.IsTrue(OK);
            }
            [TestMethod]
            public void TestPaymentAmountFound()
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //boolean variable to store the result of the search
                Boolean Found = false;
                //boolean variable to record if data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 PaymentAmount = 21;
                //invoke the method
                Found = AnOrder.Find(PaymentAmount);
                //check the property
                if (AnOrder.PaymentAmount != 21) 
                {
                    OK = false;
                }
                //test to see that the result is correct
                Assert.IsTrue(OK);
            }
            [TestMethod]
            public void TestCustomerIDFound()
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //boolean variable to store the result of the search
                Boolean Found = false;
                //boolean variable to record if data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 CustomerID = 21;
                //invoke the method
                Found = AnOrder.Find(CustomerID);
                //check the property
                if (AnOrder.CustomerName != "XXX XXX")
                {
                    OK = false;
                }
                //test to see that the result is correct
                Assert.IsTrue(OK);
            }
            [TestMethod]
            public void TestCustomerNameFound()
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //boolean variable to store the result of the search
                Boolean Found = false;
                //boolean variable to record if data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 CustomerID = 7;
                //invoke the method
                Found = AnOrder.Find(CustomerID);
                //check the property
                if (AnOrder.CustomerName != "XXX XXX")
                {
                    OK = false;
                }
                //test to see that the result is correct
                Assert.IsTrue(OK);
            }
            [TestMethod]
            public void TestOrderDateFound()
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //boolean variable to store the result of the search
                Boolean Found = false;
                //boolean variable to record if data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 CustomerID = 7;
                //invoke the method
                Found = AnOrder.Find(CustomerID);
                //check the property
                if (AnOrder.CustomerName != "XXX XXX")
                {
                    OK = false;
                }
                //test to see that the result is correct
                Assert.IsTrue(OK);
            }
            [TestMethod]
            public void TestActiveFound()
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //boolean variable to store the result of the search
                Boolean Found = false;
                //boolean variable to record if data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 OrderNo = 21;
                //invoke the method
                Found = AnOrder.Find(OrderNo);
                //check the property
                if (AnOrder.Active != true)
                {
                    OK = false;
                }
                //test to see that the result is correct
                Assert.IsTrue(OK);
            }

            internal static string Valid(int customerID, DateTime orderDate, int orderNo, int paymentAmount, string customerName, bool active)
            {
                throw new NotImplementedException();
            }
        }









    }
}


