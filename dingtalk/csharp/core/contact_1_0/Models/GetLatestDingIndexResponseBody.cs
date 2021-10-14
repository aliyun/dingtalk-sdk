// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class GetLatestDingIndexResponseBody : TeaModel {
        /// <summary>
        /// 绿色指数
        /// </summary>
        [NameInMap("idxCarbon")]
        [Validation(Required=false)]
        public float? IdxCarbon { get; set; }

        /// <summary>
        /// 效率指数
        /// </summary>
        [NameInMap("idxEfficiency")]
        [Validation(Required=false)]
        public float? IdxEfficiency { get; set; }

        /// <summary>
        /// 钉钉指数月均分
        /// </summary>
        [NameInMap("idxMonthlyAvg")]
        [Validation(Required=false)]
        public float? IdxMonthlyAvg { get; set; }

        /// <summary>
        /// 钉钉指数
        /// </summary>
        [NameInMap("idxTotal")]
        [Validation(Required=false)]
        public float? IdxTotal { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [NameInMap("statDate")]
        [Validation(Required=false)]
        public string StatDate { get; set; }

    }

}
