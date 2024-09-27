// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class BatchQueryCustomerSendTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-06-02 00:00:00</para>
        /// </summary>
        [NameInMap("gmtCreateEnd")]
        [Validation(Required=false)]
        public string GmtCreateEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-06-01 00:00:00</para>
        /// </summary>
        [NameInMap("gmtCreateStart")]
        [Validation(Required=false)]
        public string GmtCreateStart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("needRichStatistics")]
        [Validation(Required=false)]
        public bool? NeedRichStatistics { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("openBatchTaskIds")]
        [Validation(Required=false)]
        public List<string> OpenBatchTaskIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>哈哈哈</para>
        /// </summary>
        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
