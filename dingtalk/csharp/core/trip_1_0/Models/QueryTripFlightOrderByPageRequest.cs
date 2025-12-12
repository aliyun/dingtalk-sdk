// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class QueryTripFlightOrderByPageRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-12-01</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("orderStatus")]
        [Validation(Required=false)]
        public List<string> OrderStatus { get; set; }

        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-11-11</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
