//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Курсовая.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Характеристики_товара
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Характеристики_товара()
        {
            this.Товары = new HashSet<Товары>();
        }
    
        public int Код_характеристики { get; set; }
        public string Название { get; set; }
        public string Цвет { get; set; }
        public string Производители { get; set; }
        public string Вес_кг { get; set; }
        public string Гарантия_мес { get; set; }
        public Nullable<decimal> Стоимость { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Товары> Товары { get; set; }
    }
}
