// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class QueryYydDingMsgMonthStatisticalDataResponseBody : TeaModel {
        [NameInMap("dataList")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> DataList { get; set; }

        [NameInMap("metaList")]
        [Validation(Required=false)]
        public List<QueryYydDingMsgMonthStatisticalDataResponseBodyMetaList> MetaList { get; set; }
        public class QueryYydDingMsgMonthStatisticalDataResponseBodyMetaList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("kpiCaliber")]
            [Validation(Required=false)]
            public string KpiCaliber { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("kpiId")]
            [Validation(Required=false)]
            public string KpiId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("kpiName")]
            [Validation(Required=false)]
            public string KpiName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public string Period { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

    }

}
