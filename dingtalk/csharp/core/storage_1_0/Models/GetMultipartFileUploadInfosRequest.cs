// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class GetMultipartFileUploadInfosRequest : TeaModel {
        [NameInMap("option")]
        [Validation(Required=false)]
        public GetMultipartFileUploadInfosRequestOption Option { get; set; }
        public class GetMultipartFileUploadInfosRequestOption : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("preferIntranet")]
            [Validation(Required=false)]
            public bool? PreferIntranet { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("partNumbers")]
        [Validation(Required=false)]
        public List<int?> PartNumbers { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>upload_key</para>
        /// </summary>
        [NameInMap("uploadKey")]
        [Validation(Required=false)]
        public string UploadKey { get; set; }

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
