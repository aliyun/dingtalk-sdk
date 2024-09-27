// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class BillSettementFlightRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public long? Category { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>corpx</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-10-01</para>
        /// </summary>
        [NameInMap("periodEnd")]
        [Validation(Required=false)]
        public string PeriodEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-10-01</para>
        /// </summary>
        [NameInMap("periodStart")]
        [Validation(Required=false)]
        public string PeriodStart { get; set; }

    }

}
