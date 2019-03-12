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

namespace CSFundamentals.DataStructures.Trees
{
    public class RedBlackTreeNode<T1, T2> : TreeNode<RedBlackTreeNode<T1, T2>, T1, T2> where T1 : IComparable<T1>, IEquatable<T1>
    {
        public Color Color { get; set; }
        public override RedBlackTreeNode<T1, T2> LeftChild { get; set; }
        public override RedBlackTreeNode<T1, T2> RightChild { get; set; }
        public override RedBlackTreeNode<T1, T2> Parent { get; set; }

        public RedBlackTreeNode(T1 key, T2 value, Color color = Color.Red) : base(key, value)
        {
            Color = color;
        }

        public void FlipColor()
        {
            if (Color == Color.Red)
            {
                Color = Color.Black;
            }
            else if (Color == Color.Black)
            {
                Color = Color.Red;
            }
        }
    }

    public enum Color
    {
        Unknown = 0,
        Red = 1,
        Black = 2
    }
}
