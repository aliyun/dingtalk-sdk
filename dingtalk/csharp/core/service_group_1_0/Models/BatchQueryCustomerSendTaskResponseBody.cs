// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class BatchQueryCustomerSendTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8888</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("records")]
        [Validation(Required=false)]
        public List<BatchQueryCustomerSendTaskResponseBodyRecords> Records { get; set; }
        public class BatchQueryCustomerSendTaskResponseBodyRecords : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("createName")]
            [Validation(Required=false)]
            public string CreateName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-07-14 10:00:00</para>
            /// </summary>
            [NameInMap("createTimeStr")]
            [Validation(Required=false)]
            public string CreateTimeStr { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>88888</para>
            /// </summary>
            [NameInMap("createUnionId")]
            [Validation(Required=false)]
            public string CreateUnionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>88888</para>
            /// </summary>
            [NameInMap("openBatchTaskId")]
            [Validation(Required=false)]
            public string OpenBatchTaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("readCustomerInc")]
            [Validation(Required=false)]
            public long? ReadCustomerInc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("readUserInc")]
            [Validation(Required=false)]
            public long? ReadUserInc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("sendCustomerInc")]
            [Validation(Required=false)]
            public long? SendCustomerInc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>UNFINISH 未完成 FINISHED 已发送 CANCELED 已取消 CREATE_TASK_FAILED 创建任务失败  SENDING 发送中</para>
            /// </summary>
            [NameInMap("sendMessageStatus")]
            [Validation(Required=false)]
            public string SendMessageStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-07-14 11:00:00</para>
            /// </summary>
            [NameInMap("sendTaskTimeStr")]
            [Validation(Required=false)]
            public string SendTaskTimeStr { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("sendUserInc")]
            [Validation(Required=false)]
            public long? SendUserInc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>任务名称</para>
            /// </summary>
            [NameInMap("taskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
