using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DynamicList
{
    internal class DynamicList
    {
        //Тук няма елементи!!! Държим само указателите: 
        //към началото -> head
        //към края -> tail

        private Node head;
        private Node tail;

        private int count;
        public int Count
        {
            get { return this.count; }
            private set { this.count = value; }
        }

        //СВОЙСТВО      public object this[int index]:
        //get
        //  проверяваме дали достъпваме валиден индекс
        //  обхождаме списъка по стандартната схема
        //  и така достигаме до желания индекс
        //  и връщаме стойността му

        //set
        //  аналогичен на get,
        //  с разликата че задаваме стойността му,
        //  а не я извличаме
        public object this[int index] //задава как се използва ИНДЕКСНАТА ПРОМЕНЛИВА
                                      //(номерираните елементи започват от 0)
        {
            get
            {
                Node current = head;
                int i = 0;
                while (current != null)
                {
                    if (i == index)
                    {
                        return current.Element;
                    }
                    i++;
                    current = current.Next;
                }
                return null;
            }
            set
            {
                Node current = head;
                int i = 0;
                while (current != null)
                {
                    if (i == index)
                    {
                        current.Element = value;
                        break;
                    }
                    i++;
                    current = current.Next;
                }
            }
        }
        //Конструктор за празен списък
        public DynamicList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        //Add:
        //if (head == null)
        //  Създаване на първи елемент в списъка
        //else
        //  Създаваме пореден елемент в списъка
        //увеличаваме Count

        public void Add(object item)
        {
            if (this.head == null)
            {
                Node next = new Node(item);
                this.head = next;
                this.tail = next;
            }
            else
            {
                Node next = new Node(item, tail);
                this.tail = next;
            }
            this.count++;
        }



        // >>>>IndexOf:
        //намираме елемента, използвайки обхождане
        //Ако елементът е намерен:
        //  Връщаме индекса му
        //Ако елементът НЕ Е намерен връщаме -1
        public int IndexOf(object item)
        {
            Node current = head;
            int index = 0;
            while (current != null)
            {
                if (current.Element.Equals(item))
                {
                    return index;
                }
                index++;
                current = current.Next;
            }
            return -1;
        }




        // >>>>Remove(по индекс) :
        //проверка дали индекса е валиден
        //намираме елемента, на съответния индекс
        //намаляме Count и изтриваме елемента
        //намираме новият последен елемент
        //и го задаваме за tail
        public object RemoveAt(int index)
        {
            Object item = null;
            Node current = head;
            Node previous = null;
            int i = 0;
            while (current != null)
            {
                if (index == i)
                {
                    item = current.Element;
                    previous.Next = current.Next;
                    break;
                }
                i++;
                previous = current;
                current = current.Next;
            }
            return item;
        }

        /// <summary>Да го опишем сами!!!!
        /// 
        /// 

        public int Remove(object item)
        {
            int index = 0;
            Node current = head;
            while (current != null)
            {
                if (current.Element.Equals(item))
                {
                    Remove(index);
                    return index;
                }
                index++;
                current = current.Next;
            }
            return -1;
        }

        // >>>>Contains:
        //Извикваме IndexOf
        //Ако IndexOf върне стойност различна от -1
        //  връщаме индекса
        //в противен случай
        //  връщаме -1
        public bool Contains(object item)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Element.Equals(item)) return true;
                current = current.Next;
            }
            return false;
        }


    }
}
