// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdrive_1_0.Models
{
    public class ListRecycleFilesResponseBody : TeaModel {
        /// <summary>
        /// 加载更多锚点, nextToken不为空表示有更多数据
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 回收站文件列表
        /// </summary>
        [NameInMap("recycleItems")]
        [Validation(Required=false)]
        public List<ListRecycleFilesResponseBodyRecycleItems> RecycleItems { get; set; }
        public class ListRecycleFilesResponseBodyRecycleItems : TeaModel {
            /// <summary>
            /// 文件内容类型
            /// </summary>
            [NameInMap("contentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// 删除员工工号
            /// </summary>
            [NameInMap("deleteStaffId")]
            [Validation(Required=false)]
            public string DeleteStaffId { get; set; }

            /// <summary>
            /// 删除时间
            /// </summary>
            [NameInMap("deleteTime")]
            [Validation(Required=false)]
            public string DeleteTime { get; set; }

            /// <summary>
            /// 文件名称
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// 文件路径
            /// </summary>
            [NameInMap("filePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// 文件大小
            /// </summary>
            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// 文件类型
            /// </summary>
            [NameInMap("fileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// 回收站item id
            /// </summary>
            [NameInMap("recycleItemId")]
            [Validation(Required=false)]
            public string RecycleItemId { get; set; }

        }

    }

}
