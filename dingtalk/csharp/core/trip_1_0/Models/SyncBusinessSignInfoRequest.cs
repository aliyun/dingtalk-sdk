// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class SyncBusinessSignInfoRequest : TeaModel {
        [NameInMap("bizTypeList")]
        [Validation(Required=false)]
        public List<string> BizTypeList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1661927020219</para>
        /// </summary>
        [NameInMap("gmtOrgPay")]
        [Validation(Required=false)]
        public string GmtOrgPay { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1661927020219</para>
        /// </summary>
        [NameInMap("gmtSign")]
        [Validation(Required=false)]
        public string GmtSign { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ORG_PAY</para>
        /// </summary>
        [NameInMap("orgPayStatus")]
        [Validation(Required=false)]
        public string OrgPayStatus { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SIGN</para>
        /// </summary>
        [NameInMap("signStatus")]
        [Validation(Required=false)]
        public string SignStatus { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ding89233847892ndkas</para>
        /// </summary>
        [NameInMap("targetCorpId")]
        [Validation(Required=false)]
        public string TargetCorpId { get; set; }

        [NameInMap("tmcProductDetailList")]
        [Validation(Required=false)]
        public List<SyncBusinessSignInfoRequestTmcProductDetailList> TmcProductDetailList { get; set; }
        public class SyncBusinessSignInfoRequestTmcProductDetailList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1661927020219</para>
            /// </summary>
            [NameInMap("gmtOrgPay")]
            [Validation(Required=false)]
            public string GmtOrgPay { get; set; }

            [NameInMap("payType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("product")]
            [Validation(Required=false)]
            public string Product { get; set; }

        }

        [NameInMap("tmcProductList")]
        [Validation(Required=false)]
        public List<SyncBusinessSignInfoRequestTmcProductList> TmcProductList { get; set; }
        public class SyncBusinessSignInfoRequestTmcProductList : TeaModel {
            [NameInMap("productDetailList")]
            [Validation(Required=false)]
            public List<SyncBusinessSignInfoRequestTmcProductListProductDetailList> ProductDetailList { get; set; }
            public class SyncBusinessSignInfoRequestTmcProductListProductDetailList : TeaModel {
                [NameInMap("categoryType")]
                [Validation(Required=false)]
                public string CategoryType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1661927020219</para>
                /// </summary>
                [NameInMap("gmtOrgPay")]
                [Validation(Required=false)]
                public string GmtOrgPay { get; set; }

                [NameInMap("openStatus")]
                [Validation(Required=false)]
                public bool? OpenStatus { get; set; }

                [NameInMap("payType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("product")]
                [Validation(Required=false)]
                public string Product { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("tmcCorpId")]
            [Validation(Required=false)]
            public string TmcCorpId { get; set; }

        }

    }

}
