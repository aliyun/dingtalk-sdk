// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class BatchQuerySendMessageTaskRequest : TeaModel {
        /// <summary>
        /// 是否获取群发任务已读数量，默认false
        /// </summary>
        [NameInMap("getReadCount")]
        [Validation(Required=false)]
        public bool? GetReadCount { get; set; }

        /// <summary>
        /// 任务查询结束时间
        /// </summary>
        [NameInMap("gmtCreateEnd")]
        [Validation(Required=false)]
        public string GmtCreateEnd { get; set; }

        /// <summary>
        /// 任务查询开始时间
        /// </summary>
        [NameInMap("gmtCreateStart")]
        [Validation(Required=false)]
        public string GmtCreateStart { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// 游标
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 开放群组ID，在服务群-群组- ID信息中获取
        /// </summary>
        [NameInMap("openGroupSetId")]
        [Validation(Required=false)]
        public string OpenGroupSetId { get; set; }

        /// <summary>
        /// 开放团队ID
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
