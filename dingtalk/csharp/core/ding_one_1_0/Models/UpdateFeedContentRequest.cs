// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkding_one_1_0.Models
{
    public class UpdateFeedContentRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public UpdateFeedContentRequestContent Content { get; set; }
        public class UpdateFeedContentRequestContent : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dslTemplate</para>
            /// </summary>
            [NameInMap("contentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("dslTemplateContent")]
            [Validation(Required=false)]
            public UpdateFeedContentRequestContentDslTemplateContent DslTemplateContent { get; set; }
            public class UpdateFeedContentRequestContentDslTemplateContent : TeaModel {
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
        /// <para>dd-one-work-eSo869uR9Vhse2sqTw3dDF</para>
        /// </summary>
        [NameInMap("feedId")]
        [Validation(Required=false)]
        public string FeedId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ntThCP2X44FlskVliPIXPUQiEiE</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
