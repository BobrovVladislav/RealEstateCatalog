//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RealEstateCatalog.Base
{
    using System;
    using System.Collections.Generic;
    
    public partial class Сontract
    {
        public int ID { get; set; }
        public int IDClient { get; set; }
        public int IDApartment { get; set; }
        public string type { get; set; }
        public decimal amount { get; set; }
        public System.DateTime dateContract { get; set; }
    
        public virtual Apartment Apartment { get; set; }
        public virtual Client Client { get; set; }
    }
}
