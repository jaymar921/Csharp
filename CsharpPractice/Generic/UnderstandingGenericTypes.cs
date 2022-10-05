using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpPractice.Generic
{

    internal class Person { }
    internal class Student : Person { }
    internal class Teacher : Person { }
    public class UnderstandingGenericTypes
    {

        /*
         * We have a less derived class called Person
         * while Student and Teacher class derives from class Person
         * 
         * We all know that all Students are Person but not all Person
         * are Student because there is also another type of Person which
         * is a Teacher
         */
        Person p1 = new Student();
        Person p2 = new Student();
        Person p3 = new Teacher();

        /*
         * If you are assigning a more derived class to a less derived class
         * which is for example: Student -> Person, it will be called covariant
         * 
         * you can only return the generic class type but cannot accept any
         * parameters with generic class type
         */
        ICovariant<Person> covariant = new Covariant<Student>();

        /*
         * If you are assigning a less derived class to a more derived class
         * which is for example: Person -> Teacher, it will be called contravariant
         * 
         * you can only provide the method with the generic class type but 
         * cannot return any object of generic class type
         */
        IContravariant<Teacher> contravariant = new Contravariant<Person>();
        
    }

    interface ICovariant<out T>
    {
        T Item { get; }
        T Process();
    }

    class Covariant<T> : ICovariant<T>
    {
        public T Item => throw new NotImplementedException();

        public T Process()
        {
            throw new NotImplementedException();
        }
    }

    interface IContravariant<in T>
    {
        T Item { set; }
        void Process();
    }

    class Contravariant<T> : IContravariant<T>
    {
        public T Item { set => throw new NotImplementedException(); }

        public void Process()
        {
            throw new NotImplementedException();
        }
    }
}
