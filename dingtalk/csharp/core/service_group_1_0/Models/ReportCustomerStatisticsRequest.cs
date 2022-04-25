// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class ReportCustomerStatisticsRequest : TeaModel {
        /// <summary>
        /// 群主列表
        /// </summary>
        [NameInMap("groupOwnerUserIds")]
        [Validation(Required=false)]
        public List<string> GroupOwnerUserIds { get; set; }

        /// <summary>
        /// 群标签列表
        /// </summary>
        [NameInMap("groupTags")]
        [Validation(Required=false)]
        public List<string> GroupTags { get; set; }

        /// <summary>
        /// 截止日期
        /// </summary>
        [NameInMap("maxDt")]
        [Validation(Required=false)]
        public string MaxDt { get; set; }

        /// <summary>
        /// 起始日期
        /// </summary>
        [NameInMap("minDt")]
        [Validation(Required=false)]
        public string MinDt { get; set; }

        /// <summary>
        /// 开放群id列表
        /// </summary>
        [NameInMap("openConversationIds")]
        [Validation(Required=false)]
        public List<string> OpenConversationIds { get; set; }

        /// <summary>
        /// 开放群组id
        /// </summary>
        [NameInMap("openGroupSetId")]
        [Validation(Required=false)]
        public string OpenGroupSetId { get; set; }

        /// <summary>
        /// 开发团队ID
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

    }

}
