namespace Session05_AssignmentOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            #region Q1
            // a) it copies the reference of the object in heap, so any change in any object with change the another object
            // b) no it copies the reference of the object in heap, so the two objects will refer to the same object in heap
            // c) copying the reference means the to objects refer to the same object in heap soany change in any object with
            // change the another object
            // but coping an object is creating another object in heap
            #endregion

            #region Q2
            // a) shallow copy create a new object in heap, and copies the values inside the object value type or reference type,
            // and does not make new objects for the reference type values
            // b) deep copy create new object in heap, copy the value of value type, but create new objects for the reference type
            // values
            // c) the new object copies the reference of the reference type values
            // d) will create new objects for the reference type values
            // e) when getting a data from database in an object and we do not want to change that data but want to make calculation
            // or testing on it only
            #endregion
            #endregion
        }
    }
}
