using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NoviInterviewMiniProject.Models
{
    public class MemberResult
    {
        public string UniqueID { get; set; }
        public string ParentCustomerUniqueID { get; set; }
        public string ParentMemberName { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public object Suffix { get; set; }
        public bool Active { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public object Fax { get; set; }
        public string Website { get; set; }
        public string County { get; set; }
        public Billingaddress BillingAddress { get; set; }
        public Shippingaddress ShippingAddress { get; set; }
        public object PersonalEmail { get; set; }
        public object PersonalPhone { get; set; }
        public object PersonalMobile { get; set; }
        public Personaladdress PersonalAddress { get; set; }
        public object Notes { get; set; }
        public string FacebookUrl { get; set; }
        public object LinkedInUrl { get; set; }
        public object InstagramHandle { get; set; }
        public string TwitterHandle { get; set; }
        public string MemberProfile { get; set; }
        public object JobTitle { get; set; }
        public string Image { get; set; }
        public DateTime? OriginalJoinDate { get; set; }
        [Display(Name = "Member Since")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? MemberSince { get; set; }
        public DateTime? MembershipExpires { get; set; }
        [Display(Name = "Member Status")]
        public string MemberStatus { get; set; }
        public object MemberSubStatus { get; set; }
        public bool HideOnWebsite { get; set; }
        public bool HideContactInformation { get; set; }
        public bool UnsubscribeFromEmails { get; set; }
        public bool Approved { get; set; }
        public bool AutoRenew { get; set; }
        public Membertype MemberType { get; set; }
        [Display(Name = "Customer Type")]
        public string CustomerType { get; set; }
        public Customfields CustomFields { get; set; }
        public string[] SpecifiedSystemFields { get; set; }
        public object QuickBooksID { get; set; }
        public bool UseParentBilling { get; set; }
        public bool UseParentShipping { get; set; }
        public object Credentials { get; set; }
        public object Title { get; set; }
        public object[] DirectoryGallery { get; set; }
        public object[] Awards { get; set; }
        public object[] VolunteerWorks { get; set; }
        public object[] Education { get; set; }
        public Group[] Groups { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public object PrimaryContactUniqueId { get; set; }
        public object BillingContactUniqueId { get; set; }
    }
}