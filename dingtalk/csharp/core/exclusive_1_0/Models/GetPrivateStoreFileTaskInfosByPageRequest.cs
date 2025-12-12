// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetPrivateStoreFileTaskInfosByPageRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>初始化完毕 0 正在删除 1 删除完成 2 正在回滚 3 回滚完成 4 数据初始化中 5  任务状态异常 6  待删除 7</para>
        /// </summary>
        [NameInMap("taskStatus")]
        [Validation(Required=false)]
        public int? TaskStatus { get; set; }

    }

}
