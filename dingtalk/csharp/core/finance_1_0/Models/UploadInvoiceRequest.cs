// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class UploadInvoiceRequest : TeaModel {
        [NameInMap("extension")]
        [Validation(Required=false)]
        public UploadInvoiceRequestExtension Extension { get; set; }
        public class UploadInvoiceRequestExtension : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TRIP</para>
            /// </summary>
            [NameInMap("bizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// 
            /// <b>Example:</b>
            /// <para>111924191922</para>
            /// </summary>
            [NameInMap("orderNo")]
            [Validation(Required=false)]
            [Obsolete]
            public string OrderNo { get; set; }

            [NameInMap("orderNoList")]
            [Validation(Required=false)]
            public List<string> OrderNoList { get; set; }

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
        public List<UploadInvoiceRequestInvoices> Invoices { get; set; }
        public class UploadInvoiceRequestInvoices : TeaModel {
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
            /// <b>Example:</b>
            /// <para>99.50</para>
            /// </summary>
            [NameInMap("withoutTaxAmount")]
            [Validation(Required=false)]
            public string WithoutTaxAmount { get; set; }

        }

        [NameInMap("userIdentity")]
        [Validation(Required=false)]
        public UploadInvoiceRequestUserIdentity UserIdentity { get; set; }
        public class UploadInvoiceRequestUserIdentity : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>95188</para>
            /// </summary>
            [NameInMap("mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>86</para>
            /// </summary>
            [NameInMap("mobileStateCode")]
            [Validation(Required=false)]
            public string MobileStateCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dinng1123434</para>
            /// </summary>
            [NameInMap("targetCorpId")]
            [Validation(Required=false)]
            public string TargetCorpId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STAFF_ID</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>akdfwiiw</para>
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>02734930</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
