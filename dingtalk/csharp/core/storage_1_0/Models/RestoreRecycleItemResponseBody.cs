// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class RestoreRecycleItemResponseBody : TeaModel {
        /// <summary>
        /// 是否是异步任务
        /// 如果操作对象有子节点，则会异步处理
        /// </summary>
        [NameInMap("async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        /// <summary>
        /// 操作对应根节点还原之后的文件id
        /// 非失败的情况下同步或者异步都会返回
        /// </summary>
        [NameInMap("dentryId")]
        [Validation(Required=false)]
        public string DentryId { get; set; }

        /// <summary>
        /// 操作对应根节点还原之后的空间id
        /// 非失败的情况下同步或者异步都会返回
        /// </summary>
        [NameInMap("spaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

        /// <summary>
        /// 异步任务id，用于查询任务执行状态
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
