// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbadge_1_0.Models
{
    public class CreateBadgeCodeUserInstanceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("availableTimes")]
        [Validation(Required=false)]
        public List<CreateBadgeCodeUserInstanceRequestAvailableTimes> AvailableTimes { get; set; }
        public class CreateBadgeCodeUserInstanceRequestAvailableTimes : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yyyy-MM-dd HH:mm:ss</para>
            /// </summary>
            [NameInMap("gmtEnd")]
            [Validation(Required=false)]
            public string GmtEnd { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yyyy-MM-dd HH:mm:ss</para>
            /// </summary>
            [NameInMap("gmtStart")]
            [Validation(Required=false)]
            public string GmtStart { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TEST</para>
        /// </summary>
        [NameInMap("codeIdentity")]
        [Validation(Required=false)]
        public string CodeIdentity { get; set; }

        [NameInMap("codeValue")]
        [Validation(Required=false)]
        public string CodeValue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DING_STATIC</para>
        /// </summary>
        [NameInMap("codeValueType")]
        [Validation(Required=false)]
        public string CodeValueType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>corpid1234</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("extInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtInfo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yyyy-MM-dd HH:mm:ss</para>
        /// </summary>
        [NameInMap("gmtExpired")]
        [Validation(Required=false)]
        public string GmtExpired { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>202102021212</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OPEN</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INTERNAL_STAFF</para>
        /// </summary>
        [NameInMap("userCorpRelationType")]
        [Validation(Required=false)]
        public string UserCorpRelationType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86-xxxxxx</para>
        /// </summary>
        [NameInMap("userIdentity")]
        [Validation(Required=false)]
        public string UserIdentity { get; set; }

    }

}
