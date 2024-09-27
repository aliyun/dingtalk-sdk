// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class ReportCustomerStatisticsRequest : TeaModel {
        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("groupOwnerUserIds")]
        [Validation(Required=false)]
        public List<string> GroupOwnerUserIds { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("groupTags")]
        [Validation(Required=false)]
        public List<string> GroupTags { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20220102</para>
        /// </summary>
        [NameInMap("maxDt")]
        [Validation(Required=false)]
        public string MaxDt { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20220101</para>
        /// </summary>
        [NameInMap("minDt")]
        [Validation(Required=false)]
        public string MinDt { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("openConversationIds")]
        [Validation(Required=false)]
        public List<string> OpenConversationIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>iFoqrhLQDtK</para>
        /// </summary>
        [NameInMap("openGroupSetId")]
        [Validation(Required=false)]
        public string OpenGroupSetId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iSoqrhLQDtK</para>
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

    }

}
