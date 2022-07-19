// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class DeleteDentryResponseBody : TeaModel {
        /// <summary>
        /// 是否是异步任务
        /// 如果操作对象有子节点，则会异步处理
        /// </summary>
        [NameInMap("async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        /// <summary>
        /// 任务Id，用于查询任务执行状态; 查询接口开发中
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
