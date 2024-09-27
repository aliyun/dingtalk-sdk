// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class UploadInvoiceByMobileRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("invoices")]
        [Validation(Required=false)]
        public List<UploadInvoiceByMobileRequestInvoices> Invoices { get; set; }
        public class UploadInvoiceByMobileRequestInvoices : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.00</para>
            /// </summary>
            [NameInMap("invoiceAmount")]
            [Validation(Required=false)]
            public string InvoiceAmount { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>033002000712</para>
            /// </summary>
            [NameInMap("invoiceCode")]
            [Validation(Required=false)]
            public string InvoiceCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-02-21</para>
            /// </summary>
            [NameInMap("invoiceDate")]
            [Validation(Required=false)]
            public string InvoiceDate { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20532643</para>
            /// </summary>
            [NameInMap("invoiceNo")]
            [Validation(Required=false)]
            public string InvoiceNo { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("invoiceType")]
            [Validation(Required=false)]
            public string InvoiceType { get; set; }

            [NameInMap("logoUrl")]
            [Validation(Required=false)]
            public string LogoUrl { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>小钉科技有限公司</para>
            /// </summary>
            [NameInMap("payeeName")]
            [Validation(Required=false)]
            public string PayeeName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>91330100MA28XNB274</para>
            /// </summary>
            [NameInMap("payeeTaxNo")]
            [Validation(Required=false)]
            public string PayeeTaxNo { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>小钉科技有限公司</para>
            /// </summary>
            [NameInMap("payerName")]
            [Validation(Required=false)]
            public string PayerName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>91330100MA28XNB274</para>
            /// </summary>
            [NameInMap("payerTaxNo")]
            [Validation(Required=false)]
            public string PayerTaxNo { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("pdfUrl")]
            [Validation(Required=false)]
            public string PdfUrl { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.50</para>
            /// </summary>
            [NameInMap("taxAmount")]
            [Validation(Required=false)]
            public string TaxAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>增值税普通发票必填，示例：52501101414266612380</para>
            /// </summary>
            [NameInMap("verifyCode")]
            [Validation(Required=false)]
            public string VerifyCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>99.50</para>
            /// </summary>
            [NameInMap("withoutTaxAmount")]
            [Validation(Required=false)]
            public string WithoutTaxAmount { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13600000000</para>
        /// </summary>
        [NameInMap("mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86</para>
        /// </summary>
        [NameInMap("mobileStateCode")]
        [Validation(Required=false)]
        public string MobileStateCode { get; set; }

    }

}
