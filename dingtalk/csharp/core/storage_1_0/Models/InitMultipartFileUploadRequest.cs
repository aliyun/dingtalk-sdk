// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class InitMultipartFileUploadRequest : TeaModel {
        [NameInMap("option")]
        [Validation(Required=false)]
        public InitMultipartFileUploadRequestOption Option { get; set; }
        public class InitMultipartFileUploadRequestOption : TeaModel {
            [NameInMap("preCheckParam")]
            [Validation(Required=false)]
            public InitMultipartFileUploadRequestOptionPreCheckParam PreCheckParam { get; set; }
            public class InitMultipartFileUploadRequestOptionPreCheckParam : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>md5</para>
                /// </summary>
                [NameInMap("md5")]
                [Validation(Required=false)]
                public string Md5 { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dentry_name</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>parent_id</para>
                /// </summary>
                [NameInMap("parentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>512</para>
                /// </summary>
                [NameInMap("size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ZHANGJIAKOU</para>
            /// </summary>
            [NameInMap("preferRegion")]
            [Validation(Required=false)]
            public string PreferRegion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DINGTALK</para>
            /// </summary>
            [NameInMap("storageDriver")]
            [Validation(Required=false)]
            public string StorageDriver { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>union_id</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
