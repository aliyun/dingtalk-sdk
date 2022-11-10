// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class ListRecycleItemsResponseBody : TeaModel {
        /// <summary>
        /// 分页游标
        /// 不为空表示有更多数据
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 回收项列表
        /// 最大size:
        /// 	50
        /// </summary>
        [NameInMap("recycleItems")]
        [Validation(Required=false)]
        public List<ListRecycleItemsResponseBodyRecycleItems> RecycleItems { get; set; }
        public class ListRecycleItemsResponseBodyRecycleItems : TeaModel {
            /// <summary>
            /// 原文件(夹)id
            /// </summary>
            [NameInMap("dentryId")]
            [Validation(Required=false)]
            public string DentryId { get; set; }

            /// <summary>
            /// 回收项id
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// 操作人id
            /// </summary>
            [NameInMap("operatorId")]
            [Validation(Required=false)]
            public string OperatorId { get; set; }

            /// <summary>
            /// 删除时间
            /// </summary>
            [NameInMap("operatorTime")]
            [Validation(Required=false)]
            public string OperatorTime { get; set; }

            /// <summary>
            /// 原文件(夹)名称
            /// </summary>
            [NameInMap("originalName")]
            [Validation(Required=false)]
            public string OriginalName { get; set; }

            /// <summary>
            /// 原文件(夹)路径
            /// </summary>
            [NameInMap("originalPath")]
            [Validation(Required=false)]
            public string OriginalPath { get; set; }

            /// <summary>
            /// 原文件(夹)大小
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// 原文件(夹)所在空间id
            /// </summary>
            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

            /// <summary>
            /// 类型，目录或文件
            /// 枚举值:
            /// 	FILE: 文件
            /// 	FOLDER: 文件夹
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
