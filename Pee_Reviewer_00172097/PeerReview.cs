//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pee_Reviewer_00172097
{
    using System;
    using System.Collections.Generic;
    
    public partial class PeerReview
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PeerReview()
        {
            this.Comments = new HashSet<Comment>();
        }
    
        public int Id { get; set; }
        public Nullable<System.DateTime> DOR { get; set; }
        public Nullable<int> reviewerId { get; set; }
        public Nullable<int> docId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual Reviewer Reviewer { get; set; }
        public virtual ResearchWork ResearchWork { get; set; }
    }
}