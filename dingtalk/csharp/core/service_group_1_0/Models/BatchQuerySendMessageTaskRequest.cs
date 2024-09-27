// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class BatchQuerySendMessageTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("getReadCount")]
        [Validation(Required=false)]
        public bool? GetReadCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-04-02 00:00:00</para>
        /// </summary>
        [NameInMap("gmtCreateEnd")]
        [Validation(Required=false)]
        public string GmtCreateEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-04-01 00:00:00</para>
        /// </summary>
        [NameInMap("gmtCreateStart")]
        [Validation(Required=false)]
        public string GmtCreateStart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>首页传递空</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fwPuycdHiiI</para>
        /// </summary>
        [NameInMap("openGroupSetId")]
        [Validation(Required=false)]
        public string OpenGroupSetId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Jciwnfw</para>
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>群发任务双11</para>
        /// </summary>
        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
