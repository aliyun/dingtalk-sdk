// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class GetLatestDingIndexResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("idxCarbon")]
        [Validation(Required=false)]
        public float? IdxCarbon { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("idxEfficiency")]
        [Validation(Required=false)]
        public float? IdxEfficiency { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("idxMonthlyAvg")]
        [Validation(Required=false)]
        public float? IdxMonthlyAvg { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("idxTotal")]
        [Validation(Required=false)]
        public float? IdxTotal { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("statDate")]
        [Validation(Required=false)]
        public string StatDate { get; set; }

    }

}
