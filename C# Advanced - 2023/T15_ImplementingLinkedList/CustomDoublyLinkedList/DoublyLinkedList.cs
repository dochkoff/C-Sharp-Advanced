﻿using System;
namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList
    {
        private class ListNode
        {
            public ListNode(int value)
            {
                this.Value = value;
            }

            public int Value { get; set; }
            public ListNode NextNode { get; set; }
            public ListNode PreviousNode { get; set; }
        }
        private ListNode head;
        private ListNode tail;


        public int Count { get; private set; }

        public void AddFirst(int element)
        {
            if (this.Count == 0)
            {
                this.head = this.tail = new ListNode(element);
            }
            else
            {
                ListNode newHead = new(element);
                newHead.NextNode = this.head;
                this.head.PreviousNode = newHead;
                this.head = newHead;
            }
            this.Count++;
        }

        public void AddLast(int element)
        {
            if (this.Count == 0)
            {
                this.head = this.tail = new ListNode(element);
            }
            else
            {
                ListNode newTail = new(element);
                newTail.PreviousNode = this.tail;
                this.tail.NextNode = newTail;
                this.tail = newTail;
            }
            this.Count++;
        }

        public int RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidProgramException("The list is empty");
            }

            int firstElement = this.head.Value;
            this.head = this.head.NextNode;

            if (this.head != null)
            {
                this.head.PreviousNode = null;
            }
            else
            {
                this.tail = null;
            }

            this.Count--;
            return firstElement;
        }

        public int RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidProgramException("The list is empty");
            }

            int lastElement = this.tail.Value;
            this.tail = this.tail.PreviousNode;

            if (this.tail != null)
            {
                this.tail.NextNode = null;
            }
            else
            {
                this.head = null;
            }

            this.Count--;
            return lastElement;
        }

        public void ForEach(Action<int> action)
        {
            ListNode currentNode = this.head;

            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }

        public int[] ToArray()
        {
            int[] array = new int[this.Count];
            int counter = 0;
            ListNode currentNode = this.head;

            while (currentNode != null)
            {
                array[counter] = currentNode.Value;
                currentNode = currentNode.NextNode;
                counter++;
            }
            return array;
        }
    }
}

