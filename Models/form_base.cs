
namespace ClaimForm.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class form_base
    {
        [Required]
        [Display(Name ="Claim Bill Number")]
        public int ClaimBillNo { get; set; }
        [Required]
        [Display(Name = "Policy Number")]
        public Nullable<int> PolicyNo { get; set; }
        [Required]
        [Display(Name = "Policy Expiry Date")]
        public Nullable<System.DateTime> PoExpDate { get; set; }
        [Required]
        [Display(Name = "Client Name")]
        public string ClientName { get; set; }
        [Required]
        [Display(Name = "Client Address")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "City")]
        public string City { get; set; }
        [Required]
        [Display(Name = "Pincode")]
        public Nullable<int> Pincode { get; set; }
        [Required]
        [Display(Name = "Mobile")]
        public Nullable<int> Mobile { get; set; }
        [Required]
        [Display(Name = "Company Name")]
        public string CompName { get; set; }
        [Required]
        [Display(Name = "Model")]
        public string Model { get; set; }
        [Required]
        [Display(Name = "Serial Number")]
        public Nullable<int> SerialNo { get; set; }
        [Required]
        [Display(Name = "Year of Purchase")]
        public Nullable<int> YearOfPurchase { get; set; }
        [Required]
        [Display(Name = "Purchase From")]
        public string PurchaseFrom { get; set; }
        [Required]
        [Display(Name = "Purchase Bill Number")]
        public Nullable<int> PurchaseBillNo { get; set; }
        [Required]
        [Display(Name = "Date of Incident")]
        public Nullable<System.DateTime> DateOfIncident { get; set; }
        [Required]
        [Display(Name = "Incident Address")]
        public string IncidentAdd { get; set; }
        [Required]
        [Display(Name = "Incident Information")]
        public string Incidentinfo { get; set; }
        [Required]
        [Display(Name = "Fir Date")]
        public Nullable<System.DateTime> FirDate { get; set; }
        [Required]
        [Display(Name = "Police Station")]
        public string PoliceStation { get; set; }
        [Required]
        [Display(Name = "Claim Date")]
        public Nullable<System.DateTime> ClaimDate { get; set; }
        [Required]
        [Display(Name = "Claim by")]
        public string ClaimBy { get; set; }
        [Required]
        [Display(Name = "Claim Amount")]
        public Nullable<int> Claimamount { get; set; }
    }
}
