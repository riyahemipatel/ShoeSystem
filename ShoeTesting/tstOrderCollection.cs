using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoeTesting
{
    /// <summary>
    /// Summary description for tstOrderCollection
    /// </summary>
    [TestClass]
    public class tstOrderCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see if it exists
            Assert.IsNotNull(AllOrders);
        }
        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list 
            //create the item of the test data 
            clsOrder TestItem = new clsOrder();
            TestItem.Active = true;
            TestItem.CustomerID = 123;
            TestItem.CustomerName = "Riya";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.OrderNo = 2345;
            TestItem.PaymentAmount = 54;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrders.OrderList, TestList);

        }
        [TestMethod]
        public void CountPropertyOK()

        {
            //create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to their property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllOrders.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, SomeCount);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            //set the properties of the test project

            TestOrder.Active = true;
            TestOrder.CustomerID = 123;
            TestOrder.CustomerName = "Riya";
            TestOrder.DateAdded = DateTime.Now.Date;
            TestOrder.OrderNo = 2345;
            TestOrder.PaymentAmount = 54;
            //assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);



        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the ist 
            //create the item of the test data
            clsOrder TestItem = new clsOrder();
            //set the properties of the test project

            TestItem.Active = true;
            TestItem.CustomerID = 123;
            TestItem.CustomerName = "Riya";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.OrderNo = 2345;
            TestItem.PaymentAmount = 54;
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        public class clsOrderCollection
        {
            //private data member for the list
            List<clsOrder> mOrderist = new List<clsOrder>();

            public List<clsOrder> OrderList { get; internal set; }
            public int Count { get; internal set; }
            public object ThisOrder { get; internal set; }
        }

        //public property for the customer list
        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return OrderList;
            }
            set
            {
                //set the private data
                OrderList = value;
            }

        }

        //public property for count
        public int count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.Count, 2);
        }

        //public constructor for the class
        public tstOrderCollection()
        {
            //create an instance of the customer class to store a customer
            clsOrder AnOrder = new clsOrder();
            //set the customer to sonny
            //AnOrder.OrderNo = "";
            //add the customer to the private list of customers
            mOrderList.Add(AnOrder);
            //re intialise the ACustomer object to accept a new item
            AnOrder = new clsOrder();
            //set the customer to Radhe
            //AnOrder.OrderNo = "";
            //add the second customer to the private list of customers
            mOrderList.Add(AnOrder);
            //the private list now contains two customers
        }



    }
}
