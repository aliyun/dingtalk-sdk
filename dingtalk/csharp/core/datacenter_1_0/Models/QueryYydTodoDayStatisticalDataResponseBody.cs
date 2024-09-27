// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class QueryYydTodoDayStatisticalDataResponseBody : TeaModel {
        [NameInMap("dataList")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> DataList { get; set; }

        [NameInMap("metaList")]
        [Validation(Required=false)]
        public List<QueryYydTodoDayStatisticalDataResponseBodyMetaList> MetaList { get; set; }
        public class QueryYydTodoDayStatisticalDataResponseBodyMetaList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("kpiCaliber")]
            [Validation(Required=false)]
            public string KpiCaliber { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("kpiId")]
            [Validation(Required=false)]
            public string KpiId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("kpiName")]
            [Validation(Required=false)]
            public string KpiName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public string Period { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

    }

}
