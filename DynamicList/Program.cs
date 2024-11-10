namespace DynamicList
{
    public class Program
    {
        static void Main()
        {
            
            DynamicList list = new DynamicList();

            list.Add(new Node(200));
            list.Add(new Node("yes"));
            list.Add(new Node(true));

            //for (int i = 0; i < list.Count; i++)
            //{
            //    var item = ((Node)list[i]).Element.ToString();
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(list.Remove("yes"));
            Console.WriteLine(((Node)list.RemoveAt(1)).Element.ToString());
        }
    }
}
