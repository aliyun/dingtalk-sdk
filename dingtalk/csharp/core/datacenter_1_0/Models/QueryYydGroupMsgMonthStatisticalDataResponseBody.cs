// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class QueryYydGroupMsgMonthStatisticalDataResponseBody : TeaModel {
        /// <summary>
        /// 指标数据
        /// </summary>
        [NameInMap("dataList")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> DataList { get; set; }

        /// <summary>
        /// 指标元数据
        /// </summary>
        [NameInMap("metaList")]
        [Validation(Required=false)]
        public List<QueryYydGroupMsgMonthStatisticalDataResponseBodyMetaList> MetaList { get; set; }
        public class QueryYydGroupMsgMonthStatisticalDataResponseBodyMetaList : TeaModel {
            /// <summary>
            /// 指标ID
            /// </summary>
            [NameInMap("kpiId")]
            [Validation(Required=false)]
            public string KpiId { get; set; }

            /// <summary>
            /// 指标名称
            /// </summary>
            [NameInMap("kpiName")]
            [Validation(Required=false)]
            public string KpiName { get; set; }

            /// <summary>
            /// 指标单位
            /// </summary>
            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

            /// <summary>
            /// 指标口径
            /// </summary>
            [NameInMap("kpiCaliber")]
            [Validation(Required=false)]
            public string KpiCaliber { get; set; }

            /// <summary>
            /// 指标周期
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public string Period { get; set; }

        }

    }

}
