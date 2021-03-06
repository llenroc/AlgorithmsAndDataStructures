﻿#region copyright
/* 
 * Copyright (c) 2019 (PiJei) 
 * 
 * This file is part of AlgorithmsAndDataStructures project.
 *
 * AlgorithmsAndDataStructures is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * AlgorithmsAndDataStructures is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with AlgorithmsAndDataStructures.  If not, see <http://www.gnu.org/licenses/>.
 */
#endregion
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsAndDataStructuresTests.Algorithms.Sort
{
    /// <summary>
    /// Implements methods for testing sort algorithms over arrays with different properties. 
    /// </summary>
    [TestClass]
    public class SortTests
    {
        /// <summary>
        /// Tests the correctness of <paramref name="sortMethod"/>.
        /// </summary>
        /// <param name="sortMethod">The sort method that is being tested. </param>
        public static void TestSortMethodWithDifferentInputs(Action<List<int>> sortMethod)
        {
            var values = new List<int>(Constants.ArrayWithDistinctValues);
            sortMethod(values);
            Assert.IsTrue(UtilsTests.IsSortedAscendingly(values));

            values = new List<int>(Constants.ArrayWithDuplicateValues);
            sortMethod(values);
            Assert.IsTrue(UtilsTests.IsSortedAscendingly(values));

            values = new List<int>(Constants.ArrayWithSortedDistinctValues);
            sortMethod(values);
            Assert.IsTrue(UtilsTests.IsSortedAscendingly(values));

            values = new List<int>(Constants.ArrayWithSortedDuplicateValues);
            sortMethod(values);
            Assert.IsTrue(UtilsTests.IsSortedAscendingly(values));

            values = new List<int>(Constants.ArrayWithReverselySortedDistinctValues);
            sortMethod(values);
            Assert.IsTrue(UtilsTests.IsSortedAscendingly(values));

            values = new List<int>(Constants.ArrayWithReverselySortedDuplicateValues);
            sortMethod(values);
            Assert.IsTrue(UtilsTests.IsSortedAscendingly(values));
        }
    }
}
