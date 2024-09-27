// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ListAuditLogRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1577945731837</para>
        /// </summary>
        [NameInMap("endDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6406817113</para>
        /// </summary>
        [NameInMap("nextBizId")]
        [Validation(Required=false)]
        public long? NextBizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1577340931837</para>
        /// </summary>
        [NameInMap("nextGmtCreate")]
        [Validation(Required=false)]
        public long? NextGmtCreate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1577340931837</para>
        /// </summary>
        [NameInMap("startDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

    }

}
