﻿/* 
 * Copyright (c) 2019 (PiJei) 
 * 
 * This file is part of CSFundamentalAlgorithms project.
 *
 * CSFundamentalAlgorithms is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * CSFundamentalAlgorithms is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with CSFundamentals.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;

namespace CSFundamentals.DataStructures.Trees
{
    public abstract class Tree<T1, T2> where T1 : IComparable<T1>, IEquatable<T1>
    {
        /// <summary>
        /// Is the root of the binary search tree. 
        /// </summary>
        protected BinaryTreeNode<T1, T2> _root = null;

        public abstract BinaryTreeNode<T1, T2> Build(Dictionary<T1, T2> keyValues);

        public abstract BinaryTreeNode<T1, T2> Insert(BinaryTreeNode<T1, T2> root, T1 key, T2 value);

        public abstract BinaryTreeNode<T1, T2> Search(BinaryTreeNode<T1, T2> root, T1 key);

        public abstract bool Update(BinaryTreeNode<T1, T2> root, T1 key, T2 value);

        public abstract BinaryTreeNode<T1, T2> Delete(BinaryTreeNode<T1, T2> root, T1 key);
    }
}