// This class was generated on Tue, 30 Jan 2018 11:15:39 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// SaleGetRequest.cs
// @version 0.1.0-dev+6beb51-dirty
// @type request
// @data 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
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// Shows details for a sale, by ID. Returns only sales that were created through the REST API.
    /// </summary>
    public class SaleGetRequest : HttpRequest
    {
        public SaleGetRequest(string SaleId) : base("/v1/payments/sale/{sale_id}?", HttpMethod.Get, typeof(Sale))
        {
            try {
                this.Path = this.Path.Replace("{sale_id}", Uri.EscapeDataString(Convert.ToString(SaleId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        
    }
}
