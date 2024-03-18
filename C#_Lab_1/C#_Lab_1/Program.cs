using Figur;
using System;
using Type = Figur.Circle;
public class Stack<T>
{
    private Node<T>? head { get; set; }

    public Node<T> Top()
    {
        return head;
    }
    public Stack<T> Tail()
    {
        Stack<T> St = new Stack<T>();
        St.head = head.next;
        return St;
    }
    public void Push(T value)
    {
        Node<T> newNode = new Node<T>();
        newNode.Value = value;
        newNode.next = head;
        head = newNode;
    }

    public T Pop()
    {
        if (head == null)
            throw new InvalidOperationException("Стэк пуст");

        T value = head.Value;
        head = head.next;
        return value;
    }

    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T>? next { get; set; }
    }
}


public class Programm
{
    public static void Main(string[] args)
    {
        Stack<Type> stack = new Stack<Type>();
        for (int i = 0; i < 5; i++)
            stack.Push(new Circle(i-1,i+1,i*i));
        int mode;
        do
        {
            mode = -1;
            Console.WriteLine("1)верхнее значение\n2)хвост\n3)удалить\n4)добавить\n0)выйти");
            do
            {
                try
                { mode = Convert.ToInt32(Console.ReadLine()); }
                catch (Exception ex)
                { Console.WriteLine(ex.Message); }
            } while (mode == -1);
            switch (mode)
            {
                case 1:
                    Console.WriteLine(stack.Top().Value.GetString());
                    break;
                case 2:
                    Stack<Type> st = stack.Tail();
                    while (st.Top() != null) Console.WriteLine(st.Pop().GetString());
                    Console.WriteLine();
                    break;
                case 3:
                    try
                    { stack.Pop(); }
                    catch (Exception ex)
                    { Console.WriteLine(ex.Message); }
                    break;
                case 4:
                    Circle tmp = new Circle();
                    tmp.Input();
                    stack.Push(tmp);
                    //Console.WriteLine("Введите значение");
                    //stack.Push(Console.ReadLine());
                    break;
            }
        } while (mode != 0);
    }
}