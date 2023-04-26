// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class PullDataByPageRequest : TeaModel {
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("dataModelId")]
        [Validation(Required=false)]
        public string DataModelId { get; set; }

        [NameInMap("datetimeFilterField")]
        [Validation(Required=false)]
        public string DatetimeFilterField { get; set; }

        [NameInMap("maxDatetime")]
        [Validation(Required=false)]
        public long? MaxDatetime { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("minDatetime")]
        [Validation(Required=false)]
        public long? MinDatetime { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
