// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkding_one_1_0.Models
{
    public class PushFeedRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public PushFeedRequestContent Content { get; set; }
        public class PushFeedRequestContent : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dsTemplate</para>
            /// </summary>
            [NameInMap("contentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("dslTemplateContent")]
            [Validation(Required=false)]
            public PushFeedRequestContentDslTemplateContent DslTemplateContent { get; set; }
            public class PushFeedRequestContentDslTemplateContent : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://xxxxx.xxx.com/v1.0/test.html">https://xxxxx.xxx.com/v1.0/test.html</a></para>
                /// </summary>
                [NameInMap("applyUrl")]
                [Validation(Required=false)]
                public string ApplyUrl { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;date&quot;:&quot;2025-11-06&quot;}</para>
                /// </summary>
                [NameInMap("body")]
                [Validation(Required=false)]
                public string Body { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1772177962000</para>
        /// </summary>
        [NameInMap("expireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("feedFeature")]
        [Validation(Required=false)]
        public Dictionary<string, object> FeedFeature { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iwElAqN6aXADBgQABQAGsO9WlNbxvoXaCN</para>
        /// </summary>
        [NameInMap("idempotentKey")]
        [Validation(Required=false)]
        public string IdempotentKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ntThCP2X44Fw73IXPUQiEiE</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
