// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class QueryCustomerInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryCustomerInfoResponseBodyList> List { get; set; }
        public class QueryCustomerInfoResponseBodyList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>CUS_xxxxxxxx</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("contactAddress")]
            [Validation(Required=false)]
            public string ContactAddress { get; set; }

            [NameInMap("contactCompanyTelephone")]
            [Validation(Required=false)]
            public string ContactCompanyTelephone { get; set; }

            [NameInMap("contactEmail")]
            [Validation(Required=false)]
            public string ContactEmail { get; set; }

            [NameInMap("contactName")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            [NameInMap("contactTelephone")]
            [Validation(Required=false)]
            public string ContactTelephone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://www.abc.com">www.abc.com</a></para>
            /// </summary>
            [NameInMap("drawerEmail")]
            [Validation(Required=false)]
            public string DrawerEmail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12345678901</para>
            /// </summary>
            [NameInMap("drawerTelephone")]
            [Validation(Required=false)]
            public string DrawerTelephone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("purchaserAccount")]
            [Validation(Required=false)]
            public string PurchaserAccount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>杭州市</para>
            /// </summary>
            [NameInMap("purchaserAddress")]
            [Validation(Required=false)]
            public string PurchaserAddress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("purchaserName")]
            [Validation(Required=false)]
            public string PurchaserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("purchaserTaxNo")]
            [Validation(Required=false)]
            public string PurchaserTaxNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>13333333333</para>
            /// </summary>
            [NameInMap("purchaserTel")]
            [Validation(Required=false)]
            public string PurchaserTel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>建行</para>
            /// </summary>
            [NameInMap("purchaserrBankName")]
            [Validation(Required=false)]
            public string PurchaserrBankName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>valid</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>199200</para>
            /// </summary>
            [NameInMap("userDefineCode")]
            [Validation(Required=false)]
            public string UserDefineCode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
