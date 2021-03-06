﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DAL;

namespace Tests_Unitaires
{
    [TestClass]
    public class IngredientDaoTest
    {
        [Ignore] // you can ignore this test
        [TestMethod]    // READ
        public void Test_GetMethodReturnsIngredientWhenGivenName()
        {
            var dao = IngredientDAO.Instance;

            var actual = dao.getByName("TestIngredient");
            var expected = new DAL.Ingredient();

            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [Ignore] // you can ignore this test
        [TestMethod]    // CREATE
        public void Test_CreateMethodAddsEntryToDatabaseWhenGivenIngredient()
        {
            var dao = IngredientDAO.Instance;
            var today = DateTime.Today;
            var d2 = today.AddDays(2);
            var ingredientToAdd = new DAL.Ingredient { name = "TestIngredient", quantityInStock = 0, dateArrival = today, dateExpire = d2, typeId = 1 };

            dao.create(ingredientToAdd);

            Assert.ReferenceEquals(ingredientToAdd, dao.get(1000));
        }

        [Ignore] // you can ignore this test
        [TestMethod]    // UPDATE
        public void Test_UpdateMethodModifiesEntryInDatabaseWhenGivenIdAndIngredient()
        {
            var dao = IngredientDAO.Instance;

            var oldIngredient = dao.get(1000);

            var today = DateTime.Today;
            var d2 = today.AddDays(2);

            var newIngredient = new DAL.Ingredient { name = "TestIngredient", quantityInStock = 0, dateArrival = today, dateExpire = d2, typeId = 1 };

            dao.update(1000, newIngredient);

            Assert.AreNotEqual(oldIngredient, newIngredient);
        }

        [Ignore] // you can ignore this test
        [TestMethod]    // DELETE
        public void Test_DeleteMethodRemovesEntryFromDatabaseWhenGivenIngredientId()
        {
            var dao = IngredientDAO.Instance;

            dao.delete(1000);

            Assert.IsNull(dao.get(1000));
        }
    }
}
