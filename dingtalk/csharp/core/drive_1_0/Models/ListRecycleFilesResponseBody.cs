// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdrive_1_0.Models
{
    public class ListRecycleFilesResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("recycleItems")]
        [Validation(Required=false)]
        public List<ListRecycleFilesResponseBodyRecycleItems> RecycleItems { get; set; }
        public class ListRecycleFilesResponseBodyRecycleItems : TeaModel {
            [NameInMap("contentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("deleteStaffId")]
            [Validation(Required=false)]
            public string DeleteStaffId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// 
            /// Use the UTC time format: yyyy-MM-ddTHH:mmZ
            /// </summary>
            [NameInMap("deleteTime")]
            [Validation(Required=false)]
            public string DeleteTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("filePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("fileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("recycleItemId")]
            [Validation(Required=false)]
            public string RecycleItemId { get; set; }

        }

    }

}
