// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateOrderFlowRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("actualAmount")]
        [Validation(Required=false)]
        public long? ActualAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2088112532248965</para>
        /// </summary>
        [NameInMap("alipayUid")]
        [Validation(Required=false)]
        public string AlipayUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1644413947909</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("detailList")]
        [Validation(Required=false)]
        public List<CreateOrderFlowRequestDetailList> DetailList { get; set; }
        public class CreateOrderFlowRequestDetailList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("actualAmount")]
            [Validation(Required=false)]
            public long? ActualAmount { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("itemAmount")]
            [Validation(Required=false)]
            public long? ItemAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("itemId")]
            [Validation(Required=false)]
            public long? ItemId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试商品</para>
            /// </summary>
            [NameInMap("itemName")]
            [Validation(Required=false)]
            public string ItemName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("scene")]
            [Validation(Required=false)]
            public long? Scene { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123123</para>
        /// </summary>
        [NameInMap("faceId")]
        [Validation(Required=false)]
        public string FaceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123455</para>
        /// </summary>
        [NameInMap("guardianUserId")]
        [Validation(Required=false)]
        public string GuardianUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2088821434894708</para>
        /// </summary>
        [NameInMap("merchantId")]
        [Validation(Required=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022012717252021400100822002</para>
        /// </summary>
        [NameInMap("orderNo")]
        [Validation(Required=false)]
        public string OrderNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>KSwZiSL1O7DiUNwjV168j3cP9ktp4bJTi5OQxAXre26KyBXza7+gCl/g1d0K3n3+9JhMqc2fUjBiENcAELw3Jb5xO/zslOeV4qFoMQfzW51+sdL/SSZCYvXEMhu9P6FAPhGZQ3vu6gr3oxUAXPIpWNb+sIfzR9epumoOXYeofH8=</para>
        /// </summary>
        [NameInMap("signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>QA62021121908E</para>
        /// </summary>
        [NameInMap("sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1644413947909</para>
        /// </summary>
        [NameInMap("timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalAmount")]
        [Validation(Required=false)]
        public long? TotalAmount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1643334234626</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
