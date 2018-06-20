namespace BuyTicket
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sean
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sean()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime Seans_Data { get; set; }

        public TimeSpan Seans_Time { get; set; }

        public int Price { get; set; }

        public int Film_Id { get; set; }

        public int Type_Id { get; set; }

        public int Hall_Id { get; set; }

        public virtual Film Film { get; set; }

        public virtual Hall Hall { get; set; }

        public virtual Type Type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
