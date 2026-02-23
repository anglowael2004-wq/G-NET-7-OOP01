namespace dimo
{
    #region namespace
    // access modifiers:public, internal,
    // default access modifier for namespace is internal,
    //u can write:class, struct, record, interface, enum, delegate
    // u cannot write: namespace, method, property, field, event, indexer, operator, constructor, destructor, finalizer
    #endregion
    internal class Program
    {
        #region class
        // access modifiers: public, internal, protected, private, protected internal, private protected
        // default access modifier for class is internal
        // class can contain: fields, properties, methods, events, indexers, operators, constructors, destructors, finalizers
        //default access modifier for members private

        #endregion
        static void Main(string[] args)
        {
            #region struct
            // access modifiers: public, internal, private
            //default access modifier for struct is internal
            // struct can contain: fields, properties, methods, events, indexers, operators, constructors
            // default access modifier for members private

            #endregion
            #region enum
            // access modifiers: public, 
            //default access modifier for enum is internal
            // enum can contain: named constants
            // default access modifier for members public
            #endregion
            #region interface
            // access modifiers: public, internal, private,protected,
            // default access modifier for interface is internal
            // interface can contain: methods, properties, events, indexers
            // default access modifier for members public
            #endregion
            #region record
            // access modifiers: public, internal, private, protected,protected internal, private protected
            // default access modifier for record is internal
            // record can contain: fields, properties, methods, events, indexers, operators, constructors, destructors, finalizers
            // default access modifier for members private
            #endregion

        }
    }
}
