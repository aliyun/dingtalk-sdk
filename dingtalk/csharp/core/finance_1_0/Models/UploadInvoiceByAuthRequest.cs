// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class UploadInvoiceByAuthRequest : TeaModel {
        [NameInMap("extension")]
        [Validation(Required=false)]
        public UploadInvoiceByAuthRequestExtension Extension { get; set; }
        public class UploadInvoiceByAuthRequestExtension : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TRIP</para>
            /// </summary>
            [NameInMap("bizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>111924191922</para>
            /// </summary>
            [NameInMap("orderNo")]
            [Validation(Required=false)]
            public string OrderNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>HOTEL</para>
            /// </summary>
            [NameInMap("orderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("invoices")]
        [Validation(Required=false)]
        public List<UploadInvoiceByAuthRequestInvoices> Invoices { get; set; }
        public class UploadInvoiceByAuthRequestInvoices : TeaModel {
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

    }

}
