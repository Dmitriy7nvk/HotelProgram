//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelProgram
{
    using System;
    using System.Collections.Generic;
    
    public partial class documents
    {
        public int document_id { get; set; }
        public int client_id { get; set; }
        public int document_type { get; set; }
        public string document_number { get; set; }
        public System.DateTime document_date { get; set; }
    
        public virtual clients clients { get; set; }
        public virtual document_types document_types { get; set; }
    }
}
