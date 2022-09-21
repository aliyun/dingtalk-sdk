// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class QueryItemByUrlResponseBody : TeaModel {
        /// <summary>
        /// 业务类型。可选值：dingpan-云盘中的文档；mainsite-知识库中的文档。
        /// </summary>
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("dentry")]
        [Validation(Required=false)]
        public DentryModel Dentry { get; set; }

        /// <summary>
        /// 资源类型。可选值有：space-知识库；file-文档；folder-文件夹。
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 当resourceType为space时，这里会返回知识库信息。
        /// </summary>
        [NameInMap("space")]
        [Validation(Required=false)]
        public QueryItemByUrlResponseBodySpace Space { get; set; }
        public class QueryItemByUrlResponseBodySpace : TeaModel {
            /// <summary>
            /// 知识库简介。
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 知识库id。
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// 知识库名称。
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 如果type=2，会返回其所有者。
            /// </summary>
            [NameInMap("owner")]
            [Validation(Required=false)]
            public QueryItemByUrlResponseBodySpaceOwner Owner { get; set; }
            public class QueryItemByUrlResponseBodySpaceOwner : TeaModel {
                /// <summary>
                /// 知识库所有者名称。
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 知识库所有者的unionId。
                /// </summary>
                [NameInMap("unionId")]
                [Validation(Required=false)]
                public string UnionId { get; set; }

            }

            /// <summary>
            /// 知识库类型。1-知识库；2-我的文档。
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

    }

}
