// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class GetFileUploadInfoRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("multipart")]
        [Validation(Required=false)]
        public bool? Multipart { get; set; }

        [NameInMap("option")]
        [Validation(Required=false)]
        public GetFileUploadInfoRequestOption Option { get; set; }
        public class GetFileUploadInfoRequestOption : TeaModel {
            [NameInMap("preCheckParam")]
            [Validation(Required=false)]
            public GetFileUploadInfoRequestOptionPreCheckParam PreCheckParam { get; set; }
            public class GetFileUploadInfoRequestOptionPreCheckParam : TeaModel {
                [NameInMap("md5")]
                [Validation(Required=false)]
                public string Md5 { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("parentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                [NameInMap("size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

            }

            [NameInMap("preferIntranet")]
            [Validation(Required=false)]
            public bool? PreferIntranet { get; set; }

            [NameInMap("preferRegion")]
            [Validation(Required=false)]
            public string PreferRegion { get; set; }

            [NameInMap("storageDriver")]
            [Validation(Required=false)]
            public string StorageDriver { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
