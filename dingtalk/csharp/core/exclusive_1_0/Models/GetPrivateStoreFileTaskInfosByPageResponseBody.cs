// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetPrivateStoreFileTaskInfosByPageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasNext")]
        [Validation(Required=false)]
        public int? HasNext { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("itemCount")]
        [Validation(Required=false)]
        public int? ItemCount { get; set; }

        [NameInMap("items")]
        [Validation(Required=false)]
        public List<GetPrivateStoreFileTaskInfosByPageResponseBodyItems> Items { get; set; }
        public class GetPrivateStoreFileTaskInfosByPageResponseBodyItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("classTagId")]
            [Validation(Required=false)]
            public string ClassTagId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>大于 0 小于 1 等于 2</para>
            /// </summary>
            [NameInMap("classTagOperator")]
            [Validation(Required=false)]
            public string ClassTagOperator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>普通文件</para>
            /// </summary>
            [NameInMap("classTagText")]
            [Validation(Required=false)]
            public string ClassTagText { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("creatorLeaveStatus")]
            [Validation(Required=false)]
            public int? CreatorLeaveStatus { get; set; }

            [NameInMap("dealFileFormats")]
            [Validation(Required=false)]
            public List<string> DealFileFormats { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>大于等于 0 小于等于 1</para>
            /// </summary>
            [NameInMap("dealFileOperator")]
            [Validation(Required=false)]
            public int? DealFileOperator { get; set; }

            [NameInMap("dealFileScopes")]
            [Validation(Required=false)]
            public List<string> DealFileScopes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("dealFileSize")]
            [Validation(Required=false)]
            public long? DealFileSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("fileCreateTimeEnd")]
            [Validation(Required=false)]
            public long? FileCreateTimeEnd { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("fileCreateTimeStart")]
            [Validation(Required=false)]
            public long? FileCreateTimeStart { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("fileModifiedTimeEnd")]
            [Validation(Required=false)]
            public long? FileModifiedTimeEnd { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("fileModifiedTimeStart")]
            [Validation(Required=false)]
            public long? FileModifiedTimeStart { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("taskCreateTime")]
            [Validation(Required=false)]
            public long? TaskCreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>钉三多</para>
            /// </summary>
            [NameInMap("taskCreatorName")]
            [Validation(Required=false)]
            public string TaskCreatorName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>钉三多</para>
            /// </summary>
            [NameInMap("taskDeleterName")]
            [Validation(Required=false)]
            public string TaskDeleterName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>初始化完毕 0 正在删除 1 删除完成 2 正在回滚 3 回滚完成 4 数据初始化中 5  任务状态异常 6  待删除 7</para>
            /// </summary>
            [NameInMap("taskStatus")]
            [Validation(Required=false)]
            public int? TaskStatus { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
