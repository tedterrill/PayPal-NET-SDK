// This class was generated on Tue, 30 Jan 2018 11:15:39 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// PaymentListRequest.cs
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
    /// Lists payments that were created by the [create payment](#payment_create) call and that are in any state. The list shows the payments that are made to the merchant who makes the call. To filter the payments that appear in the response, you can specify one or more optional query and pagination parameters. See [Filtering and pagination](/docs/api/overview/#query-parameters).
    /// </summary>
    public class PaymentListRequest : HttpRequest
    {
        public PaymentListRequest() : base("/v1/payments/payment?", HttpMethod.Get, typeof(PaymentHistory))
        {
            
            this.ContentType =  "application/json";
        }

        public PaymentListRequest Count(int Count)
        {
            var strParams = Convert.ToString(Count);
            try {
                this.Path = $"{this.Path}count={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public PaymentListRequest EndTime(string EndTime)
        {
            var strParams = Convert.ToString(EndTime);
            try {
                this.Path = $"{this.Path}end_time={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public PaymentListRequest PayeeId(string PayeeId)
        {
            var strParams = Convert.ToString(PayeeId);
            try {
                this.Path = $"{this.Path}payee_id={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public PaymentListRequest SortBy(string SortBy)
        {
            var strParams = Convert.ToString(SortBy);
            try {
                this.Path = $"{this.Path}sort_by={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public PaymentListRequest SortOrder(string SortOrder)
        {
            var strParams = Convert.ToString(SortOrder);
            try {
                this.Path = $"{this.Path}sort_order={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public PaymentListRequest StartId(string StartId)
        {
            var strParams = Convert.ToString(StartId);
            try {
                this.Path = $"{this.Path}start_id={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public PaymentListRequest StartIndex(int StartIndex)
        {
            var strParams = Convert.ToString(StartIndex);
            try {
                this.Path = $"{this.Path}start_index={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public PaymentListRequest StartTime(string StartTime)
        {
            var strParams = Convert.ToString(StartTime);
            try {
                this.Path = $"{this.Path}start_time={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        
        
    }
}
