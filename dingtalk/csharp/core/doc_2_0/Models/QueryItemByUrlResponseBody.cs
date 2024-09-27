// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class QueryItemByUrlResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>mainsite</para>
        /// </summary>
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("dentry")]
        [Validation(Required=false)]
        public DentryModel Dentry { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>file</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("space")]
        [Validation(Required=false)]
        public QueryItemByUrlResponseBodySpace Space { get; set; }
        public class QueryItemByUrlResponseBodySpace : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>这是知识库简介</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>YRBG******vJXDAr</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>这是知识库名称</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("owner")]
            [Validation(Required=false)]
            public QueryItemByUrlResponseBodySpaceOwner Owner { get; set; }
            public class QueryItemByUrlResponseBodySpaceOwner : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>小钉</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SgExXM*******L0tAiEiE</para>
                /// </summary>
                [NameInMap("unionId")]
                [Validation(Required=false)]
                public string UnionId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

    }

}
