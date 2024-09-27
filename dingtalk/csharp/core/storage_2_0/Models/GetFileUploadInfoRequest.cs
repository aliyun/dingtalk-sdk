// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_2_0.Models
{
    public class GetFileUploadInfoRequest : TeaModel {
        [NameInMap("option")]
        [Validation(Required=false)]
        public GetFileUploadInfoRequestOption Option { get; set; }
        public class GetFileUploadInfoRequestOption : TeaModel {
            [NameInMap("preCheckParam")]
            [Validation(Required=false)]
            public GetFileUploadInfoRequestOptionPreCheckParam PreCheckParam { get; set; }
            public class GetFileUploadInfoRequestOptionPreCheckParam : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>dentry_name</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

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
            /// <para>true</para>
            /// </summary>
            [NameInMap("preferIntranet")]
            [Validation(Required=false)]
            public bool? PreferIntranet { get; set; }

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
        /// <para>HEADER_SIGNATURE</para>
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

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
