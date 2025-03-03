// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_2_0.Models
{
    public class ListOperationLogsResponseBody : TeaModel {
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListOperationLogsResponseBodyItems> Items { get; set; }
        public class ListOperationLogsResponseBodyItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>add_permission</para>
            /// </summary>
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>「我的文档/无标题文档」，给用户“你好”添加了「可编辑」权限</para>
            /// </summary>
            [NameInMap("details")]
            [Validation(Required=false)]
            public string Details { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ovEQ1aYDoUrM8NldI7EPaDEuDfNce#AR4GpnMqJzRQ67PpuNNDQn9dJKe0xjE3&amp;USER:1557011407</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("operateTime")]
            [Validation(Required=false)]
            public long? OperateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>union_id</para>
            /// </summary>
            [NameInMap("operatorId")]
            [Validation(Required=false)]
            public string OperatorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>org_biz_meta_my_doc</para>
            /// </summary>
            [NameInMap("scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AR4GpnMqJzRQ67PpuNNDQn9dJKe0xjE3</para>
            /// </summary>
            [NameInMap("subjectId")]
            [Validation(Required=false)]
            public string SubjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>无标题文档</para>
            /// </summary>
            [NameInMap("subjectName")]
            [Validation(Required=false)]
            public string SubjectName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DENTRY</para>
            /// </summary>
            [NameInMap("subjectType")]
            [Validation(Required=false)]
            public string SubjectType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://alidocs.dingtalk.com/i/nodes/AR4GpnMqJzRQ67PpuNNDQn9dJKe0xjE3">https://alidocs.dingtalk.com/i/nodes/AR4GpnMqJzRQ67PpuNNDQn9dJKe0xjE3</a></para>
            /// </summary>
            [NameInMap("subjectUrl")]
            [Validation(Required=false)]
            public string SubjectUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>next_token</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
