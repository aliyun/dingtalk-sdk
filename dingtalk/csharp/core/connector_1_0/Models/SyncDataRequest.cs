// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class SyncDataRequest : TeaModel {
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("triggerDataList")]
        [Validation(Required=false)]
        public List<SyncDataRequestTriggerDataList> TriggerDataList { get; set; }
        public class SyncDataRequestTriggerDataList : TeaModel {
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            [NameInMap("customTriggerId")]
            [Validation(Required=false)]
            public string CustomTriggerId { get; set; }

            [NameInMap("dataGmtCreate")]
            [Validation(Required=false)]
            public long? DataGmtCreate { get; set; }

            [NameInMap("dataGmtModified")]
            [Validation(Required=false)]
            public long? DataGmtModified { get; set; }

            [NameInMap("integrationObject")]
            [Validation(Required=false)]
            public string IntegrationObject { get; set; }

            [NameInMap("jsonData")]
            [Validation(Required=false)]
            public string JsonData { get; set; }

            [NameInMap("triggerCondition")]
            [Validation(Required=false)]
            public string TriggerCondition { get; set; }

            [NameInMap("triggerId")]
            [Validation(Required=false)]
            public string TriggerId { get; set; }

        }

    }

}
