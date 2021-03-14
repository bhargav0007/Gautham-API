using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace MSB.Payments.Model.Vantiv.OnBoarding.APIRequests
{
    [Serializable]
    public class CreateSubmerchantModel : BaseModel
    {
        public class ExpressSubAccount
        {
            [JsonPropertyName("batchCloseMethod")]
            public string BatchCloseMethod { get; set; }

            [JsonPropertyName("batchCloseTime")]
            public string BatchCloseTime { get; set; }

            [JsonPropertyName("checkForDuplicateTransactions")]
            public string CheckForDuplicateTransactions { get; set; }

            [JsonPropertyName("enableCommercialCardBINQuery")]
            public string EnableCommercialCardBINQuery { get; set; }
        }

        public class IssuedId
        {
            [JsonPropertyName("idType")]
            public string IdType { get; set; }

            [JsonPropertyName("idNumber")]
            public string IdNumber { get; set; }

            [JsonPropertyName("issuedCity")]
            public string IssuedCity { get; set; }

            [JsonPropertyName("issuedState")]
            public string IssuedState { get; set; }

            [JsonPropertyName("issuedCountry")]
            public string IssuedCountry { get; set; }

            [JsonPropertyName("dateIssued")]
            public string DateIssued { get; set; }

            [JsonPropertyName("dateExpires")]
            public string DateExpires { get; set; }
        }

        public class Owner
        {
            [JsonPropertyName("type")]
            public string Type { get; set; }

            [JsonPropertyName("title")]
            public string Title { get; set; }

            [JsonPropertyName("firstName")]
            public string FirstName { get; set; }

            [JsonPropertyName("middleInitial")]
            public string MiddleInitial { get; set; }

            [JsonPropertyName("lastName")]
            public string LastName { get; set; }

            [JsonPropertyName("phoneNumber")]
            public string PhoneNumber { get; set; }

            [JsonPropertyName("phoneNumberExt")]
            public string PhoneNumberExt { get; set; }

            [JsonPropertyName("faxNumber")]
            public string FaxNumber { get; set; }

            [JsonPropertyName("email")]
            public string Email { get; set; }

            [JsonPropertyName("ownershipPercentage")]
            public string OwnershipPercentage { get; set; }

            [JsonPropertyName("ssn")]
            public string Ssn { get; set; }

            [JsonPropertyName("dob")]
            public string Dob { get; set; }

            [JsonPropertyName("addressLine1")]
            public string AddressLine1 { get; set; }

            [JsonPropertyName("addressLine2")]
            public string AddressLine2 { get; set; }

            [JsonPropertyName("city")]
            public string City { get; set; }

            [JsonPropertyName("state")]
            public string State { get; set; }

            [JsonPropertyName("country")]
            public string Country { get; set; }

            [JsonPropertyName("postalCode")]
            public string PostalCode { get; set; }

            [JsonPropertyName("postalCodeExtension")]
            public string PostalCodeExtension { get; set; }

            [JsonPropertyName("issuedIds")]
            public List<IssuedId> IssuedIds { get; set; }
        }

        public class Contact
        {
            [JsonPropertyName("title")]
            public string Title { get; set; }

            [JsonPropertyName("firstName")]
            public string FirstName { get; set; }

            [JsonPropertyName("middleInitial")]
            public string MiddleInitial { get; set; }

            [JsonPropertyName("lastName")]
            public string LastName { get; set; }

            [JsonPropertyName("phoneNumber")]
            public string PhoneNumber { get; set; }

            [JsonPropertyName("phoneNumberExt")]
            public string PhoneNumberExt { get; set; }

            [JsonPropertyName("email")]
            public string Email { get; set; }

            [JsonPropertyName("faxNumber")]
            public string FaxNumber { get; set; }

            [JsonPropertyName("type")]
            public string Type { get; set; }
        }

        public class Address
        {
            [JsonPropertyName("type")]
            public string Type { get; set; }

            [JsonPropertyName("addressLine1")]
            public string AddressLine1 { get; set; }

            [JsonPropertyName("addressLine2")]
            public string AddressLine2 { get; set; }

            [JsonPropertyName("city")]
            public string City { get; set; }

            [JsonPropertyName("state")]
            public string State { get; set; }

            [JsonPropertyName("country")]
            public string Country { get; set; }

            [JsonPropertyName("postalCode")]
            public string PostalCode { get; set; }

            [JsonPropertyName("postalCodeExtension")]
            public string PostalCodeExtension { get; set; }
        }

        public class Attribute
        {
            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("value")]
            public string Value { get; set; }
        }

        public class AcceptedCard
        {
            [JsonPropertyName("type")]
            public string Type { get; set; }

            [JsonPropertyName("attributes")]
            public List<Attribute> Attributes { get; set; }
        }

        public class DefaultBankAccount
        {
            [JsonPropertyName("ddaType")]
            public string DdaType { get; set; }

            [JsonPropertyName("achType")]
            public string AchType { get; set; }

            [JsonPropertyName("accountNumber")]
            public string AccountNumber { get; set; }

            [JsonPropertyName("routingNumber")]
            public string RoutingNumber { get; set; }
        }

        public class BankAccount
        {
            [JsonPropertyName("ddaType")]
            public string DdaType { get; set; }

            [JsonPropertyName("achType")]
            public string AchType { get; set; }

            [JsonPropertyName("accountNumber")]
            public string AccountNumber { get; set; }

            [JsonPropertyName("routingNumber")]
            public string RoutingNumber { get; set; }
        }

        public class AdvancedSettlementAccount
        {
            [JsonPropertyName("bankAccount")]
            public BankAccount BankAccount { get; set; }

            [JsonPropertyName("settlementCategories")]
            public List<string> SettlementCategories { get; set; }

            [JsonPropertyName("oneACHForAllCategories")]
            public string OneACHForAllCategories { get; set; }

            [JsonPropertyName("oneACHForCreditAndDebit")]
            public string OneACHForCreditAndDebit { get; set; }
        }

        public class Root
        {
            [Required]
            [JsonPropertyName("uuid")]
            public string Uuid { get; set; }
            [Required]
            [JsonPropertyName("chainCode")]
            public string ChainCode { get; set; }

            [JsonPropertyName("storeNumber")]
            public string StoreNumber { get; set; }

            [JsonPropertyName("divisionCode")]
            public string DivisionCode { get; set; }
            [Required]
            [JsonPropertyName("federalTaxId")]
            public string FederalTaxId { get; set; }
            [Required]
            [JsonPropertyName("legalName")]
            public string LegalName { get; set; }
            [Required]
            [JsonPropertyName("dbaName")]
            public string DbaName { get; set; }
            [Required]
            [JsonPropertyName("billingDescriptor")]
            public string BillingDescriptor { get; set; }
            [Required]
            [JsonPropertyName("ownershipType")]
            public string OwnershipType { get; set; }
            [Required]
            [JsonPropertyName("businessType")]
            public string BusinessType { get; set; }
            [Required]
            [JsonPropertyName("mccCode")]
            public string MccCode { get; set; }
            [Required]
            [JsonPropertyName("businessEstablishedDate")]
            public string BusinessEstablishedDate { get; set; }
            [Required]
            [JsonPropertyName("websiteUrl")]
            public string WebsiteUrl { get; set; }

            [JsonPropertyName("addTerminals")]
            public string AddTerminals { get; set; }

            [JsonPropertyName("expressSubAccount")]
            public ExpressSubAccount ExpressSubAccount { get; set; }

            [JsonPropertyName("owners")]
            public List<Owner> Owners { get; set; }
            [Required]
            [JsonPropertyName("contacts")]
            public List<Contact> Contacts { get; set; }
            [Required]
            [JsonPropertyName("addresses")]
            public List<Address> Addresses { get; set; }
            [Required]
            [JsonPropertyName("acceptedCards")]
            public List<AcceptedCard> AcceptedCards { get; set; }
            [Required]
            [JsonPropertyName("defaultBankAccount")]
            public DefaultBankAccount DefaultBankAccount { get; set; }

            [JsonPropertyName("advancedSettlementAccounts")]
            public List<AdvancedSettlementAccount> AdvancedSettlementAccounts { get; set; }
        }


    }
}
