// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class QueryReportStatisticalDataResponseBody : TeaModel {
        [NameInMap("dataList")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> DataList { get; set; }

        [NameInMap("metaList")]
        [Validation(Required=false)]
        public List<QueryReportStatisticalDataResponseBodyMetaList> MetaList { get; set; }
        public class QueryReportStatisticalDataResponseBodyMetaList : TeaModel {
            [NameInMap("kpiCaliber")]
            [Validation(Required=false)]
            public string KpiCaliber { get; set; }

            [NameInMap("kpiId")]
            [Validation(Required=false)]
            public string KpiId { get; set; }

            [NameInMap("kpiName")]
            [Validation(Required=false)]
            public string KpiName { get; set; }

            [NameInMap("period")]
            [Validation(Required=false)]
            public string Period { get; set; }

            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

    }

}
