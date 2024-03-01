// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class GetUserLastMetricResponseBody : TeaModel {
        [NameInMap("metricMap")]
        [Validation(Required=false)]
        public Dictionary<string, MetricMapValue> MetricMap { get; set; }

    }

}
