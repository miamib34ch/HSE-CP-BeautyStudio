//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BeautyStudioPractice
{
    using System;
    using System.Collections.Generic;
    
    public partial class Пигменты
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Пигменты()
        {
            this.Процедуры_клиента = new HashSet<Процедуры_клиента>();
        }
    
        public int Id_пигмента { get; set; }
        public string Название_пигмента { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Процедуры_клиента> Процедуры_клиента { get; set; }
    }
}
